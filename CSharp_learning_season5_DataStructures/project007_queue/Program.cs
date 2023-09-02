using System;
using System.Collections.Generic;

namespace project007_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
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
            Console.WriteLine(queue.Count)
        }
    }
}
