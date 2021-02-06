using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Decorator
{
    class ConcretDecoratorA : Decorator
    {
        public ConcretDecoratorA(IComponent comp): base(comp)
        {
        }

        public override void Operation()
        {
            base.Operation();
            AddNewBehavior();
            Console.WriteLine("OPeration was done for ConcretDecoratorA");
        }

        private void AddNewBehavior()
        {
            Console.WriteLine("freshBehavior added A+");
        }
    }
}
