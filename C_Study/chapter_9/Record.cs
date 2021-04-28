using System;
using System.Collections.Generic;
using System.Text;

// 레코드 page 339
// 불변 객체는 데이터 복사와 비교가 많이 이루어진다. 레코드는 이 두가지 연산을 편리하게 수행할수 있게 한다.
// 레코드 형식은 값 형식처럼 다룰 수 있는 불변 참조 형식

namespace C_Study.chapter_9
{
    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    class Record
    {
        static void Main()
        {
            RTransaction tr1 = new RTransaction
            {
                From = "Alice", To = "Bob", Amount = 100
            };

            RTransaction tr2 = new RTransaction
            {
                From = "Alice", To = "Charlie", Amount = 100
            };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
        }
    }
}
