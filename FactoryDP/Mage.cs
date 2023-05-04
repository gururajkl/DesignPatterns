namespace FactoryDP
{
    // Concrete class implementing the ICharacter interface
    public class Mage : ICharacter
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }

        public Mage()
        {
            Health = 200;
            Damage = 50;
            Speed = 15;
        }

        public void PerformAction()
        {
            Console.WriteLine("Mage performs the powerfull attack");
        }
    }
}
