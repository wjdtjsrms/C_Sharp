using System;
using System.Collections.Generic;
using System.Text;

// 인터페이스 기본 구현 메소드 page 314
// 구현한 인터페이스가 상속받은 클래스가 업그레이드 되고 파생클래스가 수없이 생긴 상태
// 놓친 메소드를 추가하기 위해 사용하는 기법
// 기본 구현 메소드는 인터페이스 참조로 업캐스팅 했을때만 사용할 수 있다.
// 해결책 기능적으로도 같은 부분은 추상클래스로 만들고 완전히 다른 부분만 인터페이스로 만든다.

namespace C_Study.chapter_8
{
    interface ILogger
    {
        void WriteLog(string message);
        void  WriteError(string error) // 새로운 메소드 추가
        {
            WriteLog($"Error: {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}  {message}");
        }
    }

    class DefaultImplementation
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");
           // clogger.WriteError("System Fail"); 
        }
    }
}
