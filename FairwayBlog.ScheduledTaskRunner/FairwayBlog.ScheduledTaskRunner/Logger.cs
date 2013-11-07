using System;
using NLog;

namespace FairwayBlog.ScheduledTaskRunner
{
    public static class Logger
    {
        private static readonly NLog.Logger LogHelper = LogManager.GetCurrentClassLogger();

        public static void Info(string message)
        {
            LogHelper.Info(message);
        }

        public static void Info(string message, Exception exception)
        {
            LogHelper.InfoException(message, exception);
        }

        public static void Warn(string message)
        {
            LogHelper.Warn(message);
        }

        public static void Warn(string message, Exception exception)
        {
            LogHelper.WarnException(message, exception);
        }

        public static void Debug(string message)
        {
            LogHelper.Debug(message);
        }

        public static void Debug(string message, Exception exception)
        {
            LogHelper.DebugException(message, exception);
        }

        public static void Error(string message)
        {
            LogHelper.Error(message);
        }

        public static void Error(string message, Exception exception)
        {
            LogHelper.ErrorException(message, exception);
        }

        public static void Error(Exception exception)
        {
            LogHelper.Error(exception);
        }

        public static void Fatal(string message)
        {
            LogHelper.Fatal(message);
        }

        public static void Fatal(string message, Exception exception)
        {
            LogHelper.FatalException(message, exception);
        }

        public static void Fatal(Exception exception)
        {
            LogHelper.Fatal(exception);
        }
    }
}
