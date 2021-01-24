using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Adapter.Example
{
    class SomeTarget : ITarget
    {
        public void Request()
        {
            Console.WriteLine("Requet from SomeTarget");
        }
    }
}
