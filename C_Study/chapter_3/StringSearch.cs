using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace C_Study
{
    // page 94
    class StringSearch
    {
        #region string method
        /* IndexOf(): 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾는다.
         * LastIndexOf(): 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 뒤에서부터 찾습니다. 
         * StartsWith(): 현재 문자열이 지정된 문자열로 시작하는지를 평가한다.
         * EndsWith(): 현재 문자열이 지정된 문자열로 끝나는지를 평가한다.
         * Contains(): 현재 문자열이 지정된 문자열을 포함하는지를 평가한다.
         * Replace(): 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환합니다.
         */
        #endregion

        static void Main(String[] args)
        {
            string greeting = "Good Morning";
            WriteLine(greeting);
            WriteLine();

            //IndexOf()
            WriteLine($"IndexOf 'Good': {greeting.IndexOf("Good")}");
            WriteLine($"IndexOf 'o': {greeting.IndexOf("o")}");
            WriteLine();

            //LastIndexOf()
            WriteLine($"LastIndexOf 'Good': {greeting.LastIndexOf("Good")}");
            WriteLine($"LastIndexOf 'o': {greeting.LastIndexOf("o")}");
            WriteLine();

            //StartsWith()
            WriteLine($"StartsWith 'Good': {greeting.StartsWith("Good")}");
            WriteLine($"StartsWith 'Morning': {greeting.StartsWith("Morning")}");
            WriteLine();

            //EndsWith()
            WriteLine($"EndsWith 'Good': {greeting.EndsWith("Good")}");
            WriteLine($"EndsWith 'Morning': {greeting.EndsWith("Morning")}");
            WriteLine();

            //Contains()
            WriteLine($"Contains 'Evening': {greeting.Contains("Evening")}");
            WriteLine($"Contains 'Morning': {greeting.Contains("Morning")}");
            WriteLine();

            //Replace()
            WriteLine($"Replaced 'Morning' with 'Evening': {greeting.Replace("Morning", "Evening")}");

        }
    }
}
