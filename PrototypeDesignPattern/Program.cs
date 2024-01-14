using PrototypeDesignPattern;

class Program
{
    static void Main()
    {
        // Create prototypes
        var spacecraftPrototype = new Spaceship(model: "Explorer", capacity: 5);
        var astronautPrototype = new Astronaut(astronautName: "R2D2", astronautId: 1);

        // Create game objects by cloning prototypes
        var clonedSpacecraft = spacecraftPrototype.Clone();
        var clonedAstronaut = astronautPrototype.Clone();

        // Interact with the game objects
        clonedSpacecraft.Interact();
        clonedAstronaut.Interact();

        //in this way we can easily copy the game object for make any changes without creating for another game object
    }
}
