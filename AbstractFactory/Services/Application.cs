using AbstractFactory.Services.Factory;
using AbstractFactory.Services.Factory.Interfaces;
using System;

namespace AbstractFactory.Services
{
    class Application
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new WinFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new MacFactory());
        }

        public void ClientMethod(IGUIFactory factory)
        {
            var button = factory.CreateButton();
            var checkBox = factory.CreateCheckBox();

            Console.WriteLine(button.CreateButton());
            Console.WriteLine(checkBox.CreateCheckBox());
        }
    }
}
