using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Iterator
{
    class Iterator : IIterator
    {
        int _current = 0;
        IAggregate _aggregate;

        public Iterator()
        {
            
        }

        public object CurrentItem()
        {
            return _aggregate[_current];
        }

        public object First()
        {
            return _aggregate[0];
        }

        public bool IsDone()
        {
            return _current >= _aggregate.Count();
        }

        public object Next()
        {
            return _current < (_aggregate.Count() - 1) ? _aggregate[++_current] : null;
        }

        public void SetAggregate(IAggregate aggregate)
        {
            _aggregate = aggregate;
        }
    }
}
