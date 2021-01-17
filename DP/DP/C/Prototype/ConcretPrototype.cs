using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.Prototype
{
    class ConcretPrototype1 : Prototype
    {
        public ConcretPrototype1(int id): base(id)
        {
        }
        public override Prototype Clone()
        {
            return new ConcretPrototype1(Id);
        }
    } 
    
    class ConcretPrototype2 : Prototype
    {
        public ConcretPrototype2(int id): base(id)
        {
        }
        public override Prototype Clone()
        {
            return new ConcretPrototype2(Id);
        }
    }
}
