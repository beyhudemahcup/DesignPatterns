using ChainOfResponsibilityDesignPattern;

namespace ChildOfResponsibilityDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //its obvious in the name what is chain of responsibility design pattern :)

            //we should give limited authorization to the classes and
            //the authorization should be increased according to inherited classes 

            Console.WriteLine("Welcome the Coder Bank!");
            Console.WriteLine("You can apply loan for your personal use.");
            Console.WriteLine("Be aware that you can be rejected for your request");
            Console.WriteLine("Please enter how much money you want to loan:");

            try
            {
                int amount = Convert.ToInt32(Console.ReadLine());

                ResponsibilityController rb = new ResponsibilityController();
                rb.ResponsibilityControl(amount);

            }
            catch (Exception)
            {
                Console.WriteLine("Your value is so high than we expected! Please try again");
            }
}
    }
}