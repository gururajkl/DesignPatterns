namespace AbstractFactoryDP
{
    public class LightThemeFactory : IUIFactory
    {
        // Concrete factory class for creating UI elements with a light theme
        public IButton CreateButton()
        {
            return new LightButton();
        }
    }
}
