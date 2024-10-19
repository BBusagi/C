using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project005_seqStack
{
    class SeqStack<T> : IStackDS<T>
    {
        private T[] data;
        private int top;

        public SeqStack(int size)
        {
            data = new T[size];
            top = -1;
        }

        public SeqStack() : this(10)
        {
        }

        public int Count //OK
        {
            get 
            {
                return top + 1;
            }
        }

        public void Clear() //OK
        {
            top = -1;
        }

        public int GetLength() //OK
        {
            return Count;
        }

        public bool IsEmpty() //OK
        {
            return Count == 0;
        }

        public T Peek() //OK
        {
            return data[top];
        }

        public T Pop() //OK
        {
            T temp = data[top];
            top--;
            return temp;
        }

        public void Push(T item) //OK
        {
            data[top + 1] = item;
            top++;
        }
    }
}
