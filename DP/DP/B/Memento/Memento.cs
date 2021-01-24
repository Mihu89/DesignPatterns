using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Memento
{
    class Memento<T> where T : ICloneable
    {
        public T StateObj { get; set; }

        public T GetState()
        {
            return StateObj;
        }

        public void SetState(T stateObject)
        {
            StateObj = stateObject;
        }
    }
}
