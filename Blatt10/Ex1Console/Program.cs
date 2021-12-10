using System;
using System.Collections.Generic;
using System.Threading;
using Ex1;

namespace Ex1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var ticker = new Ticker();
            var alarm = new Alarm();

            List<Stock> stocks = new List<Stock>();
            
            CreateStockAndAddObservers(new IObserver[]{ticker, alarm}, stocks, new RandomStockPrice('$', "USD", 123.45m), "Apple Inc.", "AAPL");
            CreateStockAndAddObservers(new IObserver[]{ticker, alarm}, stocks, new SevenPercentStockPrice('$', "USD", 2952.77m), "Alphabet Inc.", "GOOGL");
            CreateStockAndAddObservers(new IObserver[]{ticker, alarm}, stocks, new EqualStockPrice('$', "USD", 293.65m), "Meta Platforms Inc.", "FB2A");
            CreateStockAndAddObservers(new IObserver[]{alarm}, stocks, new SquaredStockPrice('€', "EUR", 15.81m), "Deutsche Telekom", "DTE");
            CreateStockAndAddObservers(new IObserver[]{ticker}, stocks, new RandomStockPrice('¥', "YEN", 53800m), "Nintendo Co. Ltd.", "7974.T");
            
            while (true)
            {
                foreach (var stock in stocks)
                {
                    stock.Update();
                }
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
        }

        static void CreateStockAndAddObservers(IObserver[] observers, List<Stock> stocks, StockPrice sp, string name, string shortname)
        {
            var stock = new Stock(sp, name, shortname);
            foreach (var observer in observers)
            {
                stock.Attach(observer);
            }
            stocks.Add(stock);
            
        }
    }
}