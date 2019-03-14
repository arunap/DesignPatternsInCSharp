using SingletonDesignPatternInCSharp.Contracts;
using System;
using System.IO;

namespace SingletonDesignPatternInCSharp
{
    public sealed class FileLogger : ILogger
    {
        /// <summary>
        /// the thread is locked on a shared object and 
        /// checks whether an instance has been created or not
        /// </summary>
        private static readonly object padlock = new object();
        private static FileLogger _instance = null;

        public static FileLogger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new FileLogger();
                        }
                    }
                }
                return _instance;
            }
        }

        private FileLogger() { }

        public void Log(string message)
        {
            var msg = $"Message: {message}";

            Console.WriteLine(msg);
            File.WriteAllText("C:\\logs.txt", msg);
        }
    }
}
