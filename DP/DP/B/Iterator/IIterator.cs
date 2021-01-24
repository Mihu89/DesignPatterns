using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Iterator
{
    interface IIterator
    {
        object First();
        object Next();
        bool IsDone();
        object CurrentItem();
        void SetAggregate(IAggregate aggregate);
    }
}
