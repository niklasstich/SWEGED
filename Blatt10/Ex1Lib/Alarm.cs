using System;
using System.Collections.Generic;

namespace Ex1
{
    public class Alarm : IObserver
    {
        private decimal alertFactor;
        private Dictionary<string, decimal> initialValues = new Dictionary<string, decimal>();

        public Alarm(decimal alertFactor = 2.0m)
        {
            this.alertFactor = alertFactor;
        }

        public void Update(Money price, string name, string shortName)
        {
            if (!initialValues.ContainsKey(name))
                initialValues[name] = price.Value;

            if (price.Value < initialValues[name] * alertFactor)
            {
                return;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"!!! {TickerFormatter.FormatTicker(price, name, shortName)} !!!");
            Console.ResetColor();
        }
    }
}