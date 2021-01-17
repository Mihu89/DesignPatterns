using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.FactoryMethod
{
    class ConcretCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcretProductA();
        }
    }

    class ConcretCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcretProductB();
        }
    }
}
