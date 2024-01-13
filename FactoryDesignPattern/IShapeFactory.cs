namespace FactoryDesignPattern
{
    internal interface IShapeFactory
    {
        public IShape GetShape(string shapeType);
    }
}
