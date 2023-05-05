namespace BuilderDP
{
    // Director
    public class CarDirector
    {
        private readonly ICarBuilder builder;

        public CarDirector(ICarBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.SetModel("TVS");
            builder.SetColor("Blue");
            builder.SetPrice(2000);
            builder.SetYear(2023);
        }
    }
}
