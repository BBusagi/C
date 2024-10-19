using System;

namespace Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());

            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());

            //var c = a + b;    //加法
            //var c = (a + b) / 2;    //平均
            var c = a / b;  //a元分给b个人

            Console.WriteLine("Result: " + c);



        }
    }
}
