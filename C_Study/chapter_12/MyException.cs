using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 사용자 정의 예외 클래스 만들기 page 447

namespace C_Study.chapter_12
{
    class InvaildArugumentException: Exception
    {
        public InvaildArugumentException()
        {

        }
        public InvaildArugumentException(string message)
            :base(message)
        {

        }
        public object Argument
        {
            get;
            set;
        }
        public string Range
        {
            get;
            set;
        }
    }

    class MyException
    {
        static uint MergeARGB(uint alpha,uint red,uint green,uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };
            foreach(uint arg in args)
            {
                if(arg > 255)
                {
                    throw new InvaildArugumentException()
                    {
                        Argument = arg,
                        Range = "0~255"
                    };
                }
            }
            return (alpha << 24 & 0xFF000000) |
                   (red   << 16 & 0x00FF0000) |
                   (green << 8  & 0x0000FF00) |
                   (blue        & 0x000000FF);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"{MergeARGB(255, 111, 111, 111)}");
                Console.WriteLine($"{MergeARGB(1, 65, 192, 128)}");
                Console.WriteLine($"{MergeARGB(0, 255, 255, 300)}");
            }
            catch (InvaildArugumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Argument : {e.Argument}, Range: {e.Range}");
            }
        }
    }
}
