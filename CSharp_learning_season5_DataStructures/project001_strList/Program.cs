using System;
using System.Collections.Generic;
//C# 提供的泛型集合类

namespace project002_strList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //使用默认泛型list
            List<string> strList = new List<string>();
            //添加元素
            strList.Add("123"); //默认索引 0
            strList.Add("456"); //        1
            strList.Add("789"); //        2

            //移除元素
            strList.Remove(strList[2]);

            //计算链表
            int count = strList.Count;
            Console.WriteLine(strList.Count);

            //清空数据
            strList.Clear();
            Console.WriteLine(strList.Count);
        }
    }
}

