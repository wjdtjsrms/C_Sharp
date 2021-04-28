using System;
using System.Collections.Generic;
using System.Text;

namespace C_Study.chapter_8
{
    // 상속하려는 인터페이스가 소스코드가 아닌 어셈블리만으로 제공할때
    // 어셈블리 안에 있기 때문에 인터페이스를 수정할 수가 없다. 이 인터페이스에 새로운 기능을 추가하기 위해서는 상속해야 한다.
    // 상속하려는 인터페이스의 소스 코드를 갖고 있어도 이미 인터페이스를 상속하는 클래스들이 존재하는 경우
    // 기존 소스코드에 영향을 주지 않기 위해 상속 받아 새로 만든다.
    // interface 상속하는 인터페이스 page 307

    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }
    class ConsolLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}  {message}");
        }
        public void WriteLog(string format, params Object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }
    }

    class DerivedInterface
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsolLogger2();
            logger.WriteLog("The world is not flat");
            logger.WriteLog($"{1} + {1} = {2}");
        }
    }
}
