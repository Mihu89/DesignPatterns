using System;
using System.Collections.Generic;
using System.Text;

namespace DP.C.Singeton
{     // Lazy Loading, Eager loading
    public sealed class Singleton3
    {
        private static readonly Singleton3 _instance = new Singleton3();

        public static Singleton3 GetInstance
        {
            get
            {
                return _instance;
            }
        }
    }
}
