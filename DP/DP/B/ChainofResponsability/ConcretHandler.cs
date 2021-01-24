using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.ChainofResponsability
{
    class ConcretHandler : Handler
    {
        public ConcretHandler(string name): base(name)
        {
        }

        public override void HandleRequest(int value)
        {
            if (Condition(value)) 
            {
                Console.WriteLine($"This {this.Name} handled the value {value}");
            }
            else
            {
                this.Successor.HandleRequest(value);
            }
        }
    }
}
