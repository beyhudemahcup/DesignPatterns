namespace SingletonDesignPattern
{
    internal class SingletonObject
    {
        private static SingletonObject instance;

        //private constructor to prevent another instance
        private SingletonObject()
        {

        }

        public static SingletonObject Instance
        {
            get
            {
                //checking the thread's safety
                if (instance == null)
                {
                    instance = new SingletonObject();
                }
                else
                {
                    return instance;
                }

                return instance;
            }
        }
        
        public void SingletonCalling()
        {
            Console.WriteLine("Singleton Instance is called!!");
        }
    }
}

