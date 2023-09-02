using System;

namespace project_005
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());

            switch (number1)
            {
                case 1:
                    Console.WriteLine(1);
                    break;

                case 2:
                    Console.WriteLine(2);
                    break;

                case 3:
                    Console.WriteLine(3);
                    break;

                case 4:
                    Console.WriteLine(4);
                    break;

                case 5:
                    Console.WriteLine(5);
                    break;

                default:
                    Console.WriteLine(0);
                    break;
            }

            //case合并
            int number2 = Convert.ToInt32(Console.ReadLine());

            switch (number2)
            {
                case 1:
                case 2:
                    Console.WriteLine(12);
                    break;

                case 3:
                case 4:
                    Console.WriteLine(34);
                    break;

                case 5:
                    Console.WriteLine(5);
                    break;

                default:
                    Console.WriteLine(0);
                    break;
            }
             
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double res = a * 1.0 / b;
            Console.WriteLine(res);


        }
    }
}