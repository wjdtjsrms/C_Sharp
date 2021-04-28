using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    class FloatingPoint
    {
        // 사용시 Main()으로 교체
        // page 60
        static void Main(String[] args)
        {
            // 단일 정밀도 부동 소수점 형식 (7개의 자릿수)
            // 부호 비트 1비트, 지수부 8비트, 가수부 23비트 총 32비트
            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f; // 뒤에 f를 붙인다.
            Console.WriteLine(a);

            // 복수 정밀도 부동 소수점 형식(15~16 개의 자릿수) 총 64비트
            double b = 3.1415_9265_3589_7932_3846_2643_3832_79;
            Console.WriteLine(b);

            // 29자리 데이터를 표현 할 수 있는 소수 형식 총 128비트
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m; // 뒤에 m을 붙인다.
            Console.WriteLine(c);
        }
    }
}
