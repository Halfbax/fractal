using System;
using System.Threading;

namespace Leonsporsde.Utilities
{
    /// <summary>
    /// Log-Level
    /// </summary>
    public enum SecruityLevel
    {
        INFO,
        WARN,
        ERROR
    }

    public static class Logger
    {
        /// <summary>
        /// Formats the message for debugging
        /// </summary>
        /// <param name="sl">Secruitylevel</param>
        /// <param name="message">Message</param>
        public static void Log(SecruityLevel sl, string message)
        {
            Console.WriteLine(String.Concat( sl.ToString(), " | ", Thread.CurrentThread.ManagedThreadId, " | ", DateTime.Now, " | ", message));

            if (sl == SecruityLevel.ERROR)
                Console.ReadKey();
        }
    }
}
