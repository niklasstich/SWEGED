namespace Ex1
{
    public class Stock : Subject
    {
        public Stock(StockPrice price, string name, string shortName)
        {
            Price = price;
            Name = name;
            ShortName = shortName;
        }

        public StockPrice Price
        {
            get;
        }

        public string Name
        {
            get;
        }

        public string ShortName
        {
            get;
        }


        public override void Update()
        {
            Price.UpdateValue();
            foreach (var observer in Observers)
            {
                observer.Update(Price.Price, Name, ShortName);
            }
        }
    }
}