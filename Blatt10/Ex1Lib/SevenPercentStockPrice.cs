using System;

namespace Ex1
{
    public class SevenPercentStockPrice : StockPrice
    {
        private Random rand;
        public SevenPercentStockPrice(char symbol, string currency, decimal value) : base(symbol, currency, value)
        {
            rand = new Random();
        }

        public override void UpdateValue()
        {
            if (RandomHelper.GetBool()) //coinflip
            {
                Price.Value *= 1.07m;
            }
            else
            {
                Price.Value *= 0.93m;
            }

            Round();
        }
    }
}