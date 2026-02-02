using System.Collections.Immutable;
using Jig.Targets;
using QuikGraph;
using QuikGraph.Algorithms;
using QuikGraph.Algorithms.Search;
using Jig.Lang;

namespace Jig.Build;

public class TargetGraph
{
    /// <summary>
    /// Represents target triggering relationships in the build.
    /// Each edge in the graph represents the source node triggering the target node.
    /// Can have cycles. 
    /// </summary>
    public ArrayAdjacencyGraph<ITarget, Edge<ITarget>> AllTargetsTriggerGraph { get; }

    /// <summary>
    /// Represents target ordering relationships of all targets in the build.
    /// Each edge represents an "after" relationship, where the source is executed after the target.
    /// Cannot have cycles.
    /// </summary>
    public ArrayAdjacencyGraph<ITarget, Edge<ITarget>> AllTargetsExecutionGraph { get; }

    /// <summary>   
    /// All targets listed in execution order based on a topological sort
    /// </summary>
    public IEnumerable<ITarget> AllTargetsInOrder => AllTargetsExecutionGraph
        .TopologicalSort()
        .Reverse();
    
    /// <summary>
    /// Cycles detected in the execution graph. 
    /// </summary>
    public ImmutableArray<Edge<ITarget>> AllTargetsExecutionGraphCycles { get; }
    
    /// <summary>
    /// Represents target ordering relationships of targets invoked in the build.
    /// Each edge represents an "after" relationship, where the source is executed after the target.
    /// Cannot have cycles.
    /// </summary>
    public ArrayAdjacencyGraph<ITarget, Edge<ITarget>> InvokedExecutionGraph { get; }

    /// <summary>   
    /// All invoked targets listed in execution order based on a topological sort
    /// </summary>
    public IEnumerable<ITarget> InvokedTargetsInOrder => InvokedExecutionGraph
        .TopologicalSort()
        .Reverse();
    
    public TargetGraph(
        IReadOnlyDictionary<string, ITarget> allTargets,
        string[] invokedTargets
    )
    {
        // Build Trigger Graph
        var triggerGraph = new AdjacencyGraph<ITarget, Edge<ITarget>>();
        triggerGraph.AddVertexRange(allTargets.Values);

        triggerGraph.AddEdgeRange(allTargets.Values
            .SelectMany(source => source.Triggers
                .Select(f => f())
                .Where(t => allTargets.Values.Contains(t))
                .Select(target => new Edge<ITarget>(source, target))
            ).ToArray()
        );

        triggerGraph.AddEdgeRange(allTargets.Values
            .SelectMany(target => target.TriggeredBy
                .Select(f => f())
                .Where(t => allTargets.Values.Contains(t))
                .Select(source => new Edge<ITarget>(source, target))
            ).ToArray()
        );

        AllTargetsTriggerGraph = triggerGraph.ToArrayAdjacencyGraph();

        // Build Execution Graph
        AllTargetsExecutionGraph = BuildExecutionGraph(allTargets.Values.ToHashSet());
        
        // Detect cycles
        {
            var dfs = new DepthFirstSearchAlgorithm<ITarget, Edge<ITarget>>(AllTargetsExecutionGraph);
            var cycles = new List<Edge<ITarget>>();
            dfs.BackEdge += edge => cycles.Add(edge);
            dfs.Compute();
            AllTargetsExecutionGraphCycles = cycles.ToImmutableArray();
        }

        // InvokedExecution Graph
        {
            var invoked = invokedTargets
                .SelectFrom(allTargets)
                .ToArray();

            var triggered = invoked.ToHashSet();

            var dfs = new DepthFirstSearchAlgorithm<ITarget, Edge<ITarget>>(AllTargetsTriggerGraph);

            dfs.DiscoverVertex += v => triggered.Add(v);

            foreach (var root in invoked)
            {
                dfs.Compute(root);
            }

            InvokedExecutionGraph = BuildExecutionGraph(triggered);
        }
    }

    private static ArrayAdjacencyGraph<ITarget, Edge<ITarget>> BuildExecutionGraph(
        IReadOnlyCollection<ITarget> targets
    )
    {
        var executionGraph = new AdjacencyGraph<ITarget, Edge<ITarget>>();
        executionGraph.AddVertexRange(targets);

        executionGraph.AddEdgeRange(targets
            .SelectMany(source => source.After
                .Select(f => f())
                .Where(targets.Contains)
                .Select(target => new Edge<ITarget>(source, target))
            ).ToArray()
        );

        executionGraph.AddEdgeRange(targets
            .SelectMany(target => target.Before
                .Select(f => f())
                .Where(targets.Contains)
                .Select(source => new Edge<ITarget>(target, source))
            ).ToArray()
        );

        return executionGraph.ToArrayAdjacencyGraph();
    }
}