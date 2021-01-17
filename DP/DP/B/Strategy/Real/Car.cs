using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Strategy.Real
{
    class Car
    {
        public string Model { get; set; }
        public int PassagerNumber { get; set; }
        public IMovable Movable { get; set; }

        public Car(string model,int number, IMovable mov)
        {
            Model = model;
            PassagerNumber = number;
            Movable = mov;
        }

        public void Move()
        {
            Movable.Move();
        }
    }
}
