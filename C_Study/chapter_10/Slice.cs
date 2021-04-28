using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 371 배열 슬라이스

namespace C_Study.chapter_10
{
    class Slice
    {
        static void PrintArray(System.Array array)
        {
            foreach (var e in array)
            {
                Console.Write(e);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            char[] array = new char['Z' - 'A' + 1];
            for(int i=0;i<array.Length;i++)
            {
                array[i] = (char)('A' + i); // 'A'~'Z'까지 입력
            }

            PrintArray(array[..]); // 0번째 부터 끝까지
            PrintArray(array[5..]); // 5번째부터 끝까지

            Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]);

            Index last = ^0;
            Range range_5_last = 5..last; // Range를 생성할 때 리터럴과 index 객체를 함께 사용할수 있습니다.
            PrintArray(array[range_5_last]);


            PrintArray(array[^4..^1]); // 끝에서 4번째부터 끝에서 2번째까지
        }
    }
}
