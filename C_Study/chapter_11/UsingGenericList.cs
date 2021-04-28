using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 420 일반화 컬렉션
// object 기반이라 박싱/언박싱이 일어나서 성능의 저하로 이루어짐

namespace C_Study.chapter_11
{
    class UsingGenericList
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); // 일반화 리스트
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
         
            foreach(int element in list)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();

            Queue<int> queue = new Queue<int>(); // 일반화 큐
            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i);
            }
            
            while(queue.Count >0)
            {
                Console.Write(queue.Dequeue());
            }
            Console.WriteLine();


            Stack<int> stack = new Stack<int>(); // 일반화 스택
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();

            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["하나"] = "one";
            dic["둘"] = "two";
            dic["셋"] = "three";
            dic["넷"] = "four";
            dic["다섯"] = "five";

            Console.Write(dic["하나"]);
            Console.Write(dic["둘"]);
            Console.Write(dic["셋"]);
            Console.Write(dic["넷"]);
            Console.Write(dic["다섯"]);

        }
    }
}
