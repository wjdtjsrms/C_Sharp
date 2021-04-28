using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
// page 317 추상 클래스
// 메소드의 구현을 가질 수 있음
// abstract 지정자를 붙이면 구현을 넘길 수 있다.
// 다중 상속 불가

namespace C_Study.chapter_8
{
    

    abstract class AbstractBase
    {
        
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA();  
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.PrivateMethodA()");
            PrivateMethodA();
        }
    }

    class AbstractClass
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }

       
        

    }
}
