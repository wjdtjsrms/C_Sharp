using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    // page 92
    class CTS
    {
        static void Main(String[] args)
        {
            // GetType() 해당 객체의 실제 형식을 알려준다.
            // ToString() 변수의 데이터를 문자열로 표시한다.

            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine($"a type: {a.GetType()} value: {a.ToString()}");
            Console.WriteLine($"b type: {b.GetType()} value: {b.ToString()}");

            System.String c = "abc";
            string d = "def";

            Console.WriteLine($"a type: {c.GetType()} value: {c.ToString()}");
            Console.WriteLine($"b type: {d.GetType()} value: {d.ToString()}");

        }
    }
}
