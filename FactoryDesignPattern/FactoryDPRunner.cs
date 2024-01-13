
namespace FactoryDesignPattern
{
    public class FactoryDPRunner
    {
        //for more better practice, I implemented Abstract factory class
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


            //now I created Abstract class to create a connection between IShape class and IColor class.

            AbstractFactory shapeFactory = FactoryProducer.GetFactory("Shape");
            AbstractFactory colorFactory = FactoryProducer.GetFactory("Color");

            //using circle Factory
            IShape circle = shapeFactory.GetShape("Circle");
            circle.Draw();

            //using rectangle Factory
            IShape rectangle = shapeFactory.GetShape("rectangle");
            rectangle.Draw();

            //using rectangle Factory
            IShape square = shapeFactory.GetShape("sqUarE");
            square.Draw();

            //using Color factory
            IColor blue = colorFactory.GetColor("Blue");
            blue.Paint();

            //using Color factory
            IColor pink = colorFactory.GetColor("pinK");
            pink.Paint();

            //using Color factory
            IColor yellow = colorFactory.GetColor("YELLOW");
            yellow.Paint();

            //IShapeFactory circleFactory = new CircleFactory();
            //IShape circle = circleFactory.GetShape("CIRCLE");
            //circle.Draw();

            //// Using Rectangle factory
            //IShapeFactory rectangleFactory = new RectangleFactory();
            //IShape rectangle = rectangleFactory.GetShape("ReCTaNglE");
            //rectangle.Draw();

            ////Using Square Factory
            //IShapeFactory squareFactory = new SquareFactory();
            //IShape square = squareFactory.GetShape("sQUSAFR");//expecting null and throwing exception
        }
    }
}