
namespace ProxyDesignPattern
{
    internal class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine("Loading image : " + _fileName);
        }

        public void ShowImage()
        {
            Console.WriteLine("Image is showing : " + _fileName);
        }
    }
}
