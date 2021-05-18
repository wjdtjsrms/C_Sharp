using System;
using System.Windows.Forms;

// page 714 Form에 정의된 이벤트와 이벤트 처리기 연결하기
namespace SimpleWindow
{
    class FormEvent :Form
    {
        // sender 이벤트가 발생한 객체, 여기서는 자기 자신
        // MouseEventArgs 다양한 프로퍼티 제공
        // e.Button 어떤 버튼이 눌렸는지, e.Delta 흴이 회전 방향과 거리
        public void MyMouseHandler(object sender,MouseEventArgs e)
        {
            Console.WriteLine($"Sender : {((Form)sender).Text}"); // 자기자신이 보낸 메시지를 받는다.
            Console.WriteLine($"X : {e.X}, Y : {e.Y}"); // 이벤트가 발생한 폼 또는 컨트롤상의 좌표를 표현
            Console.WriteLine($"Button : {e.Button}, Clicks : {e.Clicks}"); // 마우스가 클릭한 횟수, 더블클릭 같은 경우를 잡는다.
            Console.WriteLine();
        }
        public FormEvent(string title)
        {
            this.Text = title;
            // 이벤트 처리기를 이벤트에 연결
            this.MouseDown += new MouseEventHandler(MyMouseHandler);
        }

        static void Main(string[] args)
        {
            Application.Run(new FormEvent("Mouse Event Test"));
        }
    }
}
