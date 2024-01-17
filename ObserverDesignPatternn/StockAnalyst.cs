using System.Xml.Linq;

namespace ObserverDesignPattern
{
    internal class StockAnalyst : IStockObserver
    {
        private string _name;

        public StockAnalyst(string name)
        {
            _name = name;
        }

        public void Update(string stockSymbol, decimal stockPrice)
        {
            Console.WriteLine($"{_name} received update: Analyzing {stockSymbol} at ${stockPrice}");
        }
    }
}
