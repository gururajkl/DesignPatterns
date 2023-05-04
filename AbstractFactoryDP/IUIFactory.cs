namespace AbstractFactoryDP
{
    // Main interface for creating a light / dark theme UI elements
    public interface IUIFactory
    {
        IButton CreateButton();
    }
}
