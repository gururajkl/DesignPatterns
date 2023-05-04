namespace FactoryDP
{
    // Defining the interface for all the characters, which will be used by the concrete classes
    public interface ICharacter
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }

        public void PerformAction();
    }
}
