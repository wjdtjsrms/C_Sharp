using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study.chapter_13
{
    // 대리자 page 457
    // 대리자는 인스턴스가 아닌 type이다. 
    // 대리자의 반환형식과 매개변수를 따르는 함수만 참조 가능
    class Delegate
    {
        delegate int MyDelegate(int a, int b);
        class Calculator
        {
            public int Plus(int a,int b)
            {
                return a + b;
            }
            public int Minus(int a, int b)
            {
                return a - b;
            }
        }

        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback; // 대리자 생성

            Callback = new MyDelegate(Calc.Plus); // 대리자 메소드 참조
            Console.WriteLine(Callback(3, 4)); // 참조하고 있는 메소드 사용

            Callback = new MyDelegate(Calc.Minus);
            Console.WriteLine(Callback(3, 4));
        }
          

    }
}
