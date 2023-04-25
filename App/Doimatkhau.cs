using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ThuVienHam;
namespace App
{
    public partial class Doimatkhau : Form
    {
        Thuvien tv = new Thuvien();
        public Doimatkhau()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {

                textBox3.PasswordChar = '\0';
            }
            else
            {

                textBox3.PasswordChar = '*';

            }

            textBox3.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string repassword = textBox3.Text;
            if (password != repassword)
            {
                string message = "Password không trùng khớp";
                string title = "Thông báo";
                MessageBox.Show(message, title);
            }
            else {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = App.Properties.Settings.Default.connectionstring;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                cmd.Connection = con;
                cmd2.Connection = con;
                string sql = "select username from users where username = @username";             
                cmd.CommandText = sql;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 200).Value = username;
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    con.Close();
                    con.Open();
                    string hashpass = tv.hashstring(password, "SHA512");
                    string sql2 = "UPDATE users SET password = @hashpass where username = @username";
                    cmd2.CommandText = sql2;
                    cmd2.Parameters.Add("@hashpass", SqlDbType.NVarChar, 200).Value = hashpass;
                    cmd2.Parameters.Add("@username", SqlDbType.NVarChar, 200).Value = username;
                    cmd2.Prepare();
                    cmd2.ExecuteNonQuery();
                    string message = "Đổi mật khẩu thành công";
                    string title = "Thông báo";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string message = "user " + username + " không tồn tại";
                    string title = "Thông báo";
                    MessageBox.Show(message, title);
                }
            }
        }
    }
}
