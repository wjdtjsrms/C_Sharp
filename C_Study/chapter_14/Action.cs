using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Study.chapter_14
{
    class Action
    {
        static void Main()
        {
            Action<int, int> action = (x, y) => Console.WriteLine($"첫번째 함수 실행 {x},{y}");
            action += (x, y) =>
            {
                x = x * x;
                y = y * y;
                Console.WriteLine($"두번째 함수 실행 {x},{y}");
            };
            action += (x,y) => Console.WriteLine($"세번째 함수 실행 {x - y}");

            action(5, 6);
        }
    }
}
