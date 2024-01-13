namespace FactoryDesignPattern
{
    internal class CircleFactory : IShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            //we can also change the name of the input in order to use for another languages etc. 
            if (shapeType.Equals("Circle", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Circle();
            }
            else 
            { 
                return null; 
            }
           }
    }
}
