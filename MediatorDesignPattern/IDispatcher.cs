namespace MediatorDesignPattern
{
    internal interface IDispatcher
    {
        void Dispatch(string topic, string message);
    }
}
