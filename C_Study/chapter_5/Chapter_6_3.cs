using System;
using System.Collections.Generic;
using System.Text;

// 오버로딩 예제

namespace C_Study.chapter_5
{
    class Chapter_6_3
    {
        public static void Main()
        {

            int a = 3;
            int b = 4;
            Plus(a, b, out int resultA);

            Console.WriteLine($"{a}+{b}={resultA}");

            double x = 2.4;
            double y = 3.1;
            Plus(x, y, out double resultB);

            Console.WriteLine($"{x}+{y}={resultB}");
        }

        public static void Plus(int a,int b,out int c)
        {
            c = a + b;
        }
        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
    }
}
