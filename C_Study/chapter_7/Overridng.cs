using System;
using System.Collections.Generic;
using System.Text;

// page 260
// 오버라이딩과 다형성

namespace C_Study.chapter_7
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }


    }
    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }
    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double_Barrel Cannons Armed");
            Console.WriteLine("Micro_Rocket Launcher Armed");
        }
    }
    class Overridng
    {
        static void Main(String[] args)
        {
            ArmorSuite armorSuite = new ArmorSuite();

            Console.WriteLine("Creating ArmorSuite...");
            armorSuite.Initialize();

            Console.WriteLine("Creating IronMan...");
            armorSuite = new IronMan();
            armorSuite.Initialize();

            Console.WriteLine("Creating WarMachine...");
            armorSuite = new WarMachine();
            armorSuite.Initialize();
        }

    }
}
