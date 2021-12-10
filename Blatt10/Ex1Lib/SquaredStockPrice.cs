using System;

namespace Ex1
{
    public class SquaredStockPrice : StockPrice
    {
        public SquaredStockPrice(char symbol, string currency, decimal value) : base(symbol, currency, value)
        {
        }

        public override void UpdateValue()
        {
            if (RandomHelper.GetBool())
                Price.Value *= Price.Value;
            else //oof ouch rounding juice
                Price.Value = (decimal)Math.Sqrt((double)Price.Value);
            Round();
        }
    }
}