using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Study
{
    class Divde
    {
        static void Main(string[] args)
        {

            // 예외처리가 일어남 var i2 = int.Parse("123");

            var i3 = 0;

            var ok = int.TryParse("123", out i3);
            Console.WriteLine(i3);
            // 해보고 안되면 0 반환
            ok = int.TryParse("abc", out i3);
            Console.WriteLine(i3);



        }
        static bool Func1()
        {
            Console.WriteLine("func1");
            return true;
        }
        static bool Func2()
        {
            Console.WriteLine("func2");
            return false;
        }
    }
}
