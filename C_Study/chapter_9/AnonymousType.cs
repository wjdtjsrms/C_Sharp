using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 무명형식 page 345

namespace C_Study.chapter_9
{
    class AnonymousType
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박상현", Age = 123 }; // 대입 후 수정불가
            Console.WriteLine($"{a.Name}, {a.Age}");

            var b = new { subject = "수학 ", Scores = new int[] { 90, 80, 70, 60 } };
            Console.Write($"{ b.subject}");
            foreach(var score in b.Scores)
                Console.Write($"{ score} ");

            Console.WriteLine();
        }
    }
}
