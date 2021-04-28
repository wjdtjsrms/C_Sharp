using System;
using System.Collections.Generic;
using System.Text;

// 로컬 함수
// page 213
// 메소드 안에서 선언되는 함수, 지역변수에 접근할수 있다.

namespace C_Study.chapter_5
{
    class LocalFunction
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) // A ~ Z의 ASCII 값: 65 ~ 90
                    return arr[i];
                else
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello"));
            Console.WriteLine(ToLowerString("Good Morning"));
            Console.WriteLine(ToLowerString("This is C#"));
        }
    }
}
