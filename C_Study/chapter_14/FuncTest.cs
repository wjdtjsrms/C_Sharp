using System;
using System.Collections.Generic;
using System.Text;

// Func 대리자, page 492
// 익명 메소드나 무명 함수를 만들기 위해 매번 대리자를 선언하기 귀찮아서 미리 선언해둠
namespace C_Study.chapter_14
{
    class FuncTest
    {
        static void Main(string[] args)
        {
            Func<int> fun1 = () => 10; // 반환형만 있다.
            Console.WriteLine(fun1());

            Func<int, int> fun2 = (x) => (x * 2); // 매개변수 하나와 반환형이 있다.
            Console.WriteLine(fun2(4));

            Func<double, double, double> func3 = (x, y) => x / y; // 매개변수 두개와 반환형이 있다.
            Console.WriteLine(func3(22, 7));
        }
    }
}
