using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Buoi2_LapTrinhAnToan
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
         
            string hoten = textBox1.Text;
            string pass = textBox2.Text;
            string role = comboBox1.Text;
            
            //ham kiem tra username va pass co null khong , neu co thi restart app
            if (hoten == "" || pass == "" || (role != "admin" && role != "giao vien" && role!= "hoc sinh"))
            {
                string message = "Đăng ký không thành công";
                string title = "Thông báo";
                MessageBox.Show(message, title);
            }
            else
            {  
                string psw = hashstring(pass, "SHA512");
                //ham nay dung de luu username va passwd vao file csv, code theo thay Lam 
                if (psw != "")
                {
                    //SaveFileDialog s1 = new SaveFileDialog();
                    //s1.Filter = "CSV Macintosh|*.csv|All files|*.*";
                    //s1.FilterIndex = 1;
                    //s1.Title = "Save a user file";
                    //s1.ShowDialog();
                    //if (s1.FileName != "")
                    //{
                    //    FileStream fs;
                    //    String filename = s1.FileName;
                    //    if (File.Exists(filename))
                    //    {
                    //        fs = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Write);
                    //    }
                    //    else
                    //    {
                    //        fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Write);
                    //    }
                    //    Encoding encoding = Encoding.UTF8;
                    //    string chuoi = textBox1.Text.Trim() + "|" + psw.Trim() + "\n";
                    //    byte[] bytes = encoding.GetBytes(chuoi);
                    //    fs.Write(bytes, 0, bytes.Length);
                    //    fs.Close();
                    //    textBox1.Text = "";
                    //    textBox2.Text = "";
                    //    string message = "Đăng ký thành công";
                    //    string title = "Thông báo";
                    //    MessageBox.Show(message, title);
                    //    Form2 f = new Form2();
                    //    f.Show();
                    //    this.Hide();
                    //}
                    //else
                    //{
                    //    string message = "Đăng ký không thành công";
                    //    string title = "Thông báo";
                    //    MessageBox.Show(message, title);
                    //}
                    //ham nay de luu username vao database
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
                        string message = "user " + hoten + " đã tồn tại";
                        string title = "Thông báo";
                        MessageBox.Show(message, title);
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        sql = "INSERT INTO users (username, password, role) VALUES ('" + hoten + "', '" + psw + "','" + role + "')";
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
        public string hashstring(string mess, string algo)
        {
            string hashcode = "";
            byte[] x = Encoding.Default.GetBytes(mess);
            HashAlgorithm x2 = HashAlgorithm.Create(algo);
            byte[] y = x2.ComputeHash(x);
            hashcode = BitConverter.ToString(y);
            return hashcode;
        }
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
 
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cai nay chuyen huong sang trang login
            Dangnhap f = new Dangnhap();
            f.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

