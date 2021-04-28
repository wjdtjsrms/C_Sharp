using System;
using System.Collections.Generic;
using System.Text;

// page 483
namespace C_Study.chapter_13
{
    delegate void MyDelegate(int a);

    class Market
    {
        public event MyDelegate CustomerEvent; // 클래스 외부에서 사용 불가
        public void BuySomething(int CustomerNo)
        {
            if(CustomerNo == 30)
            {
                CustomerEvent(CustomerNo);
            }
        }
    }

    class _13_2
    {
        static void MyHandler(int a)
        {
            Console.WriteLine($"축하합니다! {a}번째 고객 이벤트에 당첨되셨습니다.");
        }

        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDelegate(MyHandler);

            for(int customerNo = 0; customerNo< 100; customerNo++)
            {
                market.BuySomething(customerNo);
            }

        }
    }
}
