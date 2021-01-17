using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Strategy.Real
{
    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Use petrol to move");
        }
    }
}
