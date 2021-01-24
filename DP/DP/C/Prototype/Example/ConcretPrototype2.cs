using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.Prototype.Example
{
    public class ConcretPrototype2 : Prototype
    {
        public string OtherProperty { get; set; }
        public override object Clone()
        {
            return new ConcretPrototype2 {
                OtherProperty = this.OtherProperty,
                Property1 = this.Property1,
                Property2 = this.Property2,
                PrototypeDetails = this.PrototypeDetails
            };
        }
        public override string ToString() => $"{base.ToString()} Otherproperty: {this.OtherProperty}";
    }
}
