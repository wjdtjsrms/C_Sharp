using System;
using System.Collections.Generic;
using System.Text;
using MyExtension;

// 확장 메서드 page 278
// static 한정자로 수식한다.
// 매개변수는 반드시 this 키워드와 확장하고자 하는 클래스 또는 형식을 집어 넣는다. this int, this double
namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }
        public static int Power(this int myInt,int exponent)
        {
            int result = myInt;
            for(int i = 1; i < exponent; i++)
            {
                result = result * myInt;
            }

            return result;
        }
    }
}


namespace C_Study.chapter_7
{
    class ExtensionMethod
    {
       static void Main(string[] args)
        {
            Console.WriteLine($"3^2 {3.Square()}");
            Console.WriteLine($"3^4 {3.Power(4)}");
            Console.WriteLine($"2^10 {2.Power(10)}");
        }
    }
}
