using System;

namespace CSharp_learning_MyList
{
    class Program
    {
        public void Test()
        {


        }

        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            var var_Capcity = list.Capcity;

            Console.WriteLine(var_Capcity);

            list.Add(100);
            list.Add(103);
            list.Add(102);
            list.Add(101);
            list.Add(104);
            list.Add(101);
            list.Add(105);

            Console.WriteLine(list);

            Console.WriteLine("Count:" + list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //由于在MyList中限制索引器只能比计数器小
            //Console.WriteLine("Capcity:" + list.Capcity);
            //for (int i = 0; i < list.Capcity; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            list.RemoveAt(1);
            Console.WriteLine(list);

            Console.WriteLine("Count:" + list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //抛出异常测试
            //MyList<int> list2 = new MyList<int>();
            //int temp = list2[-1];

            Console.WriteLine(list.IndexOf(105));
            Console.WriteLine(list.LastIndexOf(105));
            Console.WriteLine();
            Console.WriteLine(list.IndexOf(101));
            Console.WriteLine(list.LastIndexOf(101));


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


        }
    }
}
