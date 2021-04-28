using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;
using static System.Console;

namespace C_Study.chapter_4
{
    // page 130
    // null 조건부 연산자
    class NullConditionalOperator
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); // a?.가 null을 반환하므로 add() 메소드는 호출되지 않음
            a?.Add("축구");

            WriteLine($"Count: {a?.Count}"); // a?.가 null을 Count만 출력됨
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList(); // a는 더이상 null이 아니다.
            a?.Add("야구"); 
            a?.Add("축구");


            WriteLine($"Count: {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
        }
    }
}
