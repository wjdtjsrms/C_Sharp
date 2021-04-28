using System;
using System.Collections.Generic;
using System.Text;

// page 209
// 명명된 인수

namespace C_Study.chapter_5
{
    class NamedParameter
    {
        static void PrintProfile(string name,string phone)
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }
        static void Main(string[] args)
        {
            // 전달되는 인자 값을 매개변수 이름을 직접 입력해서 대입
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-987-9876", name: "박지성");
        }
    }
}
