using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DP.C.Singeton
{
    public static class Use
    {  
        public static void Applay() {
            Singleton1 s;
            s = Singleton1.GetInstance();
            Console.WriteLine(s.ToString());
            Console.WriteLine(s.GetHashCode());
            var b = Singleton1.GetInstance();
            if (s == b) ///s.Equals(b))
            {
                Console.WriteLine("Objects are equals");
            }
            else
            {
                Console.WriteLine("Objects are not equals");
            }
            Console.WriteLine(b.GetHashCode());
            /*
            Console.WriteLine("Multithreding problems:");

            (new Thread(() =>
            {
                var d = Singleton1.GetInstance();
                Console.WriteLine($"d {d.GetHashCode()}");
                var e = Singleton1.GetInstance();
                Console.WriteLine($"e {d.GetHashCode()}");
            })).Start();

            var c = Singleton1.GetInstance();
            Console.WriteLine($"c {c.GetHashCode()}");

            var c1 = Singleton1.GetInstance();
            Console.WriteLine($"c1 {c1.GetHashCode()}");
              */

            Console.WriteLine("Singleton 2");
            (new Thread(() =>
            {
                var d = Singleton2.GetInstance();
                Console.WriteLine($"d {d.GetHashCode()}");
                var e = Singleton1.GetInstance();
                Console.WriteLine($"e {d.GetHashCode()}");
            })).Start();
            {
                var c = Singleton2.GetInstance();
                Console.WriteLine($"c {c.GetHashCode()}");

                var c1 = Singleton1.GetInstance();
                Console.WriteLine($"c1 {c1.GetHashCode()}");
            }
        }
    }
}
