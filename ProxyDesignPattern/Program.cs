namespace ProxyDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Using this pattern we can achieve controlled access for an object
            IImage image = new ProxyImage("_fileName.jpeg");
        
            //image can be shown only its needed
            image.ShowImage();
        }
    }
}