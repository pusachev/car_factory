using System;
using AbstractMenu;
using CarFactoryLiblary;

namespace CarMenu
{
    public class AddItemMenuItem : IMenuItem
    {
        ItemsGenerator ItemsGenerator;
        CarFactory CarFactory;

        public AddItemMenuItem(ItemsGenerator itemsGenerator, CarFactory carFactory)
        {
            ItemsGenerator = itemsGenerator;
            CarFactory = carFactory;
        }

        public int GetCode()
        {
            return 1;
        }

        public string GetLabel()
        {
            return "Add Item to car factory:";
        }

        public void Execute()
        {
            Console.WriteLine("Add Item to factory");
            IItem item = ItemsGenerator.Generate();
            CarFactory.Add(item);
            Console.WriteLine("Item {0} added to car factory");
        }
    }
}
