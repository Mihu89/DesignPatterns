using DP.C.Singeton;
using System;
using System.Threading.Tasks;

namespace DP
{        // C - Creational B- Behavioral, S-Structural
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns");
            CreationalPatterns();

            Console.Read();
        }

        private static void CreationalPatterns()
        {
            Use.Applay();
            /*
           Computer comp = new Computer();
           comp.Launch("Windows 8.1");
           Console.WriteLine(comp.OS.Name);

           // у нас не получится изменить ОС, так как объект уже создан    
           comp.OS = OS.getInstance("Windows 10");
           Console.WriteLine(comp.OS.Name);    */
            Parallel.Invoke(
                () => S3_0() ,
                () => S3_1()
                ) ;

            DP.C.FactoryMethod.Use.Applay();
            DP.C.Prototype.Use.Apply();
            DP.B.Strategy.Real.Use.Applay();
            DP.B.Mediator.Real.Use.Apply();

            Console.ReadLine();
        } 
        private static void S3_0()
        {
            Singleton3 singleton = Singleton3.GetInstance;
            Console.WriteLine($"S3_0 {singleton.GetHashCode()}");

        }
        private static void S3_1()
        {
            Singleton3 singleton = Singleton3.GetInstance;
            Console.WriteLine($"S3_1 {singleton.GetHashCode()}");
        }
    }
    class Computer
    {
        public OS OS { get; set; }
        public void Launch(string osName)
        {
            OS = OS.getInstance(osName);
        }
    }
    class OS
    {
        private static OS instance;

        public string Name { get; private set; }

        protected OS(string name)
        {
            this.Name = name;
        }

        public static OS getInstance(string name)
        {
            if (instance == null)
                instance = new OS(name);
            return instance;
        }
    }
}
    

