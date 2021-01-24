﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Memento
{
    class StateObject : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return new StateObject
            {
                Id = this.Id,
                Name = this.Name
            };
        }
        public override string ToString()
        {
            return $"Id: {this.Id} Name: {this.Name}";
        }
    }
}
