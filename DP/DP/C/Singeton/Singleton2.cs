using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.Singeton
{
    class Singleton2
    {
        private static Singleton2 _instance;
        private static object syncRoot = new Object();
        private Singleton2() { }

        public static Singleton2 GetInstance()
        {
            if (_instance == null)
            {
                lock (syncRoot)
                {
                    if (_instance == null)
                    {
                       _instance = new Singleton2();
                    }
                }
            }
            return _instance;
        }
    }
}
