using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 361 system.index 기능
// ^0 ^1 역순으로 배열에 접근한다

namespace C_Study.chapter_10
{
    class ArrarySample
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[^2] = 90; // 배열의 마지막 -1 (3)
            scores[^1] = 34; // 배열의 마지막 (4)
            // ^0 = array.Lenth

            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
