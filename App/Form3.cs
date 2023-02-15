using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_LapTrinhAnToan
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void deThiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void soanDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chuyen huong qua form saon de thi
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }
    }
}
