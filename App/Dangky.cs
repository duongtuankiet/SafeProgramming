using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using ThuVienHam;

namespace Buoi2_LapTrinhAnToan
{
    public partial class Dangky : Form
    {
        Thuvien tv = new Thuvien();
        public Dangky()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string hoten = textBox1.Text;
            string pass = textBox2.Text;
            string role = comboBox1.Text;
            string flag = "0";
            
            //ham kiem tra username va pass co null khong , neu co thi restart app
            if (hoten == "" || pass == "" || (role != "admin" && role != "giao vien" && role!= "hoc sinh"))
            {
                string message = "Đăng ký không thành công";
                string title = "Thông báo";
                MessageBox.Show(message, title);
            }
            else
            {  
                string psw = tv.mahoa(tv.hashstring(pass, "SHA512"));
                //ham nay dung de luu username va passwd vao file csv, code theo thay Lam 
                if (psw != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = App.Properties.Settings.Default.connectionstring;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd.Connection = con;
                    cmd2.Connection = con;
                    string sql = "select username from users where username = '" + hoten + "'";
                    cmd.CommandText = sql;
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        string message = "Đăng ký thất bại";
                        string title = "Thông báo";
                        MessageBox.Show(message, title);
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        sql = "INSERT INTO users (username, password, role, flag) VALUES ('" + hoten + "', '" + psw + "','" + role + "','" + flag + "')";
                        cmd2.CommandText = sql;
                        cmd2.ExecuteNonQuery();
                        string message = "Đăng ký thành công";
                        string title = "Thông báo";
                        MessageBox.Show(message, title);
                    }
                }
                else
                {
                    string message = "Đăng ký không thành công";
                    string title = "Thông báo";
                    MessageBox.Show(message, title);
                }
            }
        }
        //ham nay de generate pass ra ma sha512
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //khi minh an vao show thi se show ki tu cua password
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
        private void button3_Click(object sender, EventArgs e)
        {
            //khi an exit thi thoat
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //cai nay chuyen huong sang trang login
            Dangnhap f = new Dangnhap();
            f.Show();
            this.Hide();
        }

        private void Dangky_Load(object sender, EventArgs e)
        {

        }
    }
}

