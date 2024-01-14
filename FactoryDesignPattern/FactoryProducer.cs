namespace FactoryDesignPattern
{
    internal class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.Equals("Shape", StringComparison.CurrentCultureIgnoreCase))
            {
                return new ShapeFactory();
            }
            else if(choice.Equals("Color", StringComparison.CurrentCultureIgnoreCase))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
