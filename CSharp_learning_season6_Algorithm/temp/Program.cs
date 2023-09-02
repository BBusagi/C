using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "P 0.18 R -1.00";
            int indexP = message.IndexOf("P ");
            int indexR = message.IndexOf(" R ");
            Console.WriteLine(indexP.ToString()+":"+indexR.ToString());

            float vertical = message.Substring(indexP + 2, indexR).ToFloat();
            float horizontal = message.Substring(indexR + 3).ToFloat();
        }
    }
}
