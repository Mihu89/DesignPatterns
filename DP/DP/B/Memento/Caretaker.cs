using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Memento
{
    class CareTaker<T> where T : ICloneable
    {
        static List<Memento<T>> mementoList = new List<Memento<T>>();
        public static void SaveState(Originator<T> orig)
        {
            mementoList.Add(orig.CreateMemento());
        }   
        
        public static void RestoreState(Originator<T> orig, int checkPoint)
        {
            orig.RestoreMemento(mementoList[checkPoint]);
        }
    }
}
