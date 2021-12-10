using System;

namespace Ex1
{
    public abstract class StockPrice
    {
        protected StockPrice(char symbol, string currency, decimal value)
        {
            Price = new Money(symbol, currency, value);
        }

        public Money Price
        {
            get;
            protected set;
        }

        public abstract void UpdateValue();

        protected void Round()
        {
            Price.Value = Math.Round(Price.Value, 2);
        }
    }
}