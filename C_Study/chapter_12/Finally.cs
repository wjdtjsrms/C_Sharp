using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 444 Finally
// return 문이나 thorw문이 사용되더라도 (흐름제어를 외부로 옮겨도) finally절은 무조건 실행된다.
namespace C_Study.chapter_12
{
    class Finally
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return dividend / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외 발생");
                throw e; // 호출자인 Main()에게 다시 던진다.
            }
            finally
            {
                Console.WriteLine("Divide() 끝");
            }

        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("제수를 입력하세요 : ");
                string temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.Write("피제수를 입력하세요 : ");
                temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.WriteLine($"{dividend} / {divisor} = {Divide(dividend, divisor)}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("포맷 에러 : " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("나누기 에러 : " + e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
