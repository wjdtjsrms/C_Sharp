using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 506 식으로 이루어지는 멤버 Expression - Bodied Member
// 속성(인덱서) ,생성자, 종료자는 본문이 중괄호로 이루어져 있다.
// 이러한 멤버의 본문을 식만으로 구현할수도 있다.
// 멤버 => 식 형태로 작성한다.

namespace C_Study.chapter_14
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach(var s in list)
            {
                Console.WriteLine(s);
            }
        }

        public FriendList() => Console.WriteLine("FriendList()");
        ~FriendList() => Console.WriteLine("~FriendList()");

        // public int Capacity => list.Capacity // 읽기 전용

        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }

        // public string this[int index] => list[index] // 읽기 전용
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }

    class ExpressionBodieMember
    {
        static void Main(string[] args)
        {
            FriendList obj = new FriendList();
            obj.Add("Eeny");
            obj.Add("Meeny");
            obj.Add("Miny");
            obj.Add("Eney");
            obj.PrintAll();
            
            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine($"{obj[0]}");
            obj[0] = "Moe";
            obj.PrintAll();
        }

    }
}
