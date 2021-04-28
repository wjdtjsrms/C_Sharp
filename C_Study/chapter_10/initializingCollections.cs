using System;
using System.Collections;

// page 390 컬렉션을 초기화 할수 있는 방법
// 배열을 이용해서 초기화 할수 있다.
// 컬렉션 초기자 {} 는 IEnumerabled 인터페이스와 add() 메소드를 구현하는 콜렉션만 지원한다.
// stack 이랑 queue는 지원안해서 안되지롱

namespace C_Study.chapter_10
{
    class initializingCollections
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr); // 배열을 이용한 컬렉션 초기화
            foreach(object item in list)
            {
                Console.WriteLine($"ArrayList : {item}");
            }
            Console.WriteLine();

            Stack stack = new Stack(arr);
            foreach (object item in stack)
            {
                Console.WriteLine($"Stack : {item}");
            }
            Console.WriteLine();

            Queue queue = new Queue(arr);
            foreach (object item in queue)
            {
                Console.WriteLine($"Queue : {item}");
            }
            Console.WriteLine();

            ArrayList list2 = new ArrayList { 11, 22, 33 }; // 컬렉션 초기자를 이용한 컬렉션 초기화
            foreach (object item in list2)
            {
                Console.WriteLine($"ArrayList2 : {item}");
            }
            Console.WriteLine();

            Hashtable ht = new Hashtable() // 딕셔너리 초기자
            {
                ["하나"] = 1,
                ["둘"] = 2,
                ["셋"] = 3
            };
            Console.WriteLine(ht["하나"]);
            Console.WriteLine(ht["둘"]);
            Console.WriteLine(ht["셋"]);
            Console.WriteLine();
            
        }
    }
}
