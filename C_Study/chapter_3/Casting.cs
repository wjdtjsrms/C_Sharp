using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    // 크기가 서로 다른 정수 형식 사이의 변환
    // page 71
    class Casting
    {
        static void Main(String[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128; // x > sbyte.MaxValue
            Console.WriteLine(x);

            sbyte y = (sbyte)x; // overflow 발생
            Console.WriteLine(y);

        }
    }
}
