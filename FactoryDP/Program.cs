using FactoryDP;

// Creating an instance of the factory class to use the required class, instead of creating the new instance of the class directly
CharacterFactory characterFactory = new CharacterFactory();

// Getting the warrior type without knowing the instance of the Warrior type
ICharacter warriorType = characterFactory.CreateCharacter("Warrior");
Console.WriteLine($"Warrior has {warriorType.Health} health and can cost {warriorType.Damage}% damage");
warriorType.PerformAction();

// Getting the mage type without knowing the instance of the Mage type
ICharacter mageType = characterFactory.CreateCharacter("Mage");
Console.WriteLine($"Mage has {mageType.Health} health and can cost {mageType.Damage}% damage");
mageType.PerformAction();