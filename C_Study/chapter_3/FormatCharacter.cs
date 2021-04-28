using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    class FormatCharacter
    {
        // 사용시 Main()으로 교체
        // page 63
        static void Main(String[] args)
        {
            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';

            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.Write(e);
            Console.WriteLine();

            string f = "안녕하세요?";
            string g = "정선근입니다.";
            Console.WriteLine(f);
            Console.WriteLine(g);
        }
    }
}
