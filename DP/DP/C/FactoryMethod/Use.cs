using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.FactoryMethod
{
    public static class Use
    {
        public static void Applay()
        {
            Creator[] creators = new Creator[2];
            creators[0] = new ConcretCreatorA();
            creators[1] = new ConcretCreatorB();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine($"Created {product.GetType().Name} ");
            }
        }
    }
}
