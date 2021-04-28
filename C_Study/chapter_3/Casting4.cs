using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    // 부동 소수점 형식과 정수 형식 사이의 변환
    // page 75
    class Casting4
    {
        static void Main(string[] args)
        {
            float a = 0.9f;
            int b = (int)a;
            Console.WriteLine(b);

            float c = 1.1f;
            int d = (int)c;
            Console.WriteLine(d);

        }
    }
}
