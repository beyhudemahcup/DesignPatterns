namespace DecoratorDesignPattern
{
    public abstract class PhoneDecorator : IPhone
    {
        protected IPhone _iphone;

        public PhoneDecorator(ApplePhone iphone)
        {
            _iphone = iphone;
        }

        public abstract int CameraCount();
        
        public abstract string GetName();
        
        public abstract double GetPrice();
    }
}
