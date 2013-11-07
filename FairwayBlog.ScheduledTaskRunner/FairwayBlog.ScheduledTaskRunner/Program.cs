using System;
using System.Collections.Generic;

namespace FairwayBlog.ScheduledTaskRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            // there must be at least the task tag passed in
            if (args.Length == 0)
            {
                Logger.Warn("ScheduledTaskRunner ran without any parameters.");
                return;
            }

            try
            {
                // the first parameter must be the tag (e.g. hourly, nightly, monthly)
                var tag = args[0];

                var parameters = new List<string>(args);
                parameters.RemoveAt(0); // remove this and pass the rest to the actual runner as parameters

                // get and run the specified runner passing in any command line params that were received
                TaskRunnerFactory.Run(tag, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }
    }
}
