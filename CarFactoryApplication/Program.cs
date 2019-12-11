using System;
using AbstractMenu;
using CarFactoryLiblary;
using CarMenu;

namespace CarFactoryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuBuilder menuBuilder = new MenuBuilder();
            CarFactory carFactory = new CarFactory();
            ItemsGenerator itemsGenerator = new ItemsGenerator();

            menuBuilder.Add(new AddItemMenuItem(itemsGenerator, carFactory));

            menuBuilder.Execute();
        }
    }
}
