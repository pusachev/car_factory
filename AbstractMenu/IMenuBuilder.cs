using System;
namespace AbstractMenu
{
    public interface IMenuBuilder
    {
        public IMenuBuilder Add(IMenuItem menuItem);

        public void Show();
    }
}
