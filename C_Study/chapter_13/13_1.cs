using System;
using System.Collections.Generic;
using System.Text;

// page 482
namespace C_Study.chapter_13
{
    delegate int Mydelegate(int a, int b);
    class _13_1
    {
        static void Main(string[] args)
        {
            Mydelegate Callback;

            Callback = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(Callback(3, 4));

            Callback = delegate (int a, int b)
            {
                return a - b;
            };

            Console.WriteLine(Callback(7, 5));
        }
    }
}
