using System;

namespace Ex1
{
    public static class TickerFormatter
    {
        public static string FormatTicker(Money price, string name, string shortName)
        {
            return $"{DateTime.Now} {shortName}\t{price.Value,10}{price.Symbol} \t{name} valued at {price}";
        }
    }
}