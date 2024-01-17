namespace MediatorDesignPattern
{
    internal interface IActor
    {
        void RecieveMessage(string message);
        void SendMessage(string topic, string message);
    }
}
