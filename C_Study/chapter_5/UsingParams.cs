using System;
using System.Collections.Generic;
using System.Text;


// page 207
// 가변 개수의 인수 받기
// Params 키워드와 배열을 이용하여 선언한다.
namespace C_Study.chapter_5
{
    class UsingParams
    {
        static int Sum(params int[] args)
        {
            Console.Write("Summing...");
            int sum = 0;
            foreach(int i in args)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(i);

                sum += i;
            }
            Console.WriteLine();
            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine($"Sum: {sum}");
        }

    }
}
