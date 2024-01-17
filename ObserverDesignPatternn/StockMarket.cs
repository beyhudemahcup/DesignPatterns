namespace ObserverDesignPattern
{
    internal class StockMarket : IStockMarket
    {
        private List<IStockObserver> observers = new List<IStockObserver>();

        private Dictionary<string, decimal> stockPrices = new Dictionary<string, decimal>();
       
        public void NotifyObservers()
        {
            foreach (var keyValue in stockPrices)
            {
                string stockSymbol = keyValue.Key;
                decimal stockPrice = keyValue.Value;

                foreach (var observer in observers)
                {
                    observer.Update(stockSymbol, stockPrice);
                }
            }
        }

        public void RegisterObserver(IStockObserver _stockObserver)
        {
            observers.Add(_stockObserver);
        }

        public void RemoveObserver(IStockObserver _stockObserver)
        {
            observers.Remove(_stockObserver);
        }

        public void UpdateStockPrice(string stockSymbol, decimal newPrice)
        {
            if (stockPrices.ContainsKey(stockSymbol))
            {
                stockPrices[stockSymbol] = newPrice;
            }
            else
            {
                stockPrices.Add(stockSymbol, newPrice);
            }

            // Notify observers when stock prices are updated
            NotifyObservers();
        }
    }
}
