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
        string groups;
        public MainForm(string group, string uname)
        {
            InitializeComponent();
            logonname = uname;
            groups = group;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            SoanDethi form = new SoanDethi(logonname);
            form.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();  
            dn.Show();
            this.Close();
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
            if(groups == "admin")
            {
            }
            if(groups == "giao vien")
            {
                đăngKýUserMớiToolStripMenuItem.Visible = false;
                đổiMậtKhẩuUserToolStripMenuItem.Visible=false;
                khôiPhụcTàiKhoảnToolStripMenuItem.Visible=false;
                viewMenu.Visible=false;
            }
            if(groups =="hoc sinh")
            {
                đăngKýUserMớiToolStripMenuItem.Visible = false;
                đổiMậtKhẩuUserToolStripMenuItem.Visible = false;
                khôiPhụcTàiKhoảnToolStripMenuItem.Visible = false;
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
            XemSuadethi x = new XemSuadethi(logonname);
            x.ShowDialog();
        }

        private void thiCơSởDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thi th = new Thi();
            th.ShowDialog();
        }

        private void đềThiCơSởDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoanDethi form = new SoanDethi(logonname);
            form.Show();
        }

        private void khôiPhụcTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khoiphuctaikhoan form = new khoiphuctaikhoan();
            form.Show();
        }
    }
}
