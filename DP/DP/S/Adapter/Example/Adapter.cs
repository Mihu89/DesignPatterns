using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Adapter.Example
{
    public class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            MethodFromAdaptee();
        }
    }
}
