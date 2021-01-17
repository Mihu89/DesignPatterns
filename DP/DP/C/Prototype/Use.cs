using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.Prototype
{
    public static class Use
    {
        public static void Apply()
        {
            Prototype prototype = new ConcretPrototype1(1);
            Console.WriteLine($"proto {prototype.GetHashCode()}");
            Prototype clone = prototype.Clone();
            Console.WriteLine($"proto {prototype.GetHashCode()}");
            prototype = new ConcretPrototype2(2);
            Console.WriteLine($"proto2 {prototype.GetHashCode()}");
            clone = prototype.Clone();
            Console.WriteLine($"clone2 {prototype.GetHashCode()}");
        }
    }
}
