using System;

namespace Project_001_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer list1 = new Customer();

            list1.SetAge(23);
            Console.WriteLine(list1.GetAge());
            list1.Name = "Riku";
            Console.WriteLine(list1.Name);
        }
    }
}
