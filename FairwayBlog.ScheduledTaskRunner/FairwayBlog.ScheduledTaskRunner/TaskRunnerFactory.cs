using System;
using System.Linq;
using System.Reflection;
using FairwayBlog.ScheduledTaskRunner.Extensions;

namespace FairwayBlog.ScheduledTaskRunner
{
    public static class TaskRunnerFactory
    {
        public static ITaskRunner GetInstance(string tag)
        {
            if (String.IsNullOrEmpty(tag))
                throw new ArgumentNullException("tag");

            var runnerType =
                Assembly.GetExecutingAssembly()
                        .GetTypes()
                        .FirstOrDefault(
                            t =>
                                typeof(ITaskRunner).IsAssignableFrom(t) &&
                                t.HasAttribute<ScheduledTaskTagAttribute>() &&
                                t.GetOneAttribute<ScheduledTaskTagAttribute>().Tag.ToLower() == tag.ToLower()
                        );

            if (runnerType == null)
                throw new ArgumentException("Invalid tag.", "tag");

            return (ITaskRunner) Activator.CreateInstance(runnerType);
        }

        public static void Run(string tag, params string[] args)
        {
            var runner = GetInstance(tag);
            runner.Run(args);
        }
    }
}
