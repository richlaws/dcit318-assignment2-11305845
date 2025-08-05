using System;

namespace Interfaces
{
    // Interface declaration
    public interface IMovable
    {
        void Move();
    }

    // Car class
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle class
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class MovementTest
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();       // Outputs: Car is moving
            bicycle.Move();   // Outputs: Bicycle is moving
        }
    }
}
