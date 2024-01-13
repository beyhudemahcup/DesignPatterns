
namespace FactoryDesignPattern
{
    public class FactoryDPRunner
    {

        public static void Main(string[] args)
        {
            IShape circle1 = new Circle();
            circle1.Draw();

            IShape rectangle1 = new Rectangle();
            rectangle1.Draw();

            IShape square1 = new Square();
            square1.Draw();

            //instead of creating objects from every class, We should create a factory class to work according to input and 
            //return required class

            //using circle Factory
            IShapeFactory circleFactory = new CircleFactory();
            IShape circle = circleFactory.GetShape("CIRCLE");
            circle.Draw();

            // Using Rectangle factory
            IShapeFactory rectangleFactory = new RectangleFactory();
            IShape rectangle = rectangleFactory.GetShape("ReCTaNglE");
            rectangle.Draw();

            //Using Square Factory
            IShapeFactory squareFactory = new SquareFactory();
            IShape square = squareFactory.GetShape("sQUSAFR");//expecting null and throwing exception
            try
            {
                square.Draw();
            }
            catch (Exception)
            {
                //I did on purpose for preventing an exception
                Console.WriteLine("Your value is not correct!!!");
            }

        }
    }
}