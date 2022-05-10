using System;

namespace Queue_Dequeue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Isempty();
            list.Display();
        }
    }
}
