using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.Builder
{
    public class Director
    {
        public void ConstructSportCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine(); // Add SportEngine, DiselEngine, ElectricalEngine
            builder.SetTripComputer(true);
            builder.SetGPS(true);
        }
    }
}
