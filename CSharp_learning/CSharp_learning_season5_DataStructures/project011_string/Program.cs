using System;

namespace project011_string
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDS s = new StringDS("I am a teacher.");
            StringDS i = new StringDS("excellent");
            StringDS r = new StringDS("student");
            Console.WriteLine(s.GetLength());
            Console.WriteLine(i.GetLength());
            Console.WriteLine(r.GetLength());

            StringDS s2 = s.SubString(8, 4);
            Console.WriteLine(s2.ToString());

            StringDS i2 = i.SubString(2, 1);
            Console.WriteLine(i2.ToString());

            Console.WriteLine(s.IndexOf(new StringDS("tea")));
            Console.WriteLine(i.IndexOf(new StringDS("cell")));
            Console.WriteLine(r.IndexOf(new StringDS("den")));

            StringDS s3 = new StringDS("I am a teacher.");
            StringDS t3 = new StringDS("tea");
            StringDS r3 = new StringDS("stu");
            Console.WriteLine(s3.IndexOf(t3));
            Console.WriteLine(s3.Copy().ToString());

            //StringDS res = s3.Replace(t3, r3);
            //Console.WriteLine(res.ToString());


        }
    }
}
