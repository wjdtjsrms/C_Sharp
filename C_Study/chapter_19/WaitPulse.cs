using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Monitor.wait() 과 Monitor.Pulse()로 하는 저수준 동기화 page 675
// Wait()과 Pulse()로 더 섬세하게 멀티 스레드 간의 동기화를 가능하게 해준다.
// 단 반드시 lock 블록 안에서 호출해야 한다. 안 그러면 SynchronizationLockException이 예외를 호출함 

namespace C_Study.chapter_19
{
    class Counter
    {
        const int LOOP_COUNT = 100;
        readonly object thisLock;
        bool lockedCount = false;

        private int count;
        public int Count
        {
            get { return count; }
        }
        public Counter()
        {
            thisLock = new object();
            count = 0;
        }

        public void Increase()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
               lock(thisLock)
                {
                    while(count>0 ||lockedCount == true)
                    {
                        Monitor.Wait(thisLock);
                    }

                    lockedCount = true;
                    count++;
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                }
            }
        }
        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count < 0 || lockedCount == true)
                    {
                        Monitor.Wait(thisLock);
                    }

                    lockedCount = true;
                    count--;
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                }
            }
        }
    }

    class WaitPulse
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread incThread = new Thread(new ThreadStart(counter.Increase));
            Thread decThread = new Thread(new ThreadStart(counter.Decrease));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);
        }
    }
}
