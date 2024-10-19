using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project006_linkStack
{
    class LinkStack<T> : IStackDS<T>
    {
        private Node<T> top;
        private int count = 0;

        public int Count
        {
            get { return count; }
        }
        public void Clear()
        {
            count = 0;
            top = null;
        }
        public int GetLength()
        { 
            return count;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public T Peek()
        {
            return top.Data;
        }
        public T Pop()
        {
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }
        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }
    }
}
