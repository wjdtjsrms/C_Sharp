using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 440 예외 던지기 예제
// throw는 statement(문장) 이 아닌 expression(식)으로 사용될수 있다.
namespace C_Study.chapter_12
{
    class ThrowExpression
    {
        static void Main(string[] args)
        {
            try
            {
                int? a = null;
                int b = a ?? throw new ArgumentNullException(); // 식으로써 thorw 구문을 사용
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }

            try
            {
                int[] array = new int[] { 1, 2, 3 };
                int index = 4;
                int value = array[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()]; // 삼항 연산자
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
