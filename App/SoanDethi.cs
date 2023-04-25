
using App;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ThuVienHam;
namespace Buoi2_LapTrinhAnToan
{
    public partial class SoanDethi : Form
    {
        Thuvien tv = new Thuvien();
        string logonname;
        public SoanDethi(string uname)
        {

            InitializeComponent();
            logonname = uname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tro ve form soan de 

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string cauHoi = cauhoi.Text;
            string dapAn1 = "";
            string dapAn2 = "";
            string dapAn3 = "";
            string dapAn4 = "";
            string dapAnDung = "-1";
            string maCauHoi = macauhoi.Text;
            if (checkBoxA.Checked)
            {
                dapAnDung = "1";
                dapAn1 = textBoxA.Text;
                dapAn2 = textBoxB.Text;
                dapAn3 = textBoxC.Text;
                dapAn4 = textBoxD.Text;
            }
            else
            if (checkBoxB.Checked)
            {
                dapAnDung = "2";
                dapAn1 = textBoxA.Text;
                dapAn2 = textBoxB.Text;
                dapAn3 = textBoxC.Text;
                dapAn4 = textBoxD.Text;
            }
            else
            if (checkBoxC.Checked)
            {
                dapAnDung = "3";
                dapAn1 = textBoxA.Text;
                dapAn2 = textBoxB.Text;
                dapAn3 = textBoxC.Text;
                dapAn4 = textBoxD.Text;
            }
            else
            if (checkBoxD.Checked)
            {
                dapAnDung = "4";
                dapAn1 = textBoxA.Text;
                dapAn2 = textBoxB.Text;
                dapAn3 = textBoxC.Text;
                dapAn4 = textBoxD.Text;
            }


            if (string.IsNullOrEmpty(cauHoi) || string.IsNullOrEmpty(dapAn1) || string.IsNullOrEmpty(dapAn2) || string.IsNullOrEmpty(dapAn3) || string.IsNullOrEmpty(dapAnDung) || string.IsNullOrEmpty(maCauHoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = App.Properties.Settings.Default.connectionstring;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            SqlCommand command = new SqlCommand("INSERT INTO Dethi(cauhoi, dapan1, dapan2, dapan3, dapan4, dapandung, macauhoi) VALUES (@CauHoi, @DapAn1, @DapAn2, @DapAn3, @DapAn4, @DapAnDung, @MaCauHoi)", con);
            command.Parameters.AddWithValue("@CauHoi", tv.mahoa(cauHoi));
            command.Parameters.AddWithValue("@DapAn1", tv.mahoa(dapAn1));
            command.Parameters.AddWithValue("@DapAn2", tv.mahoa(dapAn2));
            command.Parameters.AddWithValue("@DapAn3", tv.mahoa(dapAn3));
            command.Parameters.AddWithValue("@DapAn4", tv.mahoa(dapAn4));
            command.Parameters.AddWithValue("@DapAnDung", tv.mahoa(dapAnDung));
            command.Parameters.AddWithValue("@MaCauHoi", tv.mahoa(maCauHoi));
            int result = command.ExecuteNonQuery();
            con.Close();

            if (result > 0)
            {
                MessageBox.Show("Lưu câu hỏi thành công.");
                foreach (Control control in this.Controls)
                {
                    if (control is System.Windows.Forms.TextBox)
                    {
                        (control as System.Windows.Forms.TextBox).Text = "";
                    }
                    else if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = false;
                    }
                    else if (control is RichTextBox)
                    {
                        (control as RichTextBox).Text = "";
                    }

                }
            }
            else
            {
                MessageBox.Show("Lưu câu hỏi thất bại.");
            }
        }

        private void checkBoxB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxB.Checked == true)
            {
                checkBoxA.Checked = false;
                checkBoxC.Checked = false;
                checkBoxD.Checked = false;
            }
        }

        private void checkBoxC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxC.Checked == true)
            {
                checkBoxB.Checked = false;
                checkBoxA.Checked = false;
                checkBoxD.Checked = false;
            }
        }

        private void checkBoxD_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxD.Checked == true)
            {
                checkBoxB.Checked = false;
                checkBoxC.Checked = false;
                checkBoxA.Checked = false;
            }
        }
        private void checkBoxA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxA.Checked == true)
            {
                checkBoxB.Checked = false;
                checkBoxC.Checked = false;
                checkBoxD.Checked = false;
            }
        }

    }
}
