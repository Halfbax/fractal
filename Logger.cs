using System;

namespace FA_Fraktale
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
        public static void Log(SecruityLevel sl, string message)
        {
            Console.WriteLine(String.Concat( sl.ToString(), " | ", DateTime.Now, " | ", message));

            if (sl == SecruityLevel.ERROR)
                Console.ReadKey();
        }
    }
}
