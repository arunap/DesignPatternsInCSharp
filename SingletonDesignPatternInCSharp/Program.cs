using System;

namespace SingletonDesignPatternInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print
            Console.WriteLine("===== Printer started! =====");
            Printer.Instance.Print("Interview Questions.docx");
            Console.WriteLine(Environment.NewLine);

            Printer.Instance.Print("Salary Slips.docx");
            Console.WriteLine(Environment.NewLine);

            // Logger
            FileLogger.Instance.Log("Logging first message.");
            FileLogger.Instance.Log("Logging second message.");
            FileLogger.Instance.Log("Logging third message.");
        }
    }
}
