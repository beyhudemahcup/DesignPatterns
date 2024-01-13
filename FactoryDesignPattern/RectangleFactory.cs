namespace FactoryDesignPattern
{
    internal class RectangleFactory : IShapeFactory
    {
        public IShape GetShape(string shapeType)
        { 
            if (shapeType.Equals("Rectangle", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Rectangle();
            }
            else
            {
                try
                {
                    return null;
                }
                catch (Exception)
                {
                    Console.WriteLine("Your value is not correct!!");
                    throw;
                }
            }
        }
    }
}
