using System;
using System.Collections.Generic;
using System.Text;

// 문 형식의 람다 , page 491

namespace C_Study.chapter_14
{
   
    class StatementLamda
    {
        delegate string Concatenate(string[] args);
        static void Main(string[] args)
        {
            Concatenate concat =
                (arr) => // (매개변수 목록) => { 문장들 }
                {
                    string result = "";
                    foreach (string s in arr)
                        result += s;

                    return result;
                };

            Console.WriteLine(concat(args));
        }
    }
}
