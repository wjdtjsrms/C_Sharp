using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 0 0 2 2 0

namespace C_Study
{
    class Algo4
    {
        static void Main(string[] args)
        {
            int[] temps = { 5, 8, 3, 6, 9 }; // 걸린 자리 찾기
            int[] values= check(temps);
            foreach(int i in values)
            {
                Console.Write($"{i}, ");
            }
        }

        static int[] check (int[] height)
        {
            int[] nums = new int[height.Length]; // 결과값을 저장할 변수

            for(int i=0;i< height.Length;i++) // 오른쪽부터 비교할 숫자를 고른다.
            {
                for (int j = i; j > 0;j--) // 현재 위치부터 왼쪽으로 탐색을 시작한다.
                {                   
                    if (height[i] < height[j-1]) // 만약 왼쪽으로 가는 도중 자신보다 큰 수를 만난다면
                    {
                        // 자신보다 큰 수의 위치를 기록하고 루프를 종료한다.
                        nums[i] = (j - 1) + 1; // 0 1 2 3 4 번째를 1 2 3 4 5 순서로 바꾸었다.
                        break;
                    }
                    nums[i] = 0; // 만약 자신보다 큰 수를 찾지 못했다면 0을 대입한다.
                }
            }
            return nums; // 결과값을 리턴한다.
        }
    }
}
