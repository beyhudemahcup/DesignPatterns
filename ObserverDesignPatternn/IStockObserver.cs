namespace ObserverDesignPattern
{
    internal interface IStockObserver
    {
        void Update(string stockSymbol, decimal stockPrice);
    }
}
