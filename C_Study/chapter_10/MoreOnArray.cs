using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 366 배열 활용법
namespace C_Study.chapter_10
{
    class MoreOnArray
    {
        private static bool CheckPassed(int score)
        {
            return score > 60;
        }
        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };
            foreach(int score in scores)
            {
                Console.Write($"{score} ");
            }
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print)); // Action<매개변수,매개변수> 반환형 없음
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {scores.Rank}"); // 배열의 차원수 반환

            Console.WriteLine($"Binary Search: 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}"); // 이진 탐색을 실시 합니다.

            Console.WriteLine($"Linear Search : 90 is at " + $"{Array.IndexOf(scores, 90)}"); // 선형 탐색을 실시 합니다.

            Console.WriteLine($"Everyone passed? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}"); // 배열과 함께 조건을 검사하는 메소드를 매개변수를 받습니다.

            int index = Array.FindIndex<int>(scores, (score) => score < 60); // 특정 조건에 부합하는 메소드를 매개변수를 받습니다.

            scores[index] = 61;
            Console.WriteLine($"Everyone passed? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            Console.WriteLine("Old length of scores : " + $"{scores.GetLength(0)}"); // 특정 차원의 길이를 반환

            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"New length of scores : {scores.Length}"); // 길이를 10으로 재조정

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3); // scores 의 0번째 부터 / sliced 의 0번째로 / 3개 보낸다.
            Array.ForEach<int>(sliced, new Action<int>(Print));
            Console.WriteLine();

        }
    }
}
