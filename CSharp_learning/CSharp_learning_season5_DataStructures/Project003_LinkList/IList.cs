using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project003_LinkList
{
    interface IListDS<T>
    {
        int GetLength();
        void Clear();
        bool isEmpty();
        void Add(T item);
        void Insert(T item, int index);
        T Delete(int index);
        T this[int index] { get; }
        T GetEle(int index);
        int Locate(T value);
    }
}
