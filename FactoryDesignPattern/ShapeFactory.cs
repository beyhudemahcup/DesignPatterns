namespace FactoryDesignPattern
{
    internal class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeName)
        {
            if (shapeName.Equals("Square", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Square();
            }

            else if (shapeName.Equals("Rectangle", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Rectangle();
            }

            else if (shapeName.Equals("Circle", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Circle();
            }

            return null;
        }
        public override IColor GetColor(string Color)
        {
            return null;
        }
    }
}
