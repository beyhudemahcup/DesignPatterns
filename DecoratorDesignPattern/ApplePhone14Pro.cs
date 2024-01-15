namespace DecoratorDesignPattern
{
    public class ApplePhone14Pro : PhoneDecorator
    {
        public ApplePhone14Pro(ApplePhone iphone) : base(iphone)
        {
        }

        //override the base class (IPhone)
        public override string GetName()
        {
            return _iphone.GetName() + " " + "14 Pro";
        }

        public override int CameraCount()
        {
            return _iphone.CameraCount() + 2;//it has 3 cameras
        }

        public override double GetPrice()
        {
            return _iphone.GetPrice() + 500;//price is updated
        }

        public string AdditionalFunctions()
        {
            return "Additional Functions are shown";
        }
    }
}
