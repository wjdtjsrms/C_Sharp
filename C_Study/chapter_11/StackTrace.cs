using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 453 예외처리의 좋은점
// 예외가 발생한 부분의 소스 코드를 알려준다.
// 실제 일을 하는 코드와 문제를 처리하는 코드를 깔끔하게 분리시킴으로써 코드를 간결하게 한다.
// 동일한 예외가 여러번 일어나도 하나의 catch 구문으로 처리 가능

namespace C_Study.chapter_11
{
    class StackTrace
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                Console.WriteLine(3 / --a);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
