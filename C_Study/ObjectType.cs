using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    class ObjectType
    {
        // 사용시 Main()으로 교체
        // page 57
        static void Main(String[] args)
        {
            // object는 모든 데이터 형식()의 부모 클래스이다.

            object a = 123;
            object b = 3.141592653589793238462643383279m;
            object c = true;
            object d = "안녕하세요";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
