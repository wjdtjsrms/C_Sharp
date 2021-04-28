using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study
{
    // page 82
    class Enum_Study
    {
        enum DialogResult { YES,NO,CANCLE,CONFIRM,OK}
        enum DialogResult2 { YES = 10, NO, CANCLE, CONFIRM = 50, OK }
        static void Main(String[] arts)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCLE);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
            Console.WriteLine();

            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCLE);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);
            Console.WriteLine();

            Console.WriteLine((int)DialogResult2.YES);
            Console.WriteLine((int)DialogResult2.NO);
            Console.WriteLine((int)DialogResult2.CANCLE);
            Console.WriteLine((int)DialogResult2.CONFIRM);
            Console.WriteLine((int)DialogResult2.OK);
        }
    }
}
