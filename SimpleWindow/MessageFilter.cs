using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 710 메시지 필터링
// 사용자가 마우스나 키보드 같은 하드웨어를 제어하면 인터럽트가 발생하고 이 인터럽트를 윈도우가 받아들인다.
// 윈도우는 이 인터럽트를 바탕으로 윈도우 메시지를 만든 뒤 이벤트를 받아야 하는 응용 프로그램에게 보낸다.
// Application 클래스는 응용 프로그램이 받는 수많은 메시지 중에 관심 있는 메시지만 걸러낼수 있는 Message Filtering 기능을 갖고 있다.

// Message 구조체는 다음과 같은 프로퍼티를 갖고 있는데, 이중 Msg 프로퍼티가 메시지의 ID를 담고 있다.
// Hwnd : 메시지를 받는 윈도우의 핸들(Handle), 윈도우의 인스턴스를 식별하고 관리하기 위해 운영체제가 붙인 번호를 핸들이라고 한다.
// Msg : 메시지 ID
// LParam : 메시지를 처리하는 데 필요한 정보가 담겨 있다.
// WParam : 메시지를 처리하는 데 필요한 부가 정보가 담겨 있다.
// Result : 메시지 처리에 대한 응답으로 윈도우 OS에 반환되는 값을 지정한다.

namespace SimpleWindow
{
    class Filter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            // 마우스 오른쪽 가운데 버튼 마우스, 휠 굴림
            if(m.Msg == 0x0F || m.Msg == 0xA0 ||
                m.Msg == 0x200 || m.Msg == 0x113)
            {
                return false; // 메시지를 건들지 않았으니 응용 프로그램이 처리해라, 이벤트를 실행 시킨다.
            }

            Console.WriteLine($"{m.ToString()} : {m.Msg}");

            if(m.Msg == 0x201) // 마우스 왼쪽 클릭
            {
                Application.Exit();
            }

            return true; // 메세지를 처리했으니 응용 프로그램은 관심을 가질 필요가 없다. 이벤트를 실행시키지 않는다.
        }
    }

    class MessageFilter : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new Filter());
            Application.Run(new MessageFilter());
        }
    }
}
