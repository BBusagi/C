using System;

namespace project_005
{
    class Program
    {
        static void Main()
        {
            string str = "sguigiuGHIUGUIG";
            Console.WriteLine("原文： " + str);

            string str2 = str.ToLower();
            Console.WriteLine("转化为小写： " + str2);

            string str3 = str.ToUpper();
            Console.WriteLine("转化为大写： " + str3);


        }
    }
}
