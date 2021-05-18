using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 722  창의 최소화 / 최대화 버튼 감추기
namespace SimpleWindow
{
    class FormStyle : Form
    {
        static void Main(string[] args)
        {
            FormStyle form = new FormStyle();
            form.Width = 400;
            form.MouseDown += new MouseEventHandler(form_MouseDown);

            Application.Run(form);
        }
        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;
            if(e.Button == MouseButtons.Left)
            {
                form.MaximizeBox = true;
                form.MinimizeBox = true;
                form.Text = "최소화/최대화 버튼이 활성화 되었습니다.";
            }
            else if (e.Button == MouseButtons.Right)
            {
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.Text = "최소화/최대화 버튼이 비활성화 되었습니다.";
            }
        }
    }

}
