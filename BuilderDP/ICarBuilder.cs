namespace BuilderDP
{
    public interface ICarBuilder
    {
        // Builder interface
        void SetModel(string model);
        void SetColor(string color);
        void SetYear(int year);
        void SetPrice(int price);
        Car Build();
    }
}
