using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Study.chapter_9
{

    class NameCard
    {
        private int age;
        private string name;

        public int Age { get; set; }
        public string Name { get; set; }
    }


    class _9_1
    {
        static void Main(string[] args)
        {
            NameCard Mycard = new NameCard();
            Mycard.Age = 24;
            Mycard.Name = "상현";

            Console.WriteLine($"나이: {Mycard.Age}");
            Console.WriteLine($"나이: {Mycard.Name}");
        }
    }
}
