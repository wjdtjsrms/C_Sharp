using System;
using System.Collections.Generic;
using System.Text;

// page 203
// 메소드 오버로딩
// 매개변수의 개수와 형식이 다른경우 사용한다.
namespace C_Study.chapter_5
{
    class Overloading
    {
        static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int,int)");
            return a + b;
        }
        static int Plus(int a, int b,int c)
        {
            Console.WriteLine("Calling int Plus(int,int,int)");
            return a + b + c;
        }
        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling int Plus(double,double)");
            return a + b;
        }
        static double Plus(double a, double b, double c)
        {
            Console.WriteLine("Calling int Plus(double,double,double)");
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));
        }
    }
}
