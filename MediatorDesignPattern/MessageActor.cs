namespace MediatorDesignPattern
{
    internal class MessageActor : IActor
    {
        string _name;
        IDispatcher _dispatcher;

        public MessageActor(string name, IDispatcher dispatcher)
        {
            _name = name;
            _dispatcher = dispatcher;
        }

        public void RecieveMessage(string message)
        {
            Console.WriteLine(_name + " recieved message: " + message);
        }

        public void SendMessage(string topic, string message)
        {
            _dispatcher.Dispatch(topic, message); 
        }
    }
}
