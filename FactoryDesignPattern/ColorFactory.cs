namespace FactoryDesignPattern
{
    internal class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string colorName)
        {
            if (colorName.Equals("Blue", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Blue();
            }

            else if (colorName.Equals("Yellow", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Yellow();
            }

            else if (colorName.Equals("Pink", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Pink();
            }

            return null;
        }

        public override IShape GetShape(string ShapeName)
        {
            return null;
        }
    }
}
