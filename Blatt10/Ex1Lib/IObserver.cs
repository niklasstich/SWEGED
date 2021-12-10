namespace Ex1
{
    public interface IObserver
    {
        void Update(Money price, string name, string shortName);
    }
}