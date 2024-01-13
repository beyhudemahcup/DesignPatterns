namespace FactoryDesignPattern
{
    internal class SquareFactory : IShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType.Equals("Square", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Square();
            }
            else
            {
                return null;
            }
        }
    }
}
