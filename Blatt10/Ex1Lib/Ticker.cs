using System;

namespace Ex1
{
    public class Ticker : IObserver
    {
        public void Update(Money price, string name, string shortName)
        {
            Console.WriteLine(TickerFormatter.FormatTicker(price, name, shortName));
        }
    }
}