using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services
{
    public class MacButton : IButton
    {
        public string CreateButton()
        {
            return "Mac Button";
        }
    }
}