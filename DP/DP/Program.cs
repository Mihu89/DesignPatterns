using DP.B.ChainofResponsability;
using DP.B.Iterator;
using DP.B.Memento;
using DP.C.Builder;
using DP.C.Prototype.Example;
using DP.C.Singeton;
using DP.S.Adapter.Example;
using DP.S.Bridge;
using DP.S.Decorator;
using DP.S.Facade;
using System;
using System.Threading.Tasks;

namespace DP
{        // C - Creational B- Behavioral, S-Structural
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns");
            // BehavioralPaterns();
            //CreationalPatterns();
            StructuralPaterns();

            Console.Read();
        }

        private static void BehavioralPaterns()
        {
            #region Chain of Responsability
            Console.WriteLine("Chain of reasponsability");

            Handler h1 = new ConcretHandler("Handler 1");
            h1.Condition = (value) => value > -1 && value < 5;
            
            Handler h2 = new ConcretHandler("Handler 2");
            h2.Condition = (value) => value >= 5 && value < 10;
            
            Handler h3 = new ConcretHandler("Handler 3");
            h3.Condition = (value) => value > 10 && value < 20;

            h1.Successor = h2;
            h2.Successor = h3;

            foreach (var i in new int[] {3, 4,6, 11, 12, 18 })
            {
                h1.HandleRequest(i);
            }
            #endregion

            #region Iterator
            Console.WriteLine("Iterator");

            Aggregate<Iterator> ag = new Aggregate<Iterator>();

            ag[0] = "A";
            ag[1] = "B";
            ag[2] = "C";

            // Creating the iterator based on Aggregate instance
            Iterator it = ag.CreateIterator()  as Iterator;

            object item = it.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = it.Next();
            }

            #endregion

            #region Mememnto
            Console.WriteLine("Mememnto");

            Originator<StateObject> current = new Originator<StateObject>();
            current.SetState(new StateObject { Id = 1, Name = "Object one" });
            CareTaker<StateObject>.SaveState(current);

            current.SetState(new StateObject { Id = 2, Name = "Object two" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState(); 

            current.SetState(new StateObject { Id = 3, Name = "Object three" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            // restore to specific state
            CareTaker<StateObject>.RestoreState(current, 0);
            current.ShowState();

            #endregion
        }

        private static void StructuralPaterns()
        {
            #region Example of Adapter patern
            Console.WriteLine("Adaptor Pattern");
            ITarget t = new SomeTarget();
            t.Request();

            ITarget t2 = new Adapter();
            t2.Request();

            #endregion

            #region Bridge

            Console.WriteLine("Bridge");
            Abstraction abstraction = new DerivedAbstraction();
            abstraction.Implementor = new ConcretImplementorA();
            abstraction.Operation();

            abstraction.Implementor = new ConcretImplementorB();
            abstraction.Operation();
            #endregion

            #region Facade
            Console.WriteLine("Facade");
            Facade facade = new Facade();
            facade.CallOperaionsUnified();

            #endregion

            #region Decorator
            ConcretComponent component = new ConcretComponent();
            ConcretDecoratorA decoratorA = new ConcretDecoratorA(component);
            ConcretDecoratorB decoratorB = new ConcretDecoratorB(decoratorA);

            component.Operation();

            decoratorA.Operation();

            decoratorB.Operation();
            #endregion
        }

        private static void CreationalPatterns()
        {
            #region Singleton
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
            #endregion

            #region FactoryMethod
            DP.C.FactoryMethod.Use.Applay();
            #endregion
            #region Prototype
            // Example 1
            DP.C.Prototype.Use.Apply();
            // Example 2
            var prototype = new ConcretPrototype1
            {
                Property1 = "A",
                Property2 = "B",
                PrototypeDetails = new PrototypeDetails { Details = "prototype Details" }
            };
            var newObject = prototype.Clone() as ConcretPrototype1;
            newObject.PrototypeDetails.Details = "New details from newObject";

            Console.WriteLine(prototype);
            Console.WriteLine(newObject);

            var prototype2 = new ConcretPrototype2
            {
                OtherProperty = "Z",
                Property1 = "X",
                Property2 = "Y",
                PrototypeDetails = new PrototypeDetails
                {
                    Details = "Prototype2 details"
                }
            };
            // create new instance using prototype2
            var newObject2 = prototype2.Clone() as ConcretPrototype2;
            newObject2.Property1 = "P01";

            Console.WriteLine(prototype2);
            Console.WriteLine(newObject2);
            #endregion

            #region Builder 
            Director director = new Director();
            CarBuilder builder = new CarBuilder();
            director.ConstructSportCar(builder);
            Car car = builder.GetResult();

            CarManualBuilder carManualBuilder = new CarManualBuilder();
            director.ConstructSportCar(carManualBuilder);

            Manual manual = carManualBuilder.GetResult();
            #endregion
            //DP.B.Strategy.Real.Use.Applay();
            //DP.B.Mediator.Real.Use.Apply();
            //DP.S.Adapter.Real.Use.Applay();

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
    

