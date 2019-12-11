using System;
namespace ConsoleMenu
{
    public interface IMenuBuilder
    {
        public IMenuBuilder Add(IMenuItem menuItem);

        public void Show();
    }
}
