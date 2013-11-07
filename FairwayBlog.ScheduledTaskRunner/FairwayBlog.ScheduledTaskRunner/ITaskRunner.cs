namespace FairwayBlog.ScheduledTaskRunner
{
    public interface ITaskRunner
    {
        void Run(params string[] args);
    }
}
