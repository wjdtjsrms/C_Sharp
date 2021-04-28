using System;
using System.Collections.Generic;
using System.Text;

// 일반화 대리자 page 465
// delegate int compare<T>(T a, T b)
// 이해 불가

namespace C_Study.chapter_13
{
    delegate int Compare<T>(T a, T b);

    class GenericDelegate
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T> // where 키워드 형식 매개변수 T에 제한을 건다.
        {
            return a.CompareTo(b);
        }
        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet,Compare<T> compare)
        {
            int i = 0;
            int j = 0;
            T temp;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (compare(DataSet[j], DataSet[j + 1]) > 0)
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
            BubbleSort<int>(array, new Compare<int>(AscendCompare)); // 대리자 대입

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{ array[i]} ");
            Console.WriteLine();

            string[] array2 = { "abc","def","ghi","jkl","mno" };
            Console.WriteLine("Sorting descending...");
            BubbleSort<string>(array2, new Compare<string>(DescendCompare)); // 대리자 대입

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{ array2[i]} ");
            Console.WriteLine();
        }
    }
}
