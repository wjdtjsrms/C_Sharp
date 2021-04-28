using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study.chapter_3
{
    class Chapter_3_1
    {
        static void Main()
        {
            Console.WriteLine("사각형의 너비를 입력하세요");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요");
            string height = Console.ReadLine();

            int w = int.Parse(width);
            int h = int.Parse(height);

            Console.WriteLine($"사각형의 크기: {w * h}");
        }
    }
}
