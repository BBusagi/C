using System;
using System.Collections.Generic;
using System.Text;

//属性访问器
namespace Project_001_class
{
    class Customer
    {
        //数据成员 name age address createTime

        //完整写法
        private string name;
        public void SetAge(string name)
        {
            this.name = name;
        }

        public string GetAge()
        {
            return name;
        }


        //常用写法
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set 
            {
                age = value;
            }
        }


        //常用缩写
        private string address;
        public string Address { get; set; }

        //最简称
        //自动创建  private string creatTime;
        public int CreateTime { get; set; }


    }
}
