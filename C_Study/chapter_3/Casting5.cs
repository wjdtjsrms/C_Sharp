using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    // 문자열을 숫자로, 숫자를 문자열로
    // page 77
    class Casting5
    {
        static void Main(String[] args)
        {
            int a = 123;
            string b = a.ToString(); // object에서 상속받은 ToString() 오버라이드 했다.
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);

            string e = "123456";
            int f = int.Parse(e); // string - > int, float 
            Console.WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g);
            Console.WriteLine(h);
        }
    }
}
