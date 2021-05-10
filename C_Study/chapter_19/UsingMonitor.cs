using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Monitor 클래스로 동기화 하기 page 669
// lock 키워드는 Monitor 클래스의 Enter() Exit() 메소드를 바탕으로 구현되어 있다.
// 까먹고 Exit 실행 안할거고 Enter() Exit() 이 메소드만 쓸거면 그냥 lock 써라
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
            while(loopCount-->0)
            {
                Monitor.Enter(thisLock); // 크리티컬 섹션을 만든다.
                try
                {
                    count++;
                }
                finally
                {
                    Monitor.Exit(thisLock); // 크리티컬 섹션을 제거한다.
                }
                Thread.Sleep(1);
            }
        }
        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                Monitor.Enter(thisLock);
                try
                {
                    count--;
                }
                finally
                {
                    Monitor.Exit(thisLock);
                }
                Thread.Sleep(1);
            }
        }
    }

    class UsingMonitor
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
