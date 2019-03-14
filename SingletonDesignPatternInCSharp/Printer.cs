using SingletonDesignPatternInCSharp.Contracts;
using System;

namespace SingletonDesignPatternInCSharp
{
    public sealed class Printer : IPrinter
    {
        /// <summary>
        /// the thread is locked on a shared object and 
        /// checks whether an instance has been created or not
        /// </summary>
        private static readonly object padlock = new object();

        private static Printer _instance = null;

        /// <summary>
        /// the thread is locked on a shared object and checks whether an instance has been created or 
        /// not with double checking
        /// </summary>
        public static Printer Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Printer();
                        }
                    }
                }

                return _instance;
            }
        }

        /// <summary>
        /// A single constructor, that is private and parameterless.
        /// </summary>
        private Printer() { }

        /// <summary>
        /// Print method, one at a time 
        /// </summary>
        /// <param name="fileName"> Name of the file to print</param>
        public void Print(string fileName)
        {
            Console.WriteLine($"Printing {fileName}");
        }
    }
}
