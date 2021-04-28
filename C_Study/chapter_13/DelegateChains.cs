using System;
using System.Collections.Generic;
using System.Text;

// 대리자 체인 page 469

namespace C_Study.chapter_13
{
    delegate void Notify(string message);

    class Notifier // 대리자의 인스턴스를 가지는 클래스 선언
    {
        public Notify EventOccured;
    }


    class EventListner
    {
        private string name;
        public EventListner(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappend : {message}");
        }
    }
    class DelegateChains
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();

            EventListner listner1 = new EventListner("Listner");
            EventListner listner2 = new EventListner("Listner2");
            EventListner listner3 = new EventListner("Listner3");

            notifier.EventOccured += listner1.SomethingHappend; // += 대리자 체인 생성
            notifier.EventOccured += new Notify(listner2.SomethingHappend) + new Notify(listner3.SomethingHappend); // +, = 대리자 체인 생성

            notifier.EventOccured -= listner2.SomethingHappend; // - 대리 체인 끊기

            // Delegate.Combine , Delegate.Remove  으로 해도 됨



            notifier.EventOccured("You've got mail"); // 대리자 함수 호출

            Console.WriteLine();
        }
    }
}
