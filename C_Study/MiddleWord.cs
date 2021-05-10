using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Study
{
    class MiddleWord
    {
        static void Main(string[] args)
        {
            string tempA = "NewDeal";
            string tempB = "Deal";

            PickMiddleWords(tempA);
            PickMiddleWords(tempB);
        }

        static void PickMiddleWords(string word)
        {
            int length = word.Length;
            string str = (length % 2) != 0 ? word[length / 2].ToString() : word[(length / 2) - 1] + word[length / 2].ToString() ;
            Console.WriteLine(str);
        }
    }
}
