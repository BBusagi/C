using System;
using System.Collections.Generic;
using System.Text;

namespace Project_002_ChildStruct
{
    class BaseClass
    {
        private int hp;
        private int speed;

        public BaseClass(int hp, int speed)
        {
            this.hp = hp;
            this.speed = speed;
        }

        public BaseClass()
        {
            Console.WriteLine("BaseClass");

        }
    }
}
