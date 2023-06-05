using ConsoleApp1.Interface;

namespace ConsoleApp1
{
    public class Calculator
    {
        private readonly IStrategy _strategy;

        public Calculator(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal Calculate(decimal distance)
        {
            return _strategy.GetTotalSum(distance);
        }
    }
}
