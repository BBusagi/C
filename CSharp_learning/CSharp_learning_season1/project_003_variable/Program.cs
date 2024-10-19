using System;

namespace project_003_variable
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 97;
            char b = (char)a; //强制类型转换
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine();

            char c = '1';
            int d = c;
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine();

            Console.WriteLine("c:\\a\\b\\c");
            Console.WriteLine(@"c:\a\b\c"); //取消转义功能
            Console.WriteLine(@"c:\\a\\b\\c");

            string str = @"www.siki.com\nsiki";
            Console.WriteLine(str);

            string str2 = "123" + "456";
            Console.WriteLine(str2);

            string str_read = Console.ReadLine();
            Console.WriteLine("\t" + str_read);

            string str_readInt = Console.ReadLine();
            int str_Int = Convert.ToInt32(str_readInt);//只能将字符串整数转化为数字
            Console.WriteLine("\t" + str_Int);

            int read_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t" + read_Number);


            



        }
    }
}
