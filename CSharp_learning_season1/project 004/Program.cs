using System;

namespace project_004
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据交换，ab互换
            int a = 10;
            int b = 5;

            //方法1 利用临时值保存   多内存 快
            //int c = b;
            //b = a;
            //a = b;

            //方法2 利用加法存储    不占内存 慢
            //a = a + b;
            //b = a - b;
            //a = a - b;

            //字符串中的格式化输出
            Console.WriteLine("{0}+{1}={2}", 1, 2, 3);
        }
    }
}
