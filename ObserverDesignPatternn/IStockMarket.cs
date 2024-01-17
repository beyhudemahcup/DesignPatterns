namespace ObserverDesignPattern
{
    //this is a subject interface
    //its about to be observe
    internal interface IStockMarket
    {
        void RegisterObserver(IStockObserver _stockObserver);
        
        void RemoveObserver(IStockObserver _stockObserver);
        
        void NotifyObservers();

        void UpdateStockPrice(string stockSymbol, decimal newPrice);
    }
}
