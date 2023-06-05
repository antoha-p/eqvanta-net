namespace ConsoleApp1.Interface
{
    public interface IPrice : IPricePrototype
    {
        decimal GetDistance();
        decimal GetAmount();
    }
}
