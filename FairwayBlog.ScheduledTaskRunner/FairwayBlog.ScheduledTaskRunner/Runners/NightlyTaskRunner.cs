namespace FairwayBlog.ScheduledTaskRunner.Runners
{
    [ScheduledTaskTag(Tag = "nightly")]
    public class NightlyTaskRunner : ITaskRunner
    {
        public void Run(params string[] args)
        {
            Logger.Debug("Running out nightly tasks here");
        }
    }
}
