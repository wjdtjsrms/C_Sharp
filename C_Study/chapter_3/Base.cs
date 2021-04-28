using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    class Base
    {
        // 2진수, 10진수, 16진수 리터럴 예제
        // Page 51
        static void Main(String[] args)
        {
            byte a = 240; // 10진수 리터럴
            Console.WriteLine($"a = {a}");

            byte b = 0b1111_0000; // 2진수 리터럴 접두사 0b
            Console.WriteLine($"b = {b}");

            byte c = 0XF0; // 16진수 리터럴 접두사 0X
            Console.WriteLine($"c = {c}");

            uint d = 0x1234_abcd; // 16진수 리터럴 접두사 0X
            Console.WriteLine($"d = {d}");
        }
    }
}
