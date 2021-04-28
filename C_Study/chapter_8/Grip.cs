using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Study.chapter_8
{
    abstract class GripTool
    {
        public  bool Grip(string other)
        {
            if(other.Equals("Hand"))
            {
                
                return true;
            }

            return false;
        }
        public abstract void use();
    }

    class Fire : GripTool
    {
        public override void use()
        {
            Console.WriteLine("불이야!!");
        }
    }

    class Potion : GripTool
    {
        public override void use()
        {
            Console.WriteLine("체력이 늘어난다!!");
        }
    }


    class Grip
    {
        static void Main(string[] args)
        {
            Fire fire = new Fire();
            Potion potion = new Potion();

            GripTool gripTool = fire;

            if (gripTool.Grip("Hand"))
            {
                gripTool.use();
            }

            gripTool = potion;

            if (gripTool.Grip("Hand"))
            {
                gripTool.use();
            }
        }
    }
}
