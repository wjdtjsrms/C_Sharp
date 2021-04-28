using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace C_Study
{
    #region String_Modify
    /* ToLower() : 현재 문자열의 모든 대문자를 소문자로 바꾼 새 문자열을 반환합니다.
     * ToUpper() : 현재 문자열의 모든 소문자를 대문자로 바꾼 새 문자열을 반환합니다.
     * Insert() : 현재 문자열의 지정된 위치에 지정된 문자열이 삽입된 새 문자열을 반환합니다.
     * Remove() : 현재 문자열의 지정된 위치로부터 지정된 숫자만큼의 문자가 삭제된 새 문자열을 반환합니다.
     * Trim() : 현재 문자열의 앞/뒤에 있는 공백을 삭제한 새 문자열을 반환합니다.
     * TrimStart() : 현재 문자열의 앞에 있는 공백을 삭제한 새 문자열을 반환합니다.
     * TrimEnd() : 현재 문자열의 뒤에 있는 공백을 삭제한 새 문자열을 반환합니다.
     */
    #endregion
    class StringModify
    {
        static void Main(string[] args)
        {
            WriteLine($"ToLower() : {"ABC".ToLower()}");
            WriteLine($"ToUpper() : {"abc".ToUpper()}");
            WriteLine();

            WriteLine($"Insert() : {"Happy Friday!".Insert(5, " Sunny")}");
            WriteLine($"Remove() : {"I Don't Love You.".Remove(2, 6)}");
            WriteLine();

            WriteLine($"Trim() : '{" No spaces ".Trim()}'");
            WriteLine($"TrimStart() : '{" No spaces ".TrimStart()}'");
            WriteLine($"TrimEnd() : '{" No spaces ".TrimEnd()}'");
        }
    }
}
