using System;

namespace LinkedList_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Display();
        }
    }
}
