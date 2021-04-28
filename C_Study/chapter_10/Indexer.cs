using System;
using System.Collections;

// page 394 인덱서
// 인덱서는 인덱스를 통해 객체 내의 데이터에 접근하게 해준다.

namespace C_Study.chapter_10
{
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index >= array.Length) // 하나 넘어가면
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }


    class Indexer
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for(int i=0;i<5;i++)
            {
                list[i] = i;
            }
            for(int i=0;i< list.Length;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
