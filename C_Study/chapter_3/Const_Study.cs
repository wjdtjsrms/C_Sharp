using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    // 변하지 않는 값 상수
    // page 79
    class Const_Study
    {
        static void Main(String[] args)
        {
            const int MAX_INT = int.MaxValue;
            // const int MIN_INT; 선언과 초기화가 동시에 이루어저야 한다.
            const int MIN_INT = int.MinValue;

           // MAX_INT = -1; 수정 불가
           // MIN_INT = 1;

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);
        }
        

        
    }
}
