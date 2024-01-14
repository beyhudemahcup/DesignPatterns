namespace PrototypeDesignPattern
{
    internal class Astronaut : IGameObject
    {
        public string AstronautName { get; set; }
        public int AstronautId { get; set; }

        public Astronaut(string astronautName, int astronautId)
        {
            AstronautName = astronautName;
            AstronautId = astronautId;
        }

        // Copy constructor for cloning
        private Astronaut(Astronaut other)
        {
            AstronautName = other.AstronautName;
            AstronautId = other.AstronautId;
        }

        // Clone method
        public IGameObject Clone()
        {
            return new Astronaut(this);
        }

        public void Interact()
        {
            Console.WriteLine($"Interacting with Astronaut {AstronautName}, Id: {AstronautId}");
        }
    }
}
