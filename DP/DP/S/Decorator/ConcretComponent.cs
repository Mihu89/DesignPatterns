using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Decorator
{
    public class ConcretComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Operation from ConcretComponent");
        }
    }
}
