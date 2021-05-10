using System;
using System.Security.Permissions;
using System.Threading;

namespace C_Study.chapter_19
{
    // page 660 인터럽트 스레드를 임의로 종료하는 다른 방법 
    // Abort()는 강제로 중단되지만 Thread.Interrupt() 메소드는 스레드가 한참 동작 중인 상태(Running  상태)를 피해
    // waitJoinSleep 상태에 들어갔을때  ThreadInterruptedException 예외를 던져 스레드를 중지시킨다.
    // 최소한 코드가 절대로 중단되면 안되는 작업을 하고 있을때는 중단되지 않는다는 보장을 받을 수 있다.

    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }
        public void KeepAlive()
        {
            try
            {
                Console.WriteLine("Runnig thread isn't gonna be interrupted");
                Thread.SpinWait(100000000); // sleep과 유사하게 스레드를 대기시키지만 running 상태를 유지 하게 한다.

                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");

                    Console.WriteLine("Entering into WaitJoinSleep State...");
                    Thread.Sleep(10); // WaitSleepJoin 상태에 들어가서 interrupt가 가능해진다.
                }
                Console.WriteLine("Count : 0");
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }
    class InterruptingThread
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Starting thread...");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Interrupting thread...");
            t1.Interrupt();

            Console.WriteLine("Wating until thread stops");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
