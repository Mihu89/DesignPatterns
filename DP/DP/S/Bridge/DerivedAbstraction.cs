using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Bridge
{
    public class DerivedAbstraction : Abstraction
    {
        public override void Operation()
        {
            Implementor.Method();
        }
    }
}
