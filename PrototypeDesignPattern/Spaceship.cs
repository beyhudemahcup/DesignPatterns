namespace PrototypeDesignPattern
{
    internal class Spaceship : IGameObject
    {
        public string Model { get; set; }
        public int Capacity { get; set; }

        public Spaceship(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
        }

        // Copy constructor for cloning
        private Spaceship(Spaceship other)
        {
            Model = other.Model;
            Capacity = other.Capacity;
        }

        // Clone method
        public IGameObject Clone()
        {
            return new Spaceship(this);
        }

        public void Interact()
        {
            Console.WriteLine($"Interacting with a {Model} spacecraft, the capacity of the spaceship: {Capacity} astronauts");
        }
    }
}
