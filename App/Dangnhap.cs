using App;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ThuVienHam;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Buoi2_LapTrinhAnToan
{
    public partial class Dangnhap : Form
    {
        Thuvien tv = new Thuvien();
        int count = 4;
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
            
            string hoten = textBox1.Text;
            string pass = textBox2.Text;
            string hashcode = tv.hashstring(pass, "SHA512");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = App.Properties.Settings.Default.connectionstring;
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            cmd1.Parameters.Add("@hoten", SqlDbType.NVarChar, 200).Value = hoten;
            cmd1.Parameters.Add("@hashcode", SqlDbType.NVarChar, 200).Value = hashcode;
            string sql1 = "select * from users where username = @hoten ";
            cmd1.CommandText = sql1;
            cmd1.Prepare();
            var reader1 = cmd1.ExecuteReader();
            if (reader1.HasRows)
            {
                reader1.Read();
                string flag = (string)reader1["flag"];
                if (flag == "-1")
                {
                    string message = "Tài khoản của bạn bị khóa, liên hệ nhà quản trị để mở khóa";
                    string title = "Thông báo";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string pas = tv.giaima((string)reader1["password"]);
                    if (hashcode != pas)
                    {
                        //hien thong bao bang messagebox khi that bai
                        count--;

                        if (count >= 1)
                        {
                            MessageBox.Show("Đăng nhập không thành công, bạn còn " + count + " lần thử", "Thông báo");
                            tv.ghilog("Log", "Login that bai");
                        }
                        else
                        {
                            string sql3 = "UPDATE users SET flag = '" + "-1" + "' where username = '" + hoten + "'";
                            SqlCommand cmd3 = new SqlCommand();
                            cmd3.Connection = con;
                            con.Close();
                            con.Open();
                            cmd3.CommandText = sql3;
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("Bạn đã bị khóa tài khoản", "Thông báo");
                        }
                    }
                    else
                    {
                        string role = (string)reader1["role"];
                        string message = "Đăng nhập thành công";
                        string title = "Thông báo";
                        MessageBox.Show(message, title);
                        tv.ghilog("Log", "User logon : " + hoten);
                        MainForm f = new MainForm(role);
                        f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                //hien thong bao bang messagebox khi that bai
                string message = "Đăng nhập thất bại";
                string title = "Thông báo";
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
