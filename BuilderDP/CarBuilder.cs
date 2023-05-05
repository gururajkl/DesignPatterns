namespace BuilderDP
{
    // Concrete builder
    public class CarBuilder : ICarBuilder
    {
        private readonly Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public void SetColor(string color)
        {
            car.Color = color;
        }

        public void SetModel(string model)
        {
            car.Model = model;
        }

        public void SetPrice(int price)
        {
            car.Price = price;
        }

        public void SetYear(int year)
        {
            car.Year = year;
        }

        public Car Build()
        {
            return car;
        }
    }
}
