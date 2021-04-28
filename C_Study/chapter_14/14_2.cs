using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Study.chapter_14
{
    class _14_2
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };
            Action<int> action = (a) => Console.WriteLine(a * a);

            foreach (int a in array)
            {
                action.Invoke(a);
            }
        }
    }
}
