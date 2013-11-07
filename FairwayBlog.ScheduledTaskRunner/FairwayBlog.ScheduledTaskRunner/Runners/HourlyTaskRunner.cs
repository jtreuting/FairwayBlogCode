namespace FairwayBlog.ScheduledTaskRunner.Runners
{
    [ScheduledTaskTag(Tag= "hourly")]
    public class HourlyTaskRunner : ITaskRunner
    {
        public void Run(params string[] args)
        {
            Logger.Debug("Running out hourly tasks here");
        }
    }
}
