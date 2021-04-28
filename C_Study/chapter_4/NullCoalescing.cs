using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study.chapter_4
{
    // page 142
    // null 병합 연산자
    class NullCoalescing
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine($"{num ?? 0}"); // num이면 null 이면 우항 반환

            num = 99;
            Console.WriteLine($"{num ?? 0}"); // num이면 null 아니면 좌항 반환

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");
        }
    }
}
