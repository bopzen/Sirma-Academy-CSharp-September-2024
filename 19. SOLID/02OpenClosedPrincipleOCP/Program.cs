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


            DiscountCalculator studentCalculator = new DiscountCalculator(new StudentDiscount());
            Console.WriteLine($"Student discount: {studentCalculator.Calculate(100)}");

            DiscountCalculator seniorCalculator = new DiscountCalculator(new SeniorDiscount());
            Console.WriteLine($"Senior discount: {seniorCalculator.Calculate(100)}");
        }
    }
}
