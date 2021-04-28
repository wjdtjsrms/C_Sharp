using System;
using System.Collections.Generic;
using System.Text;
using MyExtension;

//page 279
// string 확장 메서드

namespace MyExtension
{
    public static class StringExtension // public, static, static 클래스 까먹지 말것!!
    {
        public static string Append(this string myString, string appendStr)
        {
            return myString + appendStr;
        }
    }
    
}



namespace C_Study.chapter_7
{
    class chapter_7_2
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            Console.WriteLine(hello.Append(", World!"));
        }
    }
}
