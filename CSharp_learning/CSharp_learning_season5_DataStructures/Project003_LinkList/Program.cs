using System;
using System.Collections.Generic;

namespace Project003_LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList<string> LinkList = new LinkList<string>();
            void Output()
            {
                for (int i = 0; i < LinkList.GetLength(); i++)
                {
                    Console.Write(LinkList[i] + " ");
                }
                Console.WriteLine();
            }

            LinkList.Add("123");
            LinkList.Add("456");
            LinkList.Add("789");

            Console.WriteLine(LinkList.GetEle(0));
            Console.WriteLine(LinkList[0]);

            LinkList.Insert("777", 1);
            Output();

            LinkList.Delete(0);
            Output();

            Console.WriteLine(LinkList.Locate("789"));
            Console.WriteLine(LinkList.Locate("999"));

            LinkList.Clear();
            Console.WriteLine(LinkList.GetLength());
        }
    }
}
