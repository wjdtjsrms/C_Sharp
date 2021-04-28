using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    // 부호 있는 정수 형식과 부호 없는 정수 형식 사이의 변환
    // page 74
    class Casting3
    {
        static void Main(String[] args)
        {
            int a = 500;
            Console.WriteLine(a);

            uint b = (uint)a; // 양수 -> 부호 없는 타입 OK!!
            Console.WriteLine(b);


            int x = -30;
            Console.WriteLine(x);

            uint y = (uint)x;
            Console.WriteLine(y); // UnderFlow 발생


        }
    }
}
