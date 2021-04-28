using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study.chapter_5
{
    // page 201
    // 출력 전용 매개변수
    class UsingOut
    {
        // 까먹는 일 없이 대입할 수 있다.  
        static void Divide(int a, int b, out int quotient, out int remainder) // 출력 전용 ref 키워드?
        {
            quotient = a / b; // 무조건 할당 해야됨
            remainder = a * b;
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a:{a} b:{b} c:{c} d:{d}");
            
        }
    }
}
