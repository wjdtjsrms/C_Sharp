using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 692 async 한정자와 await 연산자로만드는 비동기 코드
// async 한정자는 메소드, 이벤트, 테스크, 람다식 등을 수식함으로써 컴파일러가 이들을 호출하는 코드를 만날때
// 호출 결과를 기다리지 않고 바로 다음 코드로 이동한다.
// 한정하는 메소드는 반환 형식이 Task(),Task<TResult>, void 이어야만 한다.
// 호출자에 await 연산자를 만나지 못하면 호출자에게 제어를 돌려주지 않으므로 그 메소드/테스크 동기적으로 실행된다.

namespace C_Study.chapter_19
{
    class Async
    {
        async static private void MyMethodAsync(int count)
        {
            Console.WriteLine("C");
            Console.WriteLine("D");

            // await 연산자를 만나는 곳에서 호출자(여기서는 Caller)에게 제어를 돌려준다.
            await Task.Run(async () =>
            {
                for(int i=1;i<=count;i++)
                {
                    Console.WriteLine($"{i}/{count} ...");

                    // 입력받은 시간이 지나면 Task객체를 반환한다. yield return new WaitForSeconds() 같은건가?
                    // Thread.sleep과 달리 스레드를 블록시키지 않는다. Thread.sleep을 호출하면 UI가 sleep이 반환되기 전까지 사용자에게 응답하지 못한다.
                    // Task.Delay는 메소드의 반환여부와 달리 UI가 사용자에게 잘 응답한다.
                    await Task.Delay(1000);
                }              
            });

            Console.WriteLine("G");
            Console.WriteLine("H");
        }
        static void Caller()
        {
            Console.WriteLine("A");
            Console.WriteLine("B");

            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");

        }
        static void Main(string[] args)
        {
            Caller();

            Console.ReadLine();
        }
    }
}
