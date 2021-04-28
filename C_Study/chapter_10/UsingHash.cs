using System;
using System.Collections;


// hashtable page 387
// 키와 값의 쌍으로 이루어진 데이터
// 배열은 데이터를 저장할 요소의 위치로 인덱스를 사용하는 반면
// 해쉬는 키 데이터를 그대로 사용한다.
// 탐색속도 짱 빠르다. 해싱 알고리즘을 이용하기 때문.
// 근데 필드에서 딕셔너리 쓴다. 이거 오브젝트 타입이라 박싱.언박싱 일어나서 느림

namespace C_Study.chapter_10
{
    class UsingHash
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["하나"] = "one";
            ht["둘"] = "two";
            ht["셋"] = "three";
            ht["넷"] = "four";
            ht["다섯"] = "five";

            ht.Add("여섯", "Six");

            Console.WriteLine(ht["하나"]);
            Console.WriteLine(ht["둘"]);
            Console.WriteLine(ht["셋"]);
            Console.WriteLine(ht["넷"]);
            Console.WriteLine(ht["다섯"]);
        }
    }
}
