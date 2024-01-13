namespace FactoryDesignPattern
{
    internal abstract class AbstractFactory
    {
        public abstract IColor GetColor(string Color);

        public abstract IShape GetShape(string ShapeName);
    }
}
