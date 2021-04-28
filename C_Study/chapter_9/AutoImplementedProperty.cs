using System;
using System.Collections.Generic;
using System.Text;

// 자동 구현 프로퍼티
// page 328

namespace C_Study.chapter_9
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown"; // 디폴트값 설정
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class AutoImplementedProperty
    {
        static void Main()
        {
            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);
            Console.WriteLine();

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}
