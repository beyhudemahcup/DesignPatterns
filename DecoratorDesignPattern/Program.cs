namespace DecoratorDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create basic phone object
            IPhone iphone = new ApplePhone();

            //create iphone 14pro and iphone 14 objects using by basic iphone object
            IPhone iphone14Pro = new ApplePhone14Pro((ApplePhone)iphone);//casting
            IPhone iphone14 = new ApplePhone14((ApplePhone)iphone);

            Console.WriteLine($"{iphone14Pro.GetName()}'s camera count is " + iphone14Pro.CameraCount());
            Console.WriteLine($"{iphone14Pro.GetName()}'s price is " + iphone14Pro.GetPrice());
            
            //casting to show additional functions defined only for iphone14Pro
            Console.WriteLine($"{iphone14Pro.GetName()}'s " + ((ApplePhone14Pro)iphone14Pro).AdditionalFunctions());


            Console.WriteLine($"{iphone14.GetName()}'s camera count is " + iphone14.CameraCount());
            Console.WriteLine($"{iphone14.GetName()}'s price is " + iphone14.GetPrice());
        }
    }
}