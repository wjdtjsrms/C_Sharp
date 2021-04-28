using System;
using System.Collections; // 이거 해야 IEnumerator 이거 씀


// page396 Yield 사용법

namespace C_Study.chapter_10
{
    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break; // 코루틴 종료, 코루틴 끝에는 꼭 넣어줄것 안그러면 메모리 차지함
            yield return numbers[3]; // 실행 못함
        }
    }

    class Yield
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach(int i in obj)
            {
                Console.WriteLine(i);
            }
        }
    }
}
