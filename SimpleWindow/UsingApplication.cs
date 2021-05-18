using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Application 클래스 page 706
namespace SimpleWindow
{
    class UsingApplication : System.Windows.Forms.Form
    {
        static void Main(string[] args)
        {
            UsingApplication form = new UsingApplication();

            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Console.WriteLine("Closing Window...");
                    Application.Exit(); // 응용 프로그램이 갖고 있는 모든 윈도우를 닫은 뒤 Run()을 반환시킨다.
                });

            Console.WriteLine("Starting Window Applicaiton...");
            Application.Run(form);

            // Run() 뒤에 자원을 정리하는 코드를 넣어두면 우아하게 응용 프로그램을 종료시킬 수 있다.
            Console.WriteLine("Exiting Window Application");
        }
    }
}
