namespace DecoratorDesignPattern
{
    public class ApplePhone14 : PhoneDecorator
    {
        public ApplePhone14(ApplePhone iphone) : base(iphone)
        {
        }

        public override string GetName()
        {
            return _iphone.GetName() + " " + "14";
        }
        
        public override int CameraCount()
        {
            return _iphone.CameraCount() + 1;//iphone 14 has 2 cameras
        }

        public override double GetPrice()
        {
            return _iphone.GetPrice();
        }
    }
}
