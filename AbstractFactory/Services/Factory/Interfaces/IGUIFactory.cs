using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Factory.Interfaces
{
    public interface IGUIFactory
    {
        IButton CreateButton();

        ICheckBox CreateCheckBox();
    }
}
