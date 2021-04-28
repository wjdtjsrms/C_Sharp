using System;
using System.Collections;

// ArrayList page 381
// 요소에 접근할때 [] 연산자를 이용하고 , 특정 위치에 데이터를 임의 할당 가능
// 배열과는 달리 자동으로 용량이 증가하거나 감소함.
// ArrayList가 다루는 데이터가 많으면 많을 수록 박싱과 언박싱이 많이 일어남

namespace C_Study.chapter_10
{
    class UsingList
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++) 
            {
                list.Add(i); // 요소 추가
            }

            foreach(object obj in list)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();

            list.RemoveAt(2); // 매개 변수 위치에 있는 요소 제거

            foreach (object obj in list)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();

            list.Insert(2, 2); // 인덱스에 밸류를 집어넣는다.
            foreach (object obj in list)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();

            list.Add("abc"); // 오브젝트형이면 다 됨 
            list.Add("def");
            foreach (object obj in list)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();
        }

    }
}
