namespace AbstractFactoryDP
{
    public class DarkButton : IButton
    {
        // Concrete class for rendering a light theme button
        public void Render()
        {
            Console.WriteLine("Rendered Dark button");
        }
    }
}
