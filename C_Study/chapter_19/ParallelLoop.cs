using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 688 손쉬운 병령 처리를 가능케 하는 Parallel 클래스
// Task<TResult>를 이용해 직접 구현한 병렬처리를 더 쉽게 구현시켜준다.
// 메소드를 병령로 처리할때 몇 개의 스레드를 사용할지는 Parallel 클래스가 내부적으로 판단하여 최적화 합니다.

namespace C_Study.chapter_19
{
    class ParallelLoop
    {
        static bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }

            if (number % 2 == 0 && number != 2)
            {
                return false;
            }
            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            long from = 0;
            long to = 100000;

            Console.WriteLine("Please press enter to start...");
            Console.ReadLine();
            Console.WriteLine("Started...");

            DateTime startTime = DateTime.Now;
            List<long> total = new List<long>();

            // 무척 마음에 든다.
            Parallel.For(from, to, (long i) =>
              {
                  if(IsPrime(i))
                  {
                      lock(total)
                      {
                          total.Add(i);
                      }
                  }
              });

            DateTime endTime = DateTime.Now;

            TimeSpan elapsed = endTime - startTime;

            Console.WriteLine($"Prime number count between {from} and {to} : {total.Count}");
            Console.WriteLine($"Elapsed time : {elapsed}");
        }
    }
}
