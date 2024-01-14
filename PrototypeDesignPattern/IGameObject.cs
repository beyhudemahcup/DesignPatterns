namespace PrototypeDesignPattern
{
    internal interface IGameObject
    {
        // Prototype interface

        IGameObject Clone();
        void Interact();
    }
}
