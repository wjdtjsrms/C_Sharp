using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study.chapter_5
{
    class Chpater_6_1
    {
        static double Square( double arg)
        {
            return arg * arg;
        }

        static void Main(string[] args)
        {
            Console.Write("수를 입력해주세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine($"결과 : {Square(arg)}");
        }

    }
}
