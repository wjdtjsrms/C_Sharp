using System;
using System.Collections.Generic;
using System.Text;

// 초기화 전용 자동 구현 프로퍼티 page 336
// 한번 초기화 하면 값을 바꿀수 없다.

namespace C_Study.chapter_9
{
    class Trnasaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }


        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }


    class InitOnly
    {
        static void Main(string[] args)
        {
            Trnasaction tr1 = new Trnasaction { From = "Alice", To = "Bob", Amount = 100 };

            Trnasaction tr2 = new Trnasaction { From = "Bob", To = "Charlie", Amount = 50 };

            Trnasaction tr3 = new Trnasaction { From = "Charlie", To = "Alice", Amount = 50 };

            // tr2.From = "No"; 실행 안됨! 대입 불가!

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);
        }
    }
}
