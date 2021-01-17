using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Strategy.Real
{
    public static class Use
    {
        public static void Applay()
        {
            Car car = new Car("Tesla Model 3 Sedan", 5, new ElectricalMove());
            car.Move();

            car.Movable = new PetrolMove();
            car.Move();
        }
    }
}
