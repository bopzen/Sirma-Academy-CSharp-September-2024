namespace _02OpenClosedPrincipleOCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            var consoleLoggingService = new Logger(consoleLogger);
            consoleLoggingService.LogMessage("Logging to console.");

            ILogger fileLogger = new FileLogger(@"..\..\..\log.txt");
            var fileLoggingService = new Logger(fileLogger);
            fileLoggingService.LogMessage("Logging to file.");
        }
    }
}
