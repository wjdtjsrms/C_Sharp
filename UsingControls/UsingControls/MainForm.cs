using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
namespace UsingControls
{
    public partial class MainForm : Form
    {
        Random random = new Random(37);

        public MainForm()
        {
            InitializeComponent();

            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; // 운영체제에 있는 폰트 목록 검색
            foreach (FontFamily font in Fonts)
            {
                cboFont.Items.Add(font.Name); // cboFont 컨트롤에 폰트 이름 추가
            }
                
        }

        void ChangeFont()
        {
            if(cboFont.SelectedIndex < 0) // cboFont에서 서낵한 항목이 없으면 메소드 종료
            {
                return;
            }
            FontStyle style = FontStyle.Regular; // FontStyle 객체를 초기화한다.

            if(chkBold.Checked) // "굵게" 체크 박스가 선택되어 있으면 Bold 논리합 수행
            {
                style |= FontStyle.Bold;
            }
            if (chkItalic.Checked) // "이탤릭" 체크 박스가 선택되어 있으면 Italic 논리합 수행
            {
                style |= FontStyle.Italic;
            }

            // txtSampleText의 Font 프로퍼티를 앞에서 만든 style로 수정
            txtSampleText.Font =
                new Font((string)cboFont.SelectedItem, 10, style);
        }
        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;
        }


        // Modal 창은 일단 띄우고 나면 창을 닫을 때까지 프로그램의 다른 UI를 절대 사용할 수 없다.
        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog(); // Modal 창을 띄운다.
        }
        // Modalless 창을 띄우고 난 뒤에도 프로그램의 다른 UI에 사용자가 접근 할 수 있다.
        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless Form";
            frm.Width = 300;
            frm.Height =3100;
            frm.BackColor = Color.Green;
            frm.Show(); // Modal 창을 띄운다.
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text,"MessageBox Test",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach(TreeNode node in tvDummy.Nodes)
            {
                TreeToList(node);
            }
        }
        void TreeToList(TreeNode Node)
        {
            lvDummy.Items.Add
                (new ListViewItem(new string[] {Node.Text, Node.FullPath.Count(f => f == '\\').ToString() }));

            foreach (TreeNode node in Node.Nodes)
            {
                TreeToList(node);
            }
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if(tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }
    }
}
