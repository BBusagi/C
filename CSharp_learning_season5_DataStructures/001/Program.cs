using System;
using System.Collections.Generic;
//C# 提供的泛型集合类

//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace project001_seqLink
{
    class Program
    {
        static void Main(string[] args)
        {
            SeqList<string> seqList = new SeqList<string>();
            void Output()
            {
                for (int i = 0; i < seqList.GetLength(); i++)
                {
                    Console.Write(seqList[i] + " ");
                }
                Console.WriteLine();
            }

            seqList.Add("123");
            seqList.Add("456");
            seqList.Add("789");

            Console.WriteLine(seqList.GetEle(0));
            Console.WriteLine(seqList[0]);

            seqList.Insert("777",1);
            Output();

            seqList.Delete(0);
            Output();

            seqList.Clear();
            Console.WriteLine(seqList.GetLength());
        }
    }
}
