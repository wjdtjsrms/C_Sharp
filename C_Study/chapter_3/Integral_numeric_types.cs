using System;

namespace C_Study
{
    class Integral_numeric_types
    {
        // 사용시 Main()으로 교체
        // 정수 형식 예제
        // page 49
        static void Main(String[] args)
        {
            sbyte a = -10; // -128 ~ 127
            byte b = 40; // 0~ 255

            // 문자열 보간
            Console.WriteLine($"a = {a},b = {b}");
            // 문자열 보간 삼항 연산자
            bool boo = true;
            Console.WriteLine($"결과는 {(boo ? "참" : "거짓")}이다.");

            short c = -30000; // -32,798 ~ 32,767
            ushort d = 60000; // 0 ~ 65,535

            Console.WriteLine($"c={c}, d={d}");

            // 큰자리를 나타낼때는 _기호로 구분한다.
            int e = -1000_0000; // –2,147,483,648 ~ 2,147,483,647
            uint f = 3_0000_0000; // 0 ~ 4,294,967,295

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000; // –9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
            ulong h = 200_0000_0000_0000_0000; // 0 ~ 18,446,744,073,709,551,615
            Console.WriteLine($"g={g}, h={h}");


        }
    }
}
