using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DP.C.Builder
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int n);
        void SetEngine();  // add IEngine (type of engine)
        void SetTripComputer(bool isUsed);
        void SetGPS(bool isUsed);
    }
}
