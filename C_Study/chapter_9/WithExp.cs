using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// with를 이용한 레코드 복사 page 340
// 컴파일러는 레코드 형식을 위한 복사 생성자를 자동으로 작성합니다.

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

    class WithExp
    {
        static void Main(string[] args)
        {

                RTransaction tr1 = new RTransaction
                {
                    From = "Alice",
                    To = "Bob",
                    Amount = 100
                };

            RTransaction tr2 = tr1 with { To = "Charlie" }; // with 연산자를 프로퍼티 입력을 반복하지 않아 편리하다.
            RTransaction tr3 = tr2 with { From = "Dave", Amount = 30 };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);

        }
    }
}
