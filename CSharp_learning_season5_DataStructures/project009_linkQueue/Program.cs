using System;

namespace project009_linkQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueueDS<int> queue = new LinkQueue<int>();
            queue.Enqueue(23);
            queue.Enqueue(45);
            queue.Enqueue(67);
            queue.Enqueue(89);
            Console.WriteLine(queue.Count);

            int i = queue.Dequeue();
            Console.WriteLine(i);
            Console.WriteLine(queue.Count);

            int j = queue.Peek();
            Console.WriteLine(j);
            Console.WriteLine(queue.Count);

            queue.Clear();
            Console.WriteLine(queue.Count);
        }
    }
}
