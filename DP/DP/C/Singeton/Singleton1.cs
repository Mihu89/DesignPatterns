using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.Singeton
{
    class Singleton1
    {
        private static Singleton1 _instance;
        private Singleton1() { }

        public static Singleton1 GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton1();
            }
            return _instance;
        }
    }
}
