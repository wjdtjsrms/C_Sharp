using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 레코드 객체 비교하기 page 341
// Equals 함수를 자동으로 구현된다.

namespace C_Study.chapter_9
{
    class CTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

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

    class RecordComp
    {
        static void Main(string[] args)
        {

            CTransaction trA = new CTransaction
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            CTransaction trB = new CTransaction
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };
            Console.WriteLine(trA);
            Console.WriteLine(trB);
            Console.WriteLine($"trA equals to trB : {trA.Equals(trB)}"); // 참조하는 주소가 달라서 FAIL

            RTransaction tr1 = new RTransaction
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            RTransaction tr2 = new RTransaction
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine($"tr1 equals to tr2 : {tr1.Equals(tr2)}");
        }
    }
}
