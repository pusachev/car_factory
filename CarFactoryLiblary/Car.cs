using System;
namespace CarFactoryLiblary
{
    public class Car
    {
        int Wheel { get; set; }
        int SteeringWheel { get; set; }
        int Motor { get; set; }
        int Seat { get; set; }

        public Car()
        {
            Wheel = 0;
            SteeringWheel = 0;
            Motor = 0;
            Seat = 0;
        }

        public bool isFinished()
        {
            return Wheel == 4 && SteeringWheel == 1 && Motor == 2 && Seat == 2;
        }

        public int GetWheel()
        {
            return Wheel;
        }

        public int GetSteeringWheel()
        {
            return SteeringWheel;
        }

        public int GetMotor()
        {
            return Motor;
        }

        public int GetSeat()
        {
            return Seat;
        }

        public void AddWheel()
        {
            Wheel++;
        }

        public void AddSteeringWheel()
        {
            SteeringWheel++;
        }

        public void AddMotor()
        {
            Motor++;
        }

        public void AddSeat()
        {
            Seat++;
        }
    }
}
