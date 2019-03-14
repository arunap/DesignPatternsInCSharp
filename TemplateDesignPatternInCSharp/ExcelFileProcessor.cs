using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPatternInCSharp
{
    public class ExcelFileProcessor : DocumentProcessor
    {
        public override Stream Open(string filePath)
        {
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
