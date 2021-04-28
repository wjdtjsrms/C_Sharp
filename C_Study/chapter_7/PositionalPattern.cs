﻿using System;
using System.Collections.Generic;
using System.Text;

// 분해자를 구현하고 있는 객체를 분해한 결과를 switch문이나 식의 분기조건에 활용할수 있다.
// 패턴 매칭 (Positional Pattern Matching)
namespace C_Study.chapter_7
{
    class PositionalPattern
    {

        private static double GetDiscountRate(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2,
                ("학생", _) => 0.1,
                ("일반", int n) when n < 18 => 0.1,
                ("일반", _) => 0.05,
                _ => 0,
            };
        }


        static void Main(string[] args)
        {
            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);
            var charlie = (job: "일반", age: 15);
            var dave = (job: "일반", age: 21);

            Console.WriteLine($"alice : {GetDiscountRate(alice)}");
            Console.WriteLine($"bob   : {GetDiscountRate(bob)}");
            Console.WriteLine($"charlie : {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave  : {GetDiscountRate(dave)}");
        }


    }
}
