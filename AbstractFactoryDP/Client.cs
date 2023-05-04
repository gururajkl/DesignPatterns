namespace AbstractFactoryDP
{
    // Client code that uses the abstract factory to create UI elements
    public class Client
    {
        private readonly IUIFactory uIFactory;
        public Client(IUIFactory uIFactory)
        {
            this.uIFactory = uIFactory;
        }

        public void RenderUI()
        {
            IButton button = uIFactory.CreateButton();
            button.Render();
        }
    }
}
