using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    class BoolType
    {

        // page 65
        static void Main(String[] args)
        {
            // bool 논리 형식 8비트 true,false
            // 기본적으로 다루는 데이터의 크기가 바이트 단위이기 때문에 8비트다.

            bool a = true;
            bool b = false;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine($"SIZE:{sizeof(bool)}byte");
            
        }
    }
}
