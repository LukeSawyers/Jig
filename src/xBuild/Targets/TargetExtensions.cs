namespace xBuild.Targets;

/// <summary>
///     Builtin execution extensions for <see cref="ITarget" />
/// </summary>
public static class TargetExtensions
{
    extension<T>(T target) where T : ITarget
    {
        /// <summary>
        ///     Adds a delegate to be executed to this target
        /// </summary>
        /// <param name="execution"></param>
        /// <returns></returns>
        public T Executes(Delegate execution)
        {
            target.Executions.Add(new TargetExecution(execution,  string.Empty));
            return target;
        }

        /// <summary>
        ///     Specifies that this target should run even if a prior target fails
        /// </summary>
        /// <returns></returns>
        public T ExecuteAfterFailure()
        {
            target.ExecuteAfterFailure = true;
            return target;
        }

        /// <summary>
        ///     Specifies that the build should continue even if this target fails
        /// </summary>
        /// <returns></returns>
        public T ProceedAfterFailure()
        {
            target.ProceedAfterFailure = true;
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
        public T DependsOn(params Func<ITarget>[] targets)
        {
            target.Triggers(targets);
            return target.After(targets);
        }
    }
}