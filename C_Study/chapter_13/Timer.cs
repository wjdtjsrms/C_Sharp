using System;



namespace C_Study.chapter_13
{

    class MyEvent : EventArgs

    {

        public int height;

        public bool isStart;

        public string Name;

    }

    class MyTimer

    {

        public delegate void Tick(DateTime now);

        public event Tick Ticked;

        public event EventHandler<MyEvent> MyEvent;

        MyEvent e = new MyEvent();

        public void EventAction()

        {

            MyEvent += MyTimer_MyEvent;

        }


        private void MyTimer_MyEvent(object sender, MyEvent e)

        {

            e.height = 50;

            e.isStart = false;

            e.Name = "Select";

            Console.Write($"{ e.height}{e.isStart},{e.Name}");

        }



        public void EventOperate()

        {

            MyEvent?.Invoke(this,e); // 이벤트에 ㅜ들어가 있는 함수들을 실행시켜라

        }



        private int interval;



        public MyTimer(int interval)

        {

            this.interval = interval;

        }

        public void start()

        {

            DateTime before = DateTime.Now;

            while (true)

            {

                DateTime current = DateTime.Now;



                if (before.AddSeconds(interval) < current)

                {

                    Ticked(current);

                    before = current;

                }

            }

        }

    }



    class Timer

    {

        static void TimeEllapsed(DateTime current)

        {

            Console.WriteLine("Time Ellapsed : {0}", current.ToLongTimeString());

        }

        static void Main(string[] args)

        {

            MyTimer timer = new MyTimer(5);

            timer.Ticked += new MyTimer.Tick(TimeEllapsed);

            timer.EventAction();

            timer.MyEvent += Timer_MyEvent;

            timer.EventOperate();

            timer.start();

        }



        private static void Timer_MyEvent(object sender, MyEvent e)

        {

            e.height += 10;

            e.isStart = true;

            e.Name = "";

            Console.WriteLine($" 외부에서 이벤트에 함수 추가된 것{e.height}{e.isStart}{e.Name}");

        }

    }

}