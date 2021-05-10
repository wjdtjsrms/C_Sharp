using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// t1.Abort() 스레드 취소 함수 page 649
// 호출하면 해당 스레드가 실행 중이던 코드에 ThreadAbortException 예외를 던진다.
// 이 예외를 catch 하는 함수가 있다면 이 예외를 처리하고 finally 블록까지 실행한 후 스레드는 완전히 종료된다.
// 이 처리 시간을 염두에 두어야 한다. 왠만하면 쓰지 말것.
// .net 5.0 부터는 쓰지도 못한다. 진작에 알려주지 젠장.

namespace C_Study.chapter_19
{
    class SideTest
    {
        int count;

        public SideTest(int count)
        {
            this.count = count;
        }
        public void KeepAlive()
        {
            try
            {
                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);

                }
                Console.WriteLine("Count : 0");
            }
            catch (ThreadAbortException e) // Abort() 함수를 호출하면 이 예외를 던진다.
            {
                Console.WriteLine(e);
                Thread.ResetAbort();
            }
            finally
            {
                Console.WriteLine("Clearing resource");
            }
        }
    }

    class AbortingThread
    {
       static void Main(string[] args)
        {
            SideTest task = new SideTest(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Starting thread");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Aborting thread...");
            t1.Abort();

            Console.WriteLine("Wating until thread stops");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
