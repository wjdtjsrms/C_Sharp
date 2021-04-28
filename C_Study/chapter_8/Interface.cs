using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

// 인터페이스 page 299
// 메소드, 이벤트, 인덱서, 프로퍼티 만을 가질 수 있다.
// 접근 제한자를 사용할 수 없고 모든 것이 public 으로 선언된다.
// 대개 I로 시작하는 이름으로 명명

namespace C_Study.chapter_8
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} : {message}");
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }


        public void WriteLog(string message)
        {
            writer.WriteLine($"{DateTime.Now.ToShortTimeString()} : {message}");
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            while(true)
            {
                Console.Write("온도를 입력해주세요 : ");
                string temperature = Console.ReadLine();
                if(temperature == "")
                {
                    break;
                }
                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }


    class Interface
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());

            


            monitor.start();
        }
    }
}
