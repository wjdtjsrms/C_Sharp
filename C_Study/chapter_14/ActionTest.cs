using System;
using System.Collections.Generic;
using System.Text;

// Action 대리자, page 495
// Func 대리자와 똑같은데 반환 형식이 없다. void형 함수 대리자

namespace C_Study.chapter_14
{
    class ActionTest
    {
        static void Main(string[] args)
        {
            Action act1 = () => Console.WriteLine("Action()"); // 아무것도 안써도 된다.
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;

            act2(3);
            Console.WriteLine($"{result}");

            Action<double, double> act3 = (x, y) =>
             {
                 double pi = x / y;
                 Console.WriteLine($"{pi}");
             };

            act3(22.0, 7.0);
        }
    }
}
