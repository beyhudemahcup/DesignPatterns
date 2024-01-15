namespace DecoratorDesignPattern
{
    public class ApplePhone : IPhone
    {
        //defining base class
        public int CameraCount()
        {
            //IPhones has one camera at least 
            return 1;
        }

        public string GetName()
        {
            //name starts with IPhone all the time
            return "IPhone";
        }

        public double GetPrice()
        {
            //price is at least 500 eur 
            return 499.9;
        }
    }
}
