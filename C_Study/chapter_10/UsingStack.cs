using System;
using System.Collections;


// page 386 stack
// 선입후출, FI-LO 구조

namespace C_Study.chapter_10
{
    class UsingStack
    {
       static void Main(string[] args)
        {
            Stack stack = new Stack();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i + 1); // 요소 삽입
            }

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
               
            }
        }
    }
}
