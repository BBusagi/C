using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_learning_MyList
{
    class MyList<T>
    {
        private T[] data = new T[0];
        private int count = 0;
        private int index;

        //索引检测 限制索引器的检测范围
        public void CheckIndex(int index)
        {
            if (index < 0 || index > count)
            {
                throw new System.ArgumentOutOfRangeException("超出范围");
            }
        }

        //数据操作
        public T this[int index]
        {
            get
            {
                CheckIndex(index);
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public int Capcity
        {
            get
            {
                return data.Length;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        //添加数据
        public void Add(T item)
        {
            if (data.Length == 0)
            {
                data = new T[4];
            }

            if (data.Length == count)
            {
                T[] temp = new T[count * 2];
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
            data[count] = item;
            count++;
        }

        //数据插入
        public void Inset(int index, T item)
        {
            CheckIndex(index);
            for (int i = count - 1; i > index - 1; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }

        public void RemoveAt(int index)
        {
            CheckIndex(index);

            for (int i = index - 1; i < count; i++)
            {
                data[i] = data[i+1];
            }
            count--;
        }

        //从前往后遍历
        public int IndexOf (T item)
        {
            for (int i = 0; i < count; i++)
            {
                index = -1;//初始化 若没有该数字 则索引为默认的-1

                //if (item == data[i])  
                //系统无法判断泛型是否可以与int数值相比较
                if (item.Equals(data[i]))
                {
                    index = i;
                    break;
                }
            }
            return index+1;
        }

        //从后往前遍历
        public int LastIndexOf(T item)
        {
            for (int i = count - 1; i > -1; i--)
            {
                index = -1;//初始化 若没有该数字 则索引为默认的-1
                if (item.Equals(data[i]))
                {
                    index = i;
                    break;
                }
            }
            return index+1;
        }

        public void Sort()
        {
            Array.Sort(data,0,count);
        }
    }
}
