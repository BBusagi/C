/* 
 * 这是第一个程序
 */

using System; //引用命名空间

namespace project_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //Console隶属于System下面的class
            Console.Write("No enter for texting ----------"); //在结尾没有换行符号
            Console.WriteLine("This is R\tiku.");//斜杠 制表符
            Console.WriteLine("This is \nRiku.");//换行符
            Console.WriteLine("one\\");//双斜杠 仅显示一个
            Console.WriteLine();

        }
    }
}

namespace _001 //命名空间若以数字开头，须添加下划线
{
    }
