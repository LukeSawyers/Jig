using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using xBuild.Lang;

namespace xBuild.Targets;

/// <summary>
///     Builtin execution extensions for <see cref="ITarget" />
/// </summary>
public static class TargetExtensions
{
    private static FormattableString DescriptionFromDelegate(Delegate execution)
    {
        FormattableString result = $"(";
        var parameters = execution.Method.GetParameters();
        for (var index = 0; index < parameters.Length; index++)
        {
            var parameter = parameters[index];
            var isLast = index == parameters.Length - 1;
            var typeName = parameter.ParameterType.Name + (parameter.IsOptional ? "?" : string.Empty);
            result = result
                .Concat($"{typeName} ")
                .ConcatString(parameter.Name)
                .LetIf(!isLast, r => r.ConcatString(", "));
        }
            
        return result.Concat($") => {execution.Method.ReturnParameter.ParameterType.Name}");
    }
    
    extension(ITarget target)
    {
        /// <summary>
        ///     Adds an expression to be executed to this target
        /// </summary>
        /// <param name="execution">The expression to execute</param>
        /// <returns></returns>
        public ITarget ExecutesExpression<T1>(Expression<Action<T1>> execution)
        {
            target.Executions.Add(new TargetExecution(execution.Compile(), FormattableStringFactory.Create(execution.ToString())));
            return target;
        }

        /// <summary>
        ///     Adds an expression to be executed to this target
        /// </summary>
        /// <param name="execution">The expression to execute</param>
        /// <returns></returns>
        public ITarget ExecutesExpression<T1, T2>(Expression<Action<T1, T2>> execution)
        {
            target.Executions.Add(new TargetExecution(execution.Compile(), FormattableStringFactory.Create(execution.ToString())));
            return target;
        }
    }
    
    extension<T>(T target) where T : ITarget
    {
        /// <summary>
        ///     Adds a delegate to be executed to this target
        /// </summary>
        /// <param name="execution">The function to execute</param>
        /// <param name="description">Description of the function</param>
        /// <returns></returns>
        public T Executes(Delegate execution, FormattableString? description = null)
        {
            target.Executions.Add(new TargetExecution(execution, description ?? DescriptionFromDelegate(execution)));
            return target;
        }

        /// <summary>
        ///     Adds an expression to be executed to this target
        /// </summary>
        /// <param name="execution">The expression to execute</param>
        /// <returns></returns>
        public T ExecutesExpression(Expression<Action> execution)
        {
            target.Executes(execution.Compile(), FormattableStringFactory.Create(execution.ToString()));
            return target;
        }

        /// <summary>
        ///     Specifies that this target should run even if a prior target fails
        /// </summary>
        /// <returns></returns>
        public T ExecuteAfterFailure()
        {
            target.UpstreamFailureMode = UpstreamFailureMode.Continue;
            return target;
        }

        /// <summary>
        ///     Specifies that the build should continue even if this target fails
        /// </summary>
        /// <returns></returns>
        public T ProceedAfterFailure()
        {
            target.DownstreamFailureMode = DownstreamFailureMode.Continue;
            return target;
        }

        /// <summary>
        ///     Specifies that the target should not be shown in the CLI
        /// </summary>
        /// <returns></returns>
        public T Unlisted()
        {
            target.Unlisted = true;
            return target;
        }

        /// <summary>
        ///     Specifies that this target runs after the supplied targets
        /// </summary>
        /// <param name="targets"></param>
        /// <returns></returns>
        public T After(params Func<ITarget>[] targets)
        {
            foreach (var linkedTarget in targets)
            {
                target.After.Add(linkedTarget);
            }

            return target;
        }

        /// <summary>
        ///     Specifies that this target runs before the supplied targets
        /// </summary>
        /// <param name="targets"></param>
        /// <returns></returns>
        public T Before(params Func<ITarget>[] targets)
        {
            foreach (var linkedTarget in targets)
            {
                target.Before.Add(linkedTarget);
            }

            return target;
        }

        /// <summary>
        ///     Specifies that the supplied targets should cause this target to be invoked
        /// </summary>
        /// <param name="targets"></param>
        /// <returns></returns>
        private T TriggeredBy(params Func<ITarget>[] targets)
        {
            foreach (var linkedTarget in targets)
            {
                target.TriggeredBy.Add(linkedTarget);
            }

            return target;
        }

        /// <summary>
        ///     Specifies that the supplied targets should cause this target to be invoked after those targets
        /// </summary>
        /// <param name="targets"></param>
        /// <returns></returns>
        public T TriggeredAfter(params Func<ITarget>[] targets)
        {
            target.TriggeredBy(targets);
            return target.After(targets);
        }

        /// <summary>
        ///     Specifies that the supplied targets should cause this target to be invoked before those targets
        /// </summary>
        /// <param name="targets"></param>
        /// <returns></returns>
        public T DependentFor(params Func<ITarget>[] targets)
        {
            target.TriggeredBy(targets);
            return target.Before(targets);
        }

        /// <summary>
        ///     Specifies that invoking this target invokes the supplied targets
        /// </summary>
        /// <param name="targets"></param>
        /// <returns></returns>
        private T Triggers(params Func<ITarget>[] targets)
        {
            foreach (var linkedTarget in targets)
            {
                target.Triggers.Add(linkedTarget);
            }

            return target;
        }

        /// <summary>
        ///     Specifies that invoking this target invokes the supplied targets to be executed after this target
        /// </summary>
        /// <param name="targets"></param>
        /// <returns></returns>
        public T TriggersBefore(params Func<ITarget>[] targets)
        {
            target.Triggers(targets);
            return target.Before(targets);
        }

        /// <summary>
        ///     Specifies that invoking this target invokes the supplied targets to be executed before this target
        /// </summary>
        /// <param name="targets"></param>
        /// <returns></returns>
        public T DependentOn(params Func<ITarget>[] targets)
        {
            target.Triggers(targets);
            return target.After(targets);
        }
    }
}