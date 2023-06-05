using ConsoleApp1.Interface;

namespace ConsoleApp1.Price
{
    public class SimplePrice : IPrice
    {
        private readonly decimal _distance;
        private readonly decimal _amount;

        public SimplePrice(decimal distance, decimal amount)
        {
            _distance = distance;
            _amount = amount;
        }

        public IPrice Create(decimal distance, decimal amount)
        {
            return new SimplePrice(distance, amount);
        }

        public decimal GetAmount() => _amount;

        public decimal GetDistance() => _distance;
    }
}
