using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 분할 클래스 page 275
// 클래스의 크기가 너무 커질때 사용하면 유효, 필드에서도 좀 쓰나봄

namespace C_Study.chapter_7
{
    partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }

    partial class MyClass // partial 키워드와 이름이 같은 클래스를 써야 한다.
    {
        public void Method3()
        {
            Console.WriteLine("Method3");
        }
        public void Method4()
        {
            Console.WriteLine("Method3");
        }
    }

    class PartialClass
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.Method1();
            myClass.Method2();
            myClass.Method3();
            myClass.Method4();
        }
    }
}
