using System;

namespace project_006
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(str);

            string str2 = str.ToUpper(); //全部转化为大写字母
            Console.WriteLine(str2);

            string str3 = str.ToLower(); //全部转化为小写字母
            Console.WriteLine(str3);

            string str4 = str.Trim();  //删除前后空格
            //TrimStart前面的空格 TrimEnd后面的空格
            Console.WriteLine(str4);

            Console.WriteLine();
            Console.WriteLine();


            string[] str_array = str.Split(",");
            foreach (string n in str_array)
            {
                Console.Write(n+"  ");
            }

        }


    }
}
