using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.Builder
{
    public class CarManualBuilder : IBuilder
    {
        private Manual manual;
        public void Reset()
        {
            Console.WriteLine("Reset Manual");
        }

        public void SetEngine()
        {
            Console.WriteLine("Add Engine Manual");
        }

        public void SetGPS(bool isUsed)
        {
            Console.WriteLine("Add GPS manual " + isUsed);
        }

        public void SetSeats(int n)
        {
            Console.WriteLine("Add Seats manual " + n);
        }

        public void SetTripComputer(bool isUsed)
        {
            Console.WriteLine("Add Trip PC manual " + isUsed);
        }

        public Manual GetResult()
        {
            Manual manual = new Manual();

            return manual;
        }
    }
}
