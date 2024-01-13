using SingletonDesignPattern;

namespace SingletonDesignPattern
{

    public class Program
    {
        public static void Main(string[] args)
        {
            SimpleClass singletonDesignPattern = new SimpleClass();
           
            //now we can get the instance in our main method. It supposes to show a message 
            singletonDesignPattern.CallTheSingleton();

        }
    }
}
public class SimpleClass
{
    public void CallTheSingleton()
    {
        SingletonObject instance = SingletonObject.Instance;//can't create a new instance but call the singleton instance which I want to to
        instance.SingletonCalling();
    }
}