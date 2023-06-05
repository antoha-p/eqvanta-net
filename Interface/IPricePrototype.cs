namespace ConsoleApp1.Interface
{
    public interface IPricePrototype
    {
        public IPrice Create(decimal distance, decimal amount);
    }
}
