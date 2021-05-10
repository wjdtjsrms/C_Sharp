using System;
using System.Threading;

// page 655 스레드의 일생과 상태 변화

namespace C_Study.chapter_19
{
    class UsingThreadState
    {
        private static void PrintThreadState(ThreadState state)
        {
            Console.WriteLine($"{state,-16} : {(int)state,-8} {Convert.ToString((int)state,2)}");

        }

        static void Main(string[] args)
        {
            // 스레드가 시작하여 동작 중인 상태를 나타냅니다. Unstarted 상태의 스레드를 Thread.Start() 메소드를 통해 이 상태로 만들수 있다.
            PrintThreadState(ThreadState.Running);

            PrintThreadState(ThreadState.StopRequested);

            PrintThreadState(ThreadState.SuspendRequested);

            // 스레드가 백그라운드로 작동하고 있음을 나타낸다. 포어 그라운드 (Foreground) 스레드는 하나라도 살아 있는 한 프로세스가 죽지 않는다.
            // 하지만 백그라운드 스레드는 하나가 아니라 열개가 살아 있어도 프레세스가 죽고 사는것에 영향을 끼치지 않는다. 
            // 다만 프로세스가 죽으면 백그라운드 스레드도 모두 죽는다.
            // Thread.IsBackground 속성에 true 값을 입력함으로써 스레드를 이 상태로 바꾼다.
            PrintThreadState(ThreadState.Background);

            // 스레드 객체를 생성한 후 Thread.Start() 메소드가 호출 되기 전의 상태
            PrintThreadState(ThreadState.Unstarted);

            // 중지된 스레드의 상태를 나타낸다. Abort() 메소드를 호출하거나 스레드가 실행 중인 메소드가 종료되면 이 상태가 된다.
            PrintThreadState(ThreadState.Stopped);

            // 스레드가 볼록(Block)된 상태를 나타낸다. Monitor.Enter(), Thread.Sleep() 또는 Thread.Join() 메소드를 호출하면 이 상태가 된다.
            // 대기 상태 반응이 조금 더 빠르다.
            PrintThreadState(ThreadState.WaitSleepJoin);
            
            // 스레드의 일시 중단 상태를 나타낸다. Thread.Suspend () 메소드를 통해 이 상태로 만들며
            // Thread.Resume() 메소드를 통해 다시 Running 상태로 만든다. 
            // 취침 상태 조금 반응이 느리다.
            PrintThreadState(ThreadState.Suspended);

            PrintThreadState(ThreadState.AbortRequested);

            // 스레드가 취소된 상태, Thread.Abort() 메소드를 호출하면 이 상태가 된다.
            // Aborted 상태가 된 스레드는 다시 stopped 상태로 전환되어 완전히 중지된다.
            PrintThreadState(ThreadState.Aborted);

            PrintThreadState(ThreadState.Aborted | ThreadState.Stopped);
        }

    }
}
