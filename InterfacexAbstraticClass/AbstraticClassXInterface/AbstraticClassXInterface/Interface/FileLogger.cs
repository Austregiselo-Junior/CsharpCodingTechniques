using System.IO;

namespace AbstraticClassXInterface.Interface
{
    internal class FileLogger : ILogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }
        public void Log(string message)
        {
            StreamWriter writer = new StreamWriter(_filePath, true);
            writer.WriteLine($"FileLogger: {message}");
        }
    }

}
