using System;
using System.Threading;

// page 646 프로세스와 스레드

// 프로세스란 실행 파일(.exe)이 실행되어 메모리에 적재된 인스턴스이다.
// ex : word.exe 가 실행파일이라면 이 실행 파일에 담겨 있는 데이터와 코드가 메모리에 적재되어 동작하는 것이 프로세스

// 프로세스도 한번에 여러가지 작업을 한다.
// ex : 워드에서 우리가 글을 쓰면 워드는 글 쓰는것을 방해하지 않고 문법 검사를 한다.

// 프로세스는 반드시 하나 이상의 스레드(Thread)로 구성되는데 스레드는 운영체제가 cpu 시간을 할당하는 기본단위이다.

// 멀티 쓰레드의 장점
// 1. 응답성을 높일수 있다. 사용자와의 대화를 위한 스레드를 추가한다면 파일 복사를 하면서도 사용자로부터 명령을 받을 수 있다.
// 2. 자원공유가 쉽다. 멀티 스레드 방식에는 그저 스레드끼리 코드 내의 변수를 같이 사용하는 것만으로도 데이터 교환을 할 수 있다.
// 3. 경제적이다. 프로세스를 띄우기 위해 메모리와 자원을 할당하는 작업은 비용이 비싼데, 스레드를 띄울 때는 이미 프로세스에 할당된 자원을 그대로 사용하므로 경제적이다.

// 멀티 쓰레드의 단점
// 1. 구현이 복잡하다. 디버깅이 어렵다.
// 2. 소프트웨어 안전성을 악화시킬 수 있다. 자식 스레드 중 하나가 생기면 전체 프로세스에 영향을 준다. 멀티 프로세스 기반은 그냥 프로세스 하나 죽는것으로 끝난다
// 3. 과용하면 성능이 저하될 수 있다. 스레드가 cpu를 사용하기 위해서는 작업 간 전환을 해야 하는데 비용이 비싸다. 많은 쓰레드가 너무 많이 전환을 하면 오히려 성능이 떨어진다.

// 프로세스는 배 쓰레드는 선원이라고 생각하면 쉽다.

namespace C_Study.chapter_19

{
    class BasicThread
    {
        static void Dosomething()
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); // 인수만큼 CPU 사용을 멈춘다. 이때 단위는 밀리초이다.
            }
        }

        static void Main(string[] args)
        {
            // Thread 인스턴스를 생성한다. 인수로 스레드가 실행할 메소드를 넘긴다.
            Thread t1 = new Thread(new ThreadStart(Dosomething));

            Console.WriteLine("Starting thread");
            // 스레드 시작, 실제로 메모리에 적재한다.
            // 메인 스레드에서 분기된다.
            t1.Start(); 
            for(int i=0;i<5;i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(10); 
            }
         
            Console.WriteLine("Wating until thread stops...");
            // 스레드가 끝날 때까지 기달린다. 스레드의 실행이 끝나면 반환되어 다음 코드를 실행한다.
            // 반환되고 나면 프로그램의 흐름은 다시 메인 스레드 하나로 합쳐진다.
            t1.Join(); 

            Console.WriteLine("Finished");
        }
    }
}
