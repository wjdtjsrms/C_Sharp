using System;
using System.Collections.Generic;
using System.Text;

// page 287
// tuple 여러 필드를 담을 수 있는 구조체, 값형식이다.
// 구조체와는 달리 형식 이름이 없다.
// 필드의 이름을 지정하지 않는 명명되지 않은 튜플(Unnamed Tuple) 차례대로 Item1,Item2 필드에 담는다.
// 필드의 이름을 지정하는 명명된 튜플(Nammed Tuple)
// Unnamed Tuple과 Nammed Tuple의 필드와 수와 형식이 같으면 할당 가능
namespace C_Study.chapter_7
{
    class Tuple
    {
        static void Main(string[] args)
        {
            // 명명되지 않은 튜플
            var a = ("슈퍼맨", 9999);

            // 명명된 튜플
            var b = (Name: "박상현", Age: 17);

            var (name, age) = b; // (var name, var age) = b
            Console.WriteLine($"{name}, {age}");

            var (name2, age2) = ("박문수", 34);
            Console.WriteLine($"{name2}, {age2}");

            // 명명된 튜플 = 명명되지 않은 튜플
            b = a;
            Console.WriteLine($"{b.Name}, {b.Age}");
        }

    }
}
