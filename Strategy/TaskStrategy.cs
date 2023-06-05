using ConsoleApp1.Interface;

namespace ConsoleApp1.Strategy
{
    public class TaskStrategy : IStrategy
    {
        private List<IPrice> _prices = new();

        public decimal GetTotalSum(decimal distance)
        {
            decimal result = 0;
            IPrice nextPrice;
            var lastPrice = _prices[^1];

            foreach (var price in _prices)
            {
                if (lastPrice != price)
                {
                    nextPrice = _prices[_prices.IndexOf(price) + 1];
                }
                else
                {
                    nextPrice = price.Create(distance, price.GetAmount());
                }

                if (price.GetDistance() < distance)
                {
                    result += (Math.Min(nextPrice.GetDistance(), distance) - price.GetDistance()) * price.GetAmount();
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public void AddPrice(IPrice price)
        {
            if (price.GetDistance() < 0 || price.GetAmount() < 0)
            {
                throw new ArgumentException("Wrong distance or amount");
            }

            _prices.Add(price);
            //сортируем список по возрастания
            _prices = _prices.OrderBy(x => x.GetDistance()).ToList();
        }
    }
}
