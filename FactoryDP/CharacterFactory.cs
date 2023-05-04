namespace FactoryDP
{
    // Defines the factory class that creates the object of the ICharacter interface
    // Here this factory class return the new instance of the type of class we wants which implements the ICharacter interface
    public class CharacterFactory
    {
        public ICharacter CreateCharacter(string whichType)
        {
            switch (whichType)
            {
                case "Warrior":
                    return new Warrior();
                case "Mage":
                    return new Mage();
                default: throw new ArgumentException("Invalid character type");
            }
        }
    }
}
