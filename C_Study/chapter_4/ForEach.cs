using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study.chapter_4
{
    // page 171
    class ForEach
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };
            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
