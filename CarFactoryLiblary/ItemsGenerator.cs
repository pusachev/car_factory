using System;
namespace CarFactoryLiblary
{
    public class ItemsGenerator
    {
        IItem[] ItemCollection;

        Random Rand;

        public ItemsGenerator()
        {
            ItemCollection = new IItem[4] {
                new Wheel("wheel"),
                new SteeringWheel("stree wheel"),
                new Motor("motor"),
                new Seat("seats")
            };

            Rand = new Random();
        }

        public IItem Generate()
        {
            return ItemCollection[Rand.Next(0, ItemCollection.Length)];
        }
    }
}
