using System;
using System.Collections.Generic;

namespace CarFactoryLiblary
{
    public class CarFactory : ICarBuilder
    {
        List<Car> CarCollection = new List<Car>();

        public ICarBuilder Add(IItem item)
        {
            bool isApplied = false;

            foreach (Car car in CarCollection)
            {
                isApplied = AddItemToCar(item, car);
            }


            if (isApplied == false)
            {
                Car car = new Car();
                AddItemToCar(item, car);

                CarCollection.Add(car);
            }

            return this;
        }

        public Car Build()
        {
            foreach (Car car in CarCollection)
            {
                if (car.isFinished()) {
                    return car;
                }
            }

            throw new Exception("No finished car");
        }

        public void Status()
        {

        }

        bool AddItemToCar(IItem item, Car car)
        {
            if (item is Wheel && car.GetWheel() != 4)
            {
                car.AddWheel();
                return true;
            }

            if (item is SteeringWheel && car.GetWheel() != 1)
            {
                car.AddWheel();
                return true;
            }

            if (item is Motor && car.GetMotor() != 2)
            {
                car.AddMotor();
                return true;
            }

            if (item is Seat && car.GetSeat() != 2)
            {
                car.AddSeat();
                return true;
            }

            return false;
        }
    }
}
