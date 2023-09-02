using System;
using System.Collections.Generic;

namespace project004_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            stack.Push('a');
            stack.Push('b');
            stack.Push('c');

            Console.WriteLine(stack.Count);
            char temp = stack.Pop();
            Console.WriteLine(temp);
            Console.WriteLine(stack.Count);
            char temp2 = stack.Peek();
            Console.WriteLine(temp2);
            Console.WriteLine(stack.Count);
            stack.Clear();
            Console.WriteLine(stack.Count);
            //Console.WriteLine(stack.Peek()); //异常，空栈时取栈顶


        }
    }
}
