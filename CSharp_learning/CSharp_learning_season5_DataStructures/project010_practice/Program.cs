using System;
using System.Collections.Generic;

namespace project010_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            for (int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);
                queue.Enqueue(str[i]);
            }

            bool isHui = true;
            while (stack.Count > 0)
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    isHui = false;
                    break;
                }
            }
            
            Console.WriteLine(isHui);
        }
    }
}
