namespace MediatorDesignPattern
{
    internal class ConcreteMediator
    {
        public void ConcreateMediatorDemo()
        {
            MessageDispatcher dispatcher = new MessageDispatcher();

            IActor actor1 = new MessageActor("Actor 1", dispatcher);
            IActor actor2 = new MessageActor("Actor 2", dispatcher);
            IActor actor3 = new MessageActor("Actor 3", dispatcher);
            IActor actor4 = new MessageActor("Actor 4", dispatcher);

            dispatcher.Register("Topic 1", actor1);
            dispatcher.Register("Topic 2", actor2);
            dispatcher.Register("Topic 3", actor3);
            dispatcher.Register("Topic 4", actor4);

            actor1.SendMessage("Topic 1", "Message about topic 1");
            actor1.SendMessage("Topic 2", "Message about topic 2");
            actor1.SendMessage("Topic 3", "Message about topic 3");
            actor1.SendMessage("Topic 4", "Message about topic 4");

        }
    }
}

