namespace MediatorDesignPattern
{
    internal class MessageDispatcher : IDispatcher
    {
        Dictionary<string, IActor> registeredActors = new Dictionary<string, IActor>();

        public void Register(string topic, IActor actor)
        {
            registeredActors.Add(topic, actor);
        }

        public void Dispatch(string topic, string message)
        {
            IActor actor = registeredActors[topic];
            
            if (actor == null)
            {
                Console.WriteLine("Incorrect input! No actor registered for this input value!");
            }
            else
            {
                actor.RecieveMessage(message);
            }
        }
    }
}
