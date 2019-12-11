using System;
namespace CarFactoryLiblary
{
    public interface ICarBuilder
    {
        public ICarBuilder Add(IItem);

        public Car Build();

        public void Status();
    }
}
