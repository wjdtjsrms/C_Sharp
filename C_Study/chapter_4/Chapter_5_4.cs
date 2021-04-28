using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study.chapter_4
{
    //page 182
    class Chapter_5_4
    {    
        static void Main(String[] args)
        {
            int input;
            while(true)
            {
                Console.Write("반복 횟수를 입력하세요: ");
                input = int.Parse(Console.ReadLine());
                if(input > 0)
                {
                    for(int i=0; i< input;i++)
                    {
                        for(int j=0; j<=i;j++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("0보다 작거나 같은 수는 입력 할 수 없습니다.");
                    continue;
                }
            }
           
        }
    }
}
