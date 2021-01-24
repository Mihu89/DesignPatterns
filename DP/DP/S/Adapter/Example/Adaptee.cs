using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Adapter.Example
{
    public class Adaptee : ISomeOtherInterface
    {
        public void MethodFromAdaptee()
        {
            Console.WriteLine("Request from Adaptee");
        }
    }
}
