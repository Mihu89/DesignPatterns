using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Bridge
{
    public class ConcretImplementorA : IImplementor
    {
        public void Method()
        {
            Console.WriteLine("Method called from ConcretImplementorA");
        }
    }

    public class ConcretImplementorB : IImplementor
    {
        public void Method()
        {
            Console.WriteLine("Method called from ConcretImplementorB");
        }
    }
}
