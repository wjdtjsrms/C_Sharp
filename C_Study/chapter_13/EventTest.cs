using System;
using System.Collections.Generic;
using System.Text;

// 이벤트 객체에 일어난 사건 알리기 page 476
// 대리자와의 차이점은 이벤트는 public으로 선언되어있어도 외부에서 직접 사용할 수 없다. 
// 대리자는 외부에서 직접 사용 할 수 있다.
namespace C_Study.chapter_13
{
    delegate void EventHandler(string message); // 대리자를 선언한다. 클래스 안과 밖 원하는 곳에 선언.

    class Mynotifier
    {
        public event EventHandler SomeEvent; // 클래스 내에 선언한 대리자의 인스턴스를 event 한정자로 수색해서 선언
        public void DoSomething(int number)
        {
            int temp = number % 10;

            if(temp != 0 && temp % 3 == 0)
            {
                SomeEvent(String.Format($"{number} : 짝"));

            }
        }
    }

    class EventTest
    {
        static public void MyHandler(string message) // 이벤트 핸들러를 작성한다. 대리자와 일치하는 메소드면 된다.
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Mynotifier notifier = new Mynotifier(); // 클래스의 인스턴스를 생성한다.
            // 무조건 더하기로만 추가한다. =으로 초기화 되는 상황을 예방하기 위해
            notifier.SomeEvent += new EventHandler(MyHandler); // 생성한 객체의 이벤트에 바로 위에서 작성한 이벤트 핸들러를 등록한다.

     
            for(int i=0;i<30;i++)
            {
                notifier.DoSomething(i); // 이벤트가 발생하면 이벤트 핸들러가 호출된다.
            }
        }
    }
}
