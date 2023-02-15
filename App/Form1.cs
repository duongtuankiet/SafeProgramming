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

namespace Buoi2_LapTrinhAnToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
         
            string hoten = textBox1.Text;
            string pass = textBox2.Text;
            //ham kiem tra username va pass co null khong , neu co thi restart app
            if (hoten == "" || pass == "")
            {
                string message = "Đăng ký không thành công";
                string title = "Thông báo";
                MessageBox.Show(message, title);
                Application.Restart();
            }
            else
            {   //ham nay de generate pass ra ma sha512
                string siuu = "";
                byte[] x = Encoding.Default.GetBytes(pass);
                HashAlgorithm x2 = HashAlgorithm.Create("SHA512");
                byte[] y = x2.ComputeHash(x);
                foreach (byte x_byte in y)
                {
                    string hex = x_byte.ToString("X2");
                    siuu += hex;
                }
                //ham nay dung de luu username va passwd vao file csv, code theo thay Lam 
                if (siuu != "")
                {
                    SaveFileDialog s1 = new SaveFileDialog();
                    s1.Filter = "CSV Macintosh|*.csv|All files|*.*";
                    s1.FilterIndex = 1;
                    s1.Title = "Save a user file";
                    s1.ShowDialog();
                    if (s1.FileName != "")
                    {
                        FileStream fs;
                        String filename = s1.FileName;
                        if (File.Exists(filename))
                        {
                            fs = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Write);
                        }
                        else
                        {
                            fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Write);
                        }
                        Encoding encoding = Encoding.UTF8;
                        string chuoi = textBox1.Text.Trim() + "|" + siuu.Trim() + "\n";
                        byte[] bytes = encoding.GetBytes(chuoi);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        string message = "Đăng ký thành công";
                        string title = "Thông báo";
                        MessageBox.Show(message, title);
                        Form2 f = new Form2();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        string message = "Đăng ký không thành công";
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
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

