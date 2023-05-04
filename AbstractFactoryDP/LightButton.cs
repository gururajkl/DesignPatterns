namespace AbstractFactoryDP
{
    public class LightButton : IButton
    {
        // Concrete class for rendering a light theme button
        public void Render()
        {
            Console.WriteLine("Rendered light button");
        }
    }
}
