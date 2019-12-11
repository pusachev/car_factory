using System;
namespace CarFactoryLiblary
{
    public class AbstractItem : IItem
    {
        protected string Name;

        public AbstractItem(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
