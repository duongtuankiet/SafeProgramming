using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_LapTrinhAnToan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
            byte[] x = Encoding.Default.GetBytes(pass);
            HashAlgorithm x2 = HashAlgorithm.Create("SHA512");
            byte[] y = x2.ComputeHash(x);
            string hashcode = "";
            //foreach (byte x_byte in y)
            //{
            //    string hex = x_byte.ToString("X2");
            //    hashcode += hex;
            //}
            hashcode = BitConverter.ToString(y);
            //string hashcode2 = "";
            //Encoding encoding = Encoding.UTF8;
            //string filename = "C:\\Users\\SV\\Desktop\\data.csv";
            //string ten = "";
            //string pas = "";
            //string n = "";
            //Boolean found = false;
            //if (File.Exists(filename))
            //{
            //    FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            //    int Bufr = (int)fs.Length;
            //    byte[] buf = new byte[Bufr];
            //    int numberread = fs.Read(buf, 0, Bufr);
            //    fs.Close();
            //    n = encoding.GetString(buf, 0, numberread);
            //    string[] data = n.Split('\n');
            //    for (int i = 0; i < data.Length; i++)
            //    {
            //        if (data[i].Trim() == "") { continue; }
            //        string[] data2 = data[i].Split('|');
            //        ten = data2[0];
            //        hashcode2 = data2[1];
            //        if ((hashcode == hashcode2) && (ten.Trim() == hoten.Trim()))
            //        {
            //            found = true;
            //            break;
            //        }

            //    }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = App.Properties.Settings.Default.connectionstring;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            cmd.Connection = con;
            cmd2.Connection = con;
            string sql = "select uname from users where uname = '" + hoten + "' and passwd ='" + hashcode + "'";
            cmd.CommandText = sql;
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string message = "Đăng nhập thành công";
                string title = "Thông báo";
                MessageBox.Show(message, title);
                Form3 f = new Form3();
                f.Show();
                this.Hide();
            }
                else
                {
                    //hien thong bao bang messagebox khi that bai
                    string message = "Đăng nhập không thành công";
                    string title = "Thông báo";
                    MessageBox.Show(message, title);
                }
            }
       
        


        private void button1_Click(object sender, EventArgs e)
        {
            //chuyen huong sang form register 
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
