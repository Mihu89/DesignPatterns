using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Iterator
{
    class Aggregate<T> : IAggregate where T : IIterator, new()
    {
        ArrayList _items = new ArrayList();

        public object this[int index] { 
            get => _items[index];
            set => _items.Insert(index, value); }

        public int Count()
        {
            return _items.Count; ;
        }

        public IIterator CreateIterator()
        {
            IIterator a = new T();
            a.SetAggregate(this);
            return a;
        }
    }
}
