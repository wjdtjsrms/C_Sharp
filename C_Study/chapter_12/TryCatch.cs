using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 예외 처리 page 435
// 예를 들어 배열범위를 벗어나면 IndexOutOfRangeException 예외를 Main() 메소드에 던진다.
// 근데 처리를 안하면 다시 CLR에 던지고 CLR까지 전달된 예외는 처리되지 않은 예외가 되고 프로그램을 종료한다.
// 그걸 방지하기 위해 try ~catch 구문으로 예외를 처리한다. 
// catch에서 받을 때는 try에서 던질 예외 객체와 형식이 일치해야 한다.


namespace C_Study.chapter_12
{
    class TryCatch
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for(int i=0;i<5;i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"예외가 발생했습니다 : {e.Message}");
            }

            Console.WriteLine("종료");
        }
    }
}
