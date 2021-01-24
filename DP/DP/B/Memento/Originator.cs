using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Memento
{
    class Originator<T> where T : ICloneable
    {
        public T StateObj { get; set; }
        public Memento<T> CreateMemento()
        {
            Memento<T> mem = new Memento<T>();
            mem.SetState(this.StateObj);
            return mem;
        }

        public void RestoreMemento(Memento<T> m)
        {
            this.StateObj = m.GetState();
        }
            
        public void SetState(T state)
        {
            this.StateObj = state;
        }
            
        public void ShowState()
        {
            Console.WriteLine(this.StateObj.ToString());
        }

    }
}
