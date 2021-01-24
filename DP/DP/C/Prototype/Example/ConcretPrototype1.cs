using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.Prototype.Example
{
    public class ConcretPrototype1 : Prototype
    {
        public override object Clone()
        {
            // Shalow Copy
            //return this.MemberwiseClone();

            // Deep Copy
            return new ConcretPrototype1
            {
                Property1 = this.Property1,
                Property2 = this.Property2,
                PrototypeDetails = this.PrototypeDetails
            };
        }
    }
}
