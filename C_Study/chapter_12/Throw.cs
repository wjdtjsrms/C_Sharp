using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 예외 던지기 page 439
// throw로 예외를 던진다. catch로 잡는다.
// 모든 예외는 System.Exception으로부터 파생되었다.


namespace C_Study.chapter_12
{
    class Throw
    {
        static void Dosomething(int arg)
        {
            if (arg < 10)
            {
                Console.WriteLine($"arg : {arg}");
            }
            // 예외를 던졌지만 Dosomething() 메소드 안에는 이 예외를 처리 할 수 있는 코드가 없다.
            // 이 예외는 메소드의 호출자에게 던져집니다.
            else throw new Exception("arg가 10보다 큽니다.");
        }
        static void Main(string[] args)
        {
            try
            {
                Dosomething(1);
                Dosomething(3);
                Dosomething(5);
                Dosomething(9);
                Dosomething(11);
                Dosomething(13); // 위의 행에서 예외가 발생되어 실행되지 않는다.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
