using System.Collections.Immutable;
using QuikGraph;
using QuikGraph.Algorithms.Search;
using xBuild.Targets;

namespace xBuild.Build;

public class TargetGraph
{
    public IReadOnlyDictionary<string, ITarget> AllTargets { get; }
    
    public ArrayAdjacencyGraph<ITarget, Edge<ITarget>> TriggerGraph { get; }
    
    public ArrayAdjacencyGraph<ITarget, Edge<ITarget>> ExecutionGraph { get; }
    
    public ImmutableArray<Edge<ITarget>> ExecutionGraphCycles { get; }
    
    public TargetGraph(
        IReadOnlyDictionary<string, ITarget> allTargets
    )
    {
        AllTargets = allTargets;
        
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
        
        TriggerGraph = triggerGraph.ToArrayAdjacencyGraph();
        
        // Build Execution Graph
        var executionGraph = new AdjacencyGraph<ITarget, Edge<ITarget>>();
        executionGraph.AddVertexRange(allTargets.Values);

        executionGraph.AddEdgeRange(allTargets.Values
            .SelectMany(source => source.After
                .Select(f => f())
                .Where(t => allTargets.Values.Contains(t))
                .Select(target => new Edge<ITarget>(source, target))
            ).ToArray()
        );
        
        executionGraph.AddEdgeRange(allTargets.Values
            .SelectMany(target => target.Before
                .Select(f => f())
                .Where(t => allTargets.Values.Contains(t))
                .Select(source => new Edge<ITarget>(target, source))
            ).ToArray()
        );
        
        ExecutionGraph = executionGraph.ToArrayAdjacencyGraph();
        
        // Detect cycles
        var dfs = new DepthFirstSearchAlgorithm<ITarget, Edge<ITarget>>(executionGraph);
        var cycles = new List<Edge<ITarget>>();
        dfs.BackEdge += edge => cycles.Add(edge);
        dfs.Compute();
        ExecutionGraphCycles = cycles.ToImmutableArray();
    }

    public IReadOnlyCollection<ITarget> CollectTriggeredTargets(
        IReadOnlyCollection<string> invoked
    )
    {
        var invokedTargets = invoked
            .SelectFrom(AllTargets)
            .ToArray();
        
        var triggered = invokedTargets.ToHashSet();
        
        var dfs = new DepthFirstSearchAlgorithm<ITarget, Edge<ITarget>>(TriggerGraph);

        dfs.DiscoverVertex += v => triggered.Add(v);

        foreach (var root in invokedTargets)
        {
            dfs.Compute(root); 
        }

        return triggered;
    }
}