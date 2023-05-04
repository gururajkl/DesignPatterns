namespace FactoryDP
{
    // One more Concrete class implementing the ICharacter interface
    public class Warrior : ICharacter
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }

        public Warrior()
        {
            Health = 100;
            Damage = 10;
            Speed = 5;
        }

        public void PerformAction()
        {
            Console.WriteLine("Warrior performs a melee attack!");
        }
    }
}
