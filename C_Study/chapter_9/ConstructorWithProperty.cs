using System;
using System.Collections.Generic;
using System.Text;

// 프로퍼티를 이용한 초기화 page 333

namespace C_Study.chapter_9
{

    class BirthdayInfo
    {
        public string Name
        {
            get;
            set;
        }

        public DateTime Birthday
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class ConstructorWithProperty
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo() // ,자로 나눈다. 인텔리전스로 자동완성되는거 너무 편해
            {
                Name = "서현",
                Birthday = new DateTime(1991, 6, 28)
            };
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }

    }
}
