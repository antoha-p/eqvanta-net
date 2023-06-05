using ConsoleApp1.Strategy;
using ConsoleApp1.Price;
using ConsoleApp1.Interface;
using ConsoleApp1.Config;

namespace ConsoleApp1
{
    internal class Program
    {
        private static readonly ILogger _logger = ServiceLocator.Resolve<ILogger>();

        static int Main()
        {
            Console.WriteLine("Starting...");

            DI.Configure();

            try
            {
                var strategy = new TaskStrategy();
                strategy.AddPrice(new SimplePrice(0, 100));
                strategy.AddPrice(new SimplePrice(100, 80));
                strategy.AddPrice(new SimplePrice(300, 70));

                var calc = new Calculator(strategy);
                decimal result = calc.Calculate(305);

                Console.WriteLine(result);
            }
            catch(Exception e)
            {
                _logger.Error(e.Message);

                return -1;
            }

            return 0;
        }
    }
}