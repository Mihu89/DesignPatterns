using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Decorator
{
    class ConcretDecoratorB : Decorator
    {
        public ConcretDecoratorB(IComponent comp) : base(comp)
        {
        }

        public override void Operation()
        {
            base.Operation();
            AddNewBehavior();
            Console.WriteLine("OPeration was done for ConcretDecoratorB");
        }

        private void AddNewBehavior()
        {
            Console.WriteLine("freshBehavior added B+");
        }
    }
}
