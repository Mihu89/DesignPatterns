using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.Builder
{
    public class CarBuilder : IBuilder
    {
        private Car car;  
        public void Reset()
        {
            Console.WriteLine("Reset of car is done");
        }

        public void SetEngine()
        {
            Console.WriteLine("Engine was added");
        }

        public void SetGPS(bool isUsed)
        {
            Console.WriteLine("GPS was added " + isUsed);
        }

        public void SetSeats(int n)
        {
            Console.WriteLine("Seats was added " + n);
        }

        public void SetTripComputer(bool isUsed)
        {
            Console.WriteLine("Trip computer was added " + isUsed);
        }

        public Car GetResult()
        {
            Car car = new Car();
            return car;
        }
    }
}
