using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Strategy
{
    public class Context
    {
        IStrategy ConcretStrategy { get; set; }

        public Context(IStrategy strategy)
        {
            ConcretStrategy = strategy;
        }

        public void ExecuteAlgorithm()
        {
            Console.WriteLine("We execute algorithm");
            ConcretStrategy.Algorithm();
        }
    }
}
