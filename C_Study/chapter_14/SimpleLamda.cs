using System;
using System.Collections.Generic;
using System.Text;

// 람다 page 489

namespace C_Study.chapter_14
{
    class SimpleLamda
    {
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            Calculate calc = (a, b) => a + b; // 매개 변수 목록 => 문장
            Console.WriteLine(calc(3 ,4)); 
        }
    }
}
