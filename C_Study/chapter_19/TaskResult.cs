using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 684 코드의 비동기 실행 결과를 주는 Task<TResult> 클래스
// 인수를 입력받은 두 수 사이에 존재하는 모든 소수 목록을 반환하는 프로그램
namespace C_Study.chapter_19
{
    class TaskResult
    {
        static bool IsPrime(long number)
        {
            if(number < 2)
            {
                return false;
            }

            if(number % 2 ==0 && number != 2)
            {
                return false;
            }
            for(long i = 2; i < number; i++)
            {
                if(number % i ==0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            long from = 0; // 시작 숫자
            long to = 100000; // 목표 숫자
            int taskCount = 5; // 사용할 테스크 갯수

            // object형을 받아서 List<long> 형을 반환
            Func<object, List<long>> FindPrimeFunc =
                (objRange) =>
                {
                    long[] range = objRange as long[];
                    List<long> found = new List<long>();

                    for (long i = range[0]; i < range[1]; i++)
                    {
                        if (IsPrime(i))
                        {
                            found.Add(i);
                        }
                    }
                    return found;
                };

            Task<List<long>>[] tasks = new Task<List<long>>[taskCount];
            long currentFrom = from;
            long currentTo = to / tasks.Length;

            for(int i =0; i<tasks.Length;i++)
            {
                Console.WriteLine($"Task[{i}] : {currentFrom} ~ {currentTo}");
                tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[] { currentFrom, currentTo });
                currentFrom = currentTo + 1;

                if(i== tasks.Length - 2)
                {
                    currentTo = to;
                }
                else
                {
                    currentTo = currentTo + (to / tasks.Length);
                }
            }

            Console.WriteLine("Please press enter to start...");
            Console.ReadLine();
            Console.WriteLine("Started...");

            DateTime startTime = DateTime.Now;

            foreach(Task<List<long>> task in tasks)
            {
                task.Start();
            }

            List<long> total = new List<long>();

            foreach(Task<List<long>> task in tasks)
            {
                task.Wait();
                total.AddRange(task.Result.ToArray()); // result 사용
            }
            DateTime endTime = DateTime.Now;

            TimeSpan elapsed = endTime - startTime;

            Console.WriteLine($"Prime number count between {from} and {to} : {total.Count}");
            Console.WriteLine($"Elapsed time : {elapsed}");

        }
    }
}
