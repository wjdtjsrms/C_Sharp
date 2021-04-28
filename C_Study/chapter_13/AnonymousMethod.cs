using System;
using System.Collections.Generic;
using System.Text;

// 익명 메소드 page 475
// 대리자가 참조할 메소드를 넘겨야하는데 이 메소드가 두 번 다시 사용할 일이 없을때 사용한다.
namespace C_Study.chapter_13
{
    delegate int Compare(int a, int b); // 대리자 delegate, 걍 함수 포인터로 생각하면 편하다.


    class AnonymousMethod
    {
        static void BubbleSort(int[] DataSet, Compare compare)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for(i = 0; i<DataSet.Length;i++)
            {
                for(j=0;j<DataSet.Length - (i+1);j++)
                {
                    if(compare(DataSet[j],DataSet[i]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };
            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, delegate (int a, int b) // 익명 메서드, 대리자와 반환형식, 매개변수 형식이 같아야 한다.
            {
                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            
            
            });

            for(int i=0;i<array.Length;i++)
                Console.Write($"{ array[i]} ");
            Console.WriteLine();

            int[] array2 = { 7,2,8,10,11 };
            Console.WriteLine("Sorting descending...");
            BubbleSort(array, delegate (int a, int b)
            {
                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;


            });

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{ array2[i]} ");
            Console.WriteLine();
        }
    }
}
