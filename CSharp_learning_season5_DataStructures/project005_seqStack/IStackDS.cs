using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project005_seqStack
{
    interface IStackDS<T>
    {
        int Count { get; }
        int GetLength();
        bool IsEmpty();
        void Clear();
        void Push(T item);
        T Pop();
        T Peek();
    }
}
