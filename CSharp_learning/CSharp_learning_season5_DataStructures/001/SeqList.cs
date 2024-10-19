using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project001_seqLink
{
    //实现顺序表
    class SeqList<T> : IListDS<T> //继承接口
    {
        private T[] data;
        private int count = 0;

        public SeqList(int size)
        {
            data = new T[size];
            count = 0;
        }

        public SeqList() : this(10) //默认容量为10
        {
        }

        public T this[int index]
        {
            get { return GetEle(index); }
        }

        public void Add(T item) //OK
        {
            if (count == data.Length)
            {
                Console.WriteLine("full of size");
                Console.WriteLine("当前顺序表已经存满");
            }
            else
            {
                data[count] = item;
                count++;
            }
        }

        public void Clear() //OK
        {
            count = 0;
        }

        public T Delete(int index) //OK
        {
            T temp = data[index];
            for (int i = index + 1; i< count; i++)
            {
                data[i - 1] = data[i];
            }
            count--;
            return temp;
        }

        public T GetEle(int index) //OK
        {
            if (index >= 0 && index <= count - 1)//判断索引是否存在
            { return data[index]; }
            else
            { 
                Console.WriteLine("out of index");
                return default(T);
            }
        }

        public int GetLength() //OK
        {
            return count;
        }

        public void Insert(T item, int index) //OK
        {
            for (int i = count -1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }

        bool IListDS<T>.isEmpty() //OK
        {
            return count == 0;
        }

        int IListDS<T>.Locate(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value))
                {
                    return i;
                }

            }
            return -1;
        }
    }
}
