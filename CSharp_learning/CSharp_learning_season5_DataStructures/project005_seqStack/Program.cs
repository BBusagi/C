using System;

namespace project005_seqStack
{
    class Program
    {
        static void Main(string[] args)
        {
            IStackDS<char> stack = new SeqStack<char>(10);

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
        }
    }
}
