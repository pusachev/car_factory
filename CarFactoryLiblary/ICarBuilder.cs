using System;
namespace CarFactoryLiblary
{
    public interface ICarBuilder
    {
        public ICarBuilder Add(IItem item);

        public Car Build();

        public void Status();
    }
}
