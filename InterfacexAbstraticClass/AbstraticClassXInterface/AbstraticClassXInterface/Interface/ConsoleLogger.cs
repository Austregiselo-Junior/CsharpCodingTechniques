using System;

namespace AbstraticClassXInterface.Interface
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"ConsoleLogger: {message}");
        }
    }
}
