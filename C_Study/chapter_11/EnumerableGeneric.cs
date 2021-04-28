using System;
using System.Collections;
using System.Collections.Generic;


// foreach를 사용할 수 있는 일반화 클래스 page 425
// IEunmerable<T> 인터페이스를 상속받아 IEnumerator<T>를 리턴하는 함수를 구현하다.
// 근데 IEnumerator는 또 여러가지 메소드를 구현해야 하는 인터페이스다. 어후 힘들어.

namespace C_Study.chapter_11
{

    class MyList<T> :IEnumerable<T>,IEnumerator<T>
    {
        private T[] array;
        int position = -1;

        public MyList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get 
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }

        // IEunmerable<T> 인터페이스의 GetEnumerator()의 구현
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        // IEunmerable 인터페이스(IEunmerable<T>얘가 상속받음)의 GetEnumerator()의 구현
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public T Current
        {
            get { return array[position]; }
        }

        object IEnumerator.Current
        {
            get { return array[position]; }
        }

        public bool MoveNext()
        {
            if(position == array.Length -1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        public void Dispose()
        {

        }
    }

    class EnumerableGeneric
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach(string str in str_list)
            {
                Console.Write(str);
            }

            Console.WriteLine();


            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;
            int_list[4] = 4;

            foreach (int num in int_list)
            {
                Console.Write(num);
            }

            Console.WriteLine();


        }

    }
}
