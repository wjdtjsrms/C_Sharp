using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Study
{
    class AllChange
    {
        public static int[] numArr = new int[46];
        static void ChangeAllNumArr(ref int[] numarr)
        {
            Random random = new Random();
            
            for(int i=0;i<numarr.Length;i++)
            {
                int rand1 = random.Next(0, 45);
                int rand2 = random.Next(0, 45);

                if(rand1 != rand2)
                {
                    int temp = numarr[rand1];
                    numarr[rand1] = numarr[rand2];
                    numarr[rand2] = temp;
                }
            }

        }
        static void Main(string[] args)
        {
            for(int i=0;i< numArr.Length;i++)
            {
                numArr[i] = i;
            }

            ChangeAllNumArr(ref numArr);

            for (int i=0;i<numArr.Length;i++)
            {
                Console.Write($"{numArr[i]}, ");
            }

        }
    }



}
