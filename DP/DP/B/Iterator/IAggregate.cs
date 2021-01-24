namespace DP.B.Iterator
{
    interface IAggregate
    {
        IIterator CreateIterator();
        int Count();
        object this[int index] { get; set; }
    }
}