using System;
using System.Windows.Forms;

// page 716  Form의 프로퍼티를 조절하여 윈도우 배경 바꾸기
namespace SimpleWindow
{
    class FormSize : Form
    {
        static void Main(string[] args)
        {
            FormSize form = new FormSize();
            form.Width = 300; // 창의 너비를 나타낸다.
            form.Height = 200; // 창의 높이를 나타낸다.
            form.MouseDown += new MouseEventHandler(form_MouseDown);

            Application.Run(form);
        }

        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;
            int oldWidth = form.Width;
            int oldHeight = form.Height;

            if(e.Button == MouseButtons.Left)
            { 
                if(oldWidth < oldHeight)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                if (oldHeight < oldWidth)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;
                }
            }
            Console.WriteLine("윈도우의 크기가 변경되었습니다.");
            Console.WriteLine($"Width : {form.Width}, Height : {form.Height}");
        }
    }
}
