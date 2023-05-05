using BuilderDP;

ICarBuilder builder = new CarBuilder();
CarDirector carDirector = new(builder);
carDirector.Construct();
Car car = builder.Build();

Console.WriteLine($"Model: {car.Model}");
Console.WriteLine($"Color: {car.Color}");
Console.WriteLine($"Year: {car.Year}");
Console.WriteLine($"Price: {car.Price}");