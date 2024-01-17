namespace ProxyDesignPattern
{
    internal class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _fileName;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public void ShowImage()
        {
            //if contraint for creating a unique object
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }
         
            _realImage.ShowImage();
        }
    }
}
