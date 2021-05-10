using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// page 666 lock 키워드로 동기화 하기
// 스레드들이 순서를 갖춰 자원을 사용하게 하는 것을 동기화(Synchronization)이라고 한다.
// 크리티컬 섹션(Critical Section) 한번에 한 스레드만 사용할 수 있는 코드 영역
// 락을 사용하면 소프트웨어의 성능이 크게 떨어지므로 필요한 곳에서만 사용 할것.
// lock 함수에 매개변수로 this, type 형식, string 형식은 쓰지 말것
// 이거 쓰면 다중 쓰레드의 의미가 많이 퇴색된다. 다른 거 공부해서 다른거 써라
namespace C_Study.chapter_19
{
    class Counter
    {
        const int LOOP_COUNT = 100;

        readonly object thisLock;

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
            while(loopCount-- > 0)
            {
                lock(thisLock)
                {
                    count++;
                }
                Thread.Sleep(1);
            }
        }
        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while(loopCount-- > 0)
            {
                lock (thisLock)
                {
                    count--;
                }
                Thread.Sleep(1);
            }
        }
    }

    class Synchronize
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
