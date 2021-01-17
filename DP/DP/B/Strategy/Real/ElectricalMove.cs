using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Strategy.Real
{
    class ElectricalMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Use Electrical energy to move");
        }
    }
}
