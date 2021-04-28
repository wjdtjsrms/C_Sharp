using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    // 크기가 서로 다른 부동 소수점 형식 사이의 변환
    // page 73
    class Casting2
    {
        static void Main(String[] args)
        {
            float a = 69.6875f;
            Console.WriteLine("a:{0}", a);

            double b = (double)a; // float - > double
            Console.WriteLine("b:{0}", b);

            Console.WriteLine($"69.6875 == b: {69.6875 == b}");

            float x = 0.1f;
            Console.WriteLine("x:{0}", x);

            double y = (double)x;
            Console.WriteLine("y:{0}", y);

            Console.WriteLine($"0.1 == y: {0.1 == y}"); // false 나옴 ㅠㅠ
        }
    }
}
