using ConsoleApp1.Interface;

namespace ConsoleApp1
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Log(LogLevel.Error, message);
        }

        public void Log(LogLevel level, string message)
        {
            Console.WriteLine(message);
        }
    }
}
