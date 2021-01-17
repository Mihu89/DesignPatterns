using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Strategy
{
    public class ConcretStrategy1 : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Algo from S1");
        }
    }        
    public class ConcretStrategy2 : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Algo from S2");
        }
    }
}
