using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
namespace C_Study
{
    // page 98
    class StringSlice
    {
        // Split() : 지정된 문자를 기준으로 현재 문자열을 분리한 다음 분리한 문자열의 배열을 반환합니다.
        // SubString() : 현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자로 이루어진 새 문자열을 반환합니다. 
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting.Substring(0, 5)); // good
            WriteLine(greeting.Substring(5)); // morning
            WriteLine();

            string[] arr = greeting.Split(new string[] { " " }, StringSplitOptions.None);
            WriteLine($"Word Count: {arr.Length}");
            foreach(string element in arr)
            {
                WriteLine($"{element}");
            }
        }
    }
}
