using App;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ThuVienHam;

namespace Buoi2_LapTrinhAnToan
{
    public partial class Dangnhap : Form
    {
        Thuvien tv = new Thuvien();
        public Dangnhap()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //thoat ung dung
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //ham nay de show passwd 
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
            textBox2.Refresh();

        }
        private void bgen_Click(object sender, EventArgs e)
        {
            //ham nay de lay du lieu tu file va so sanh voi du lieu nhap vao, code theo thay Lam
            string hoten = textBox1.Text;
            string pass = textBox2.Text;
            string hashcode = tv.hashstring(pass, "SHA512");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = App.Properties.Settings.Default.connectionstring;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar, 200).Value = hoten;
            cmd.Parameters.Add("@hashcode", SqlDbType.NVarChar, 200).Value = hashcode;
            string sql = "select role from users where username = @hoten and password = @hashcode ";
            cmd.CommandText = sql;
            cmd.Prepare();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string s = (string)reader["role"];
                string message = "Đăng nhập thành công";
                string title = "Thông báo";
                MessageBox.Show(message, title);
                tv.ghilog("Log", "User logon : " + hoten);
                MainForm f = new MainForm(s);
                f.Show();
                this.Hide();
            }
            else
            {
                //hien thong bao bang messagebox khi that bai
                string message = "Đăng nhập không thành công";
                string title = "Thông báo";
                tv.ghilog("Log", "Login that bai");
                MessageBox.Show(message, title);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //chuyen huong sang form register 
            Dangky f = new Dangky();
            f.Show();
            this.Hide();
        }
    }
}
