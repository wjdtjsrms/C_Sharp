using System;
using System.Collections;

// page 398 foreach가 가능한 객체 만들기
// IEunumerable을 상속하는 형식만 지원가능
// IEnumerator의 요구사항을 충족시켜 스스로 IEnumerator가 된다.
// 그 후 foreach를 사용하기 위해 필요한 IEunumerable이 요구하는, IEnumerator를 반환할때 스스로(this)를 반환한다.

// IEnumerable  : 해당 객체가 배열 하나의 원소 배치를 가지고 있을때  foreach로 하나씩 나열 할 수 있도록 만들어 주는것
// IEnumrator : 해당 객체가 배열 여럿의 원소배치를 가지고 있을 때 foreach로 원소 하나씩 나열할 수 있도록 만들어 주는 것

namespace C_Study.chapter_10
{
    class MyList :IEnumerable,IEnumerator
    {
        private int[] array;
        int position = -1; // 컬렉션의 현재 위치를 다루는 변수, -1에서 시작해야 0번째 인덱스를 가리킨다.

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
                if(index>=array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
            
        }

        #region IEnumerator의 멤버

        // IEnumerator의 멤버
        // 컬렉션의 현재 요소를 반환한다.
        public object Current
        {
            get
            {
                return array[position];
            }
        }

        // IEnumerator의 멤버
        // 다음 요소로 이동한다. 끝을 지나가면 false, 이동이 성공하면 true를 반환
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

        // IEnumerator의 멤버
        //  요소의 위치를 첫요소의 앞으로 이동
        public void Reset()
        {
            position = -1;
        }
        #endregion


        // IEunumerable의 멤버
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }


    class Enumerable
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();

            for (int i = 0; i < 5; i++)
            {
                list[i] = i;
            }
            foreach(int e in list) // good good!!
            {
                Console.WriteLine(e);
            }
        }

    }
}
