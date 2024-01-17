namespace ObserverDesignPattern 
{
    internal class StockTrader : IStockObserver
    {
        //this is a observer class that can observe the stockPrices and got the notification in Update method
        private string _name;

        public StockTrader(string name)
        {
            _name = name;
        }
        
        public void Update(string stockSymbol, decimal stockPrice)
        {
            Console.WriteLine($"{_name} received update: {stockSymbol} is now ${stockPrice}");
        }
    }
}
