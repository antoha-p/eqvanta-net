namespace ConsoleApp1.Interface
{
    public enum LogLevel
    {
        Error = 0,
        Warning = 1,
        Info = 2
    }

    public interface ILogger
    {
        public void Log(LogLevel level, string message);
        public void Error(string message);
    }
}
