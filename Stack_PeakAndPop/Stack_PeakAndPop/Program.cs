using System;

namespace Stack_PeakAndPop
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.IsEmpty();
            list.Display();
        }
    }
}
