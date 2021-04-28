using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    class OverFlow
    {
        // 사용시 Main()으로 교체
        // OverFlow 예제
        // page 55
        static void Main(String[] args)
        {
            uint a = uint.MaxValue;
            Console.WriteLine(a);

            a = a + 1; // uint가 가질 수 있는 최저값을 갖는다. 0
            Console.WriteLine(a);
        }
    }
}
