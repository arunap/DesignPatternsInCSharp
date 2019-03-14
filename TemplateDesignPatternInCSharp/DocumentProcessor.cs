using System.IO;

namespace TemplateDesignPatternInCSharp
{
    public abstract class DocumentProcessor
    {
        public void Process(string filePath)
        {
            var stream = Open(filePath);

            this.Read(stream);
            this.Lock(stream);
            this.Save(stream);
        }

        public abstract Stream Open(string filePath);
        public abstract void Read(Stream stream);
        public abstract void Lock(Stream stream);
        public abstract void Save(Stream stream);
    }
}
