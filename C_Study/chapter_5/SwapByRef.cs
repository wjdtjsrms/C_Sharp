using System;
using System.Collections.Generic;
using System.Text;

// page 195
// 참조에 의한 매개변수 전달

namespace C_Study.chapter_5
{
    class SwapByRef
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }


        static void Main(String[] args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"x : {x} y : {y}");

            Swap(ref x, ref y);
            Console.WriteLine($"x : {x} y : {y}");
        }
    }
}
