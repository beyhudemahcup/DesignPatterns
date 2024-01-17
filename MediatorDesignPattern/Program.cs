namespace MediatorDesignPattern
{
    public class Program
    {
        public static void Main(string[] args) 
        { 
            ConcreteMediator mediator = new ConcreteMediator();
            
            //runs for every actor and every message which I designed for to do
            mediator.ConcreateMediatorDemo();
        }
    }
}