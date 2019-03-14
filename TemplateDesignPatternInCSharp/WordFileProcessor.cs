using System;
using System.IO;

namespace TemplateDesignPatternInCSharp
{
    public class WordFileProcessor : DocumentProcessor
    {
        public override Stream Open(string filePath)
        {
            Console.WriteLine();
            return new MemoryStream();
        }

        public override void Read(Stream stream)
        {
            throw new NotImplementedException();
        }

        public override void Lock(Stream stream)
        {
            throw new NotImplementedException();
        }

        public override void Save(Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
