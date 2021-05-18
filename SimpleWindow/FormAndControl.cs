using System;
using System.Windows.Forms;

// page 725 Form 위에 컨트롤 올리기
// 사용자 인터페이스는 응용 프로그램과 사용자가 대화를 하는 창구이다.
// 윈도우 os는 사용자 인터페이스를 위해 메뉴,콤보박스,리스트뷰,버튼 텍스트박스 등과 같은 표준 컨트롤을 제공
namespace SimpleWindow
{
    class FormAndControl :Form
    {
        static void Main(string[] args)
        {
            // 컨트롤의 인스턴스 생성
            Button button = new Button();

            // 컨트롤의 프로퍼티에 값 지정
            button.Text = "Click Me";
            button.Left = 100;
            button.Top = 50;

            // 컨트롤의 이벤트에 이벤트 처리기 등록
            button.Click += 
                (object sender, EventArgs e) =>
                {
                    MessageBox.Show("딸깍!");
                };

            // 폼에 컨트롤 추가
            FormAndControl form = new FormAndControl();
            form.Text = "Form & Control";
            form.Height = 150;

            form.Controls.Add(button);

            Application.Run(form);
        }
    }
}
