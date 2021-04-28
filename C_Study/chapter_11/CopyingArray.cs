using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// page 408 제네릭 프로그래밍, 일반화(generic) 프로그래밍
// 메소드 이름뒤에 <>를 넣어주고 그 사이에 T를 넣으면 T는 형식 매개변수(Type Parameter)가 됩니다.
namespace C_Study.chapter_11
{
    class CopyingArray
    {

        static void CopyArray<T>(T[] source, T[] target)
        {
            for(int i=0;i<source.Length;i++)
            {
                target[i] = source[i];
            }
        }

        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            foreach(int element in target)
            {
                Console.WriteLine(element);
            }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
            string[] target2 = new string[source2.Length];

            CopyArray<string>(source2, target2);

            foreach (string element in target2)
            {
                Console.WriteLine(element);
            }

        }

    }
}
