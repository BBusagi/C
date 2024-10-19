using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project003_LinkList
{
    class LinkList<T> : IListDS<T>
    {
        private Node<T> head;   //存储头结点

        public LinkList()
        {
            head = null;
        }
        public T this[int index] //OK
        {
            get
            {
                Node<T> temp = head;
                for (int i = 1; i <= index; i++)
                {
                    temp = temp.Next;
                }
                return temp.Data;
            }
        }

        public void Add(T item) //OK
        {
            Node<T> newNode = new Node<T>(item);    //创建新结点
            //判断头结点是否为空
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (true)
                {
                    if (temp.Next != null) { temp = temp.Next; }
                    else{ break; }
                }
                temp.Next = newNode;    //将新结点添加到链表尾部
            }
            
        }

        public void Clear() //OK
        {
            head = null;
        }

        public T Delete(int index) //OK
        {
            T data = default(T);
            if (index == 0)
            {
                data = head.Data;
                head = head.Next;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i <= index - 1; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                data = currentNode.Data;
                Node<T> nextNode = temp.Next.Next;
                preNode.Next = nextNode;
            }
            return data;
        }

        public T GetEle(int index) //OK
        {
            return this[index];
        }

        public int GetLength() //OK
        {
            if (head == null) return 0;

            Node<T> temp = head;
            int count = 1;
            while (true)
            {
                if (temp.Next != null)
                {
                    count++;
                    temp = temp.Next;
                }
                else { break; }
            }
            return count;
        }

        public void Insert(T item, int index) //OK
        {
            Node<T> newNode = new Node<T>(item);
            if (index == 0) //插入头结点
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i <= index - 1; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                 
                preNode.Next = newNode;
                newNode.Next = currentNode;
            }
        }

        public bool isEmpty() //OK
        {
            return head == null;
        }

        public int Locate(T value)
        {
            Node<T> temp = head;
            if (temp == null)
            {
                return -1;
            }
            else
            {
                int index = 0;
                while (true)
                {
                    if (temp.Data.Equals(value))
                    {
                        return index;
                    }
                    else 
                    {
                        if (temp.Next != null)
                        {
                            temp = temp.Next;
                            index++;
                        }
                        else { break; }
                    }
                }
                return -1;
            }
        }
    }
}
