using System;
using System.Collections.Generic;
using System.Text;

namespace Project_002_ChildStruct
{
    class DrivedClass : BaseClass
    {
        private int attack;

        public DrivedClass():base()//调用基类的构造函数，不写也会默认调用
        {
            Console.WriteLine("DrivedClass");
        }

        public DrivedClass(int attack)
        {
            this.attack = attack;
            Console.WriteLine("Attack:" + attack);
        }

        public DrivedClass(int attack, int hp, int speed):base(hp,speed)
        {
            this.attack = attack;
            Console.WriteLine("Attack:" + attack);
            Console.WriteLine("speed+");

        }
    }
}
