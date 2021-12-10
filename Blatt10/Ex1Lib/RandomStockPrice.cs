using System;

namespace Ex1
{
    public class RandomStockPrice : StockPrice
    {
        public RandomStockPrice(char symbol, string currency, decimal value) : base(symbol, currency, value)
        {
        }

        public override void UpdateValue()
        {
            Price.Value *= RandomHelper.GetStockFactor();
            Round();
        }

    }
}