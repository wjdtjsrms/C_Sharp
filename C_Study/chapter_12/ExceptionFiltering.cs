using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 예외 처리 필터링 하기 page 450
// catch 절뒤에 when 키워드를 이용한다.(when을 if 라고 생각하면 쉽다.)
namespace C_Study.chapter_12
{
    class FilterableExcetion: Exception
    {
        public int ErrorNo { get; set; }
    }

    class ExceptionFiltering
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Between 0~10");
            string input = Console.ReadLine();
            try
            {
                int num = Int32.Parse(input);

                if( num < 0 || num > 10)
                {
                    throw new FilterableExcetion() { ErrorNo = num };
                }
                else
                {
                    Console.WriteLine($"Output : {num}");
                }
            }
            catch (FilterableExcetion e) when (e.ErrorNo < 0)
            {
                Console.WriteLine("Nagative input is not allowed");
            }
            catch (FilterableExcetion e) when (e.ErrorNo > 10)
            {
                Console.WriteLine("Too big number input is not allowed");
            }
        }
    }
}
