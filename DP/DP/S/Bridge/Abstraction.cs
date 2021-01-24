using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Bridge
{
    public class Abstraction
    {
        public IImplementor Implementor { get; set; }
        public virtual void Operation() => Implementor.Method();
    }
}
