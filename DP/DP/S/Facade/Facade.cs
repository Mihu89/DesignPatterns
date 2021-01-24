using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Facade
{
    class Facade
    {
        ClassOne _one;
        ClassTwo _two;
        ClassThree _three;

        public Facade()
        {
            _one = new ClassOne();
            _two = new ClassTwo();
            _three = new ClassThree();
        }

        public void CallOperaionsUnified()
        {
            _one.OperationOne();
            _two.OperationTwo();
            _three.OperationThree();
        }
    }
}
