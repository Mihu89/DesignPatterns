using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.Prototype.Example
{
    public abstract class Prototype : ICloneable
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public PrototypeDetails PrototypeDetails { get; set; }

        public abstract object Clone();
        public override string ToString() => $"Property1: {Property1} Property2: {Property2} PrototypeDetails: {PrototypeDetails}";
        //public override string ToString()
        //{
        //    return "Property1: " + this.Property1 + " Property2: " + this.Property2 + " " 
        //}
    }

    public class PrototypeDetails
    {
        public string Details { get; set; }
        public override string ToString() => this.Details;
    }
}
