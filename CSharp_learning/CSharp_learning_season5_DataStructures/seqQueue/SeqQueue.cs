using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project008_seqQueue
{
    class SeqQueue<T> : IQueueDS<T>
    {
        private T[] data;
        private int count;
        private int front; //index of front -1
        private int rear; // = index of rear

        public SeqQueue(int size)
        {
            data = new T[size];
            count = 0;
            front = rear = -1;
        }
        public SeqQueue() : this(10)
        { 
        }
        public int Count
        {
            get { return count; }
        }
        public void Clear()
        {
            count = 0;
            front = rear = -1;
        }
        public T Dequeue()
        {
            if (count > 0)
            {
                T temp = data[front + 1];
                front++;
                count--;
                return temp;
            }
            else
            { 
                Console.WriteLine("Empty");
                return default;
            }
        }
        public void Enqueue(T item)
        {
            if (count == data.Length)
            {
                Console.WriteLine("overflow");
            }
            else 
            {
                if (rear == data.Length - 1)
                {
                    data[0] = item;
                    rear = 0;
                    count++;
                }
                else 
                {
                    data[rear + 1] = item;
                    rear++;
                    count++;
                }
            }
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
            T temp = data[front + 1];
            return temp;
        }
    }
}
