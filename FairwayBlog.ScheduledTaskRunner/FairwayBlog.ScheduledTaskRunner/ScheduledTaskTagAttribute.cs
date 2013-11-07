using System;

namespace FairwayBlog.ScheduledTaskRunner
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ScheduledTaskTagAttribute : Attribute
    {
        public string Tag { get; set; }
    }
}
