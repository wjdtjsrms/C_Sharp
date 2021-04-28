using System;
using System.Collections;


// Queue page 385
// 선출 선입 입력은 오직 뒤에서 출력은 오직 앞에서 이루어진다.

namespace C_Study.chapter_10
{
    class UsingQueue
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            for(int i =0; i <5; i++)
            {
                que.Enqueue(i + 1); // 요소 삽입
            }

            while(que.Count>0)
            {
                Console.WriteLine(que.Dequeue()); // 요소 출력
            }
            
        }
    }
}
