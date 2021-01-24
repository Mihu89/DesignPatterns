using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.ChainofResponsability
{
    public abstract class Handler
    {
        protected string Name;
        public Func<int, bool> Condition;
        public Handler Successor { get; set; }

        public Handler(string name)
        {
            Name = name;
        }
        public abstract void HandleRequest(int value);
    }
}
