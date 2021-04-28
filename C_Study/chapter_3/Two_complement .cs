using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    class Two_complement
    {
        // page 54
        static void Main(String[] args)
        {
            #region 2의 보수법
            // sbyte, short, int, long 2의 보수법으로 음수를 나타낸다. 
            // -1을 2의 보수법으로 표현하는 과정
            // 1. 먼저 수 부분을 비트로 채운다 0 0 0 0 0 0 1
            // 2. 전체 비트를 반전 시킨다.     1 1 1 1 1 1 0
            // 3. 반전된 비트에 1을 더한다.    1 1 1 1 1 1 1
            #endregion

            byte a = 255;
            sbyte b = (sbyte)a;
            Console.WriteLine($"byte 255의 값: {a}");
            Console.WriteLine($"255 = (1111_1111)을 sbyte형식으로 변환한 값: {b}");
        }
    }
}
