using ConsoleApp1.Price;
using ConsoleApp1.Strategy;
using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    public class DataNormal
    {
        public decimal[][] Prices;
        public decimal Distance;
        public decimal Result;

        public DataNormal(
             decimal[][] prices,
             decimal distance,
             decimal result
        )
        {
            Prices = prices;
            Distance = distance;
            Result = result;
        }
    }

    [TestFixture]
    public class CalculatorTest
    {
        private TaskStrategy _taskStrategy;
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _taskStrategy = new TaskStrategy();
            _calculator = new Calculator(_taskStrategy);
        }

        [Test]
        public void TestCalculatorEmpty()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        [TestCaseSource(nameof(DataNormals))]
        public void TestCalculatorNormal(TestData dataNormal)
        {
            for (var i = 0; i < dataNormal.Prices.GetLength(0); i++)
            {
                _taskStrategy.AddPrice(new SimplePrice(dataNormal.Prices[i, 0], dataNormal.Prices[i, 1]));
            }

            Assert.AreEqual(dataNormal.Result, _calculator.Calculate(dataNormal.Distance));
        }

        public static readonly List<TestData> DataNormals =
            new() { 
                new TestData(100, 10000, new decimal[,] { { 0, 100 }, { 100, 80 }, { 200, 50 } })
            };
    }

    public class TestData
    {
        public decimal Distance;
        public decimal Result;
        public decimal[,] Prices;

        public TestData(decimal distance, decimal result, decimal[,] prices)
        {
            Distance = distance;
            Result = result;
            Prices = prices;
        }
    }
}
