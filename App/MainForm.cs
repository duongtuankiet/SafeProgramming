using Buoi2_LapTrinhAnToan;
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace App
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        string logonname;
        public MainForm( string loginname)
        {
            InitializeComponent();
            logonname = loginname;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void đềThiHêĐiềuHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoanDethi form = new SoanDethi();
            form.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process calculatorProcess = Process.Start("calc.exe");
            calculatorProcess.WaitForExit();
        }

        private void đăngKýUserMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangky form = new Dangky();
            form.ShowDialog();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(logonname == "admin")
            {
            }
            if(logonname == "giao vien")
            {
                đăngKýUserMớiToolStripMenuItem.Visible = false;
                đổiMậtKhẩuUserToolStripMenuItem.Visible=false;
                viewMenu.Visible=false;
            }
            if(logonname =="hoc sinh")
            {
                đăngKýUserMớiToolStripMenuItem.Visible = false;
                đổiMậtKhẩuUserToolStripMenuItem.Visible = false;
                toolsMenu.Visible=false;
                editMenu.Visible=false;
            }
        }

        private void đổiMậtKhẩuUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doimatkhau doimatkhau = new Doimatkhau();
            doimatkhau.ShowDialog();
        }

        private void thiHêĐiềuHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thi th = new Thi();
            th.ShowDialog();
        }

        private void xemĐềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemSuadethi x = new XemSuadethi();
            x.ShowDialog();
        }

        private void thiCơSởDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thi th = new Thi();
            th.ShowDialog();
        }

        private void đềThiCơSởDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoanDethi form = new SoanDethi();
            form.Show();
        }
    }
}
