using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    // page 87
    class NullAble
    {
        static void Main(string[] args)
        {
            // 참조 타입은 null 이 대입이 가능해서 굳이 이거 안써도됨
            // 값 형식은 원래 null을 가질 수 없다. 

            int? a = null; // Nullable Type
            // int b = null; 대입이 안된다.

            Console.WriteLine(a.HasValue); // 값을 가지고 있는지를 bool형으로 반환
            Console.WriteLine(a != null);
            Console.WriteLine(a.GetValueOrDefault()); // 할당된 값이 없으므로 int의 default 값
            Console.WriteLine();

            a = 3;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.GetValueOrDefault()); // 할당된 값이 나온다.
            Console.WriteLine(a.Value);

        }
    }
}
