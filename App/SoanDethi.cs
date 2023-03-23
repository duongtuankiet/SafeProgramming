using App;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buoi2_LapTrinhAnToan
{
    public partial class SoanDethi : Form
    {

        public SoanDethi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tro ve form soan de 
           
        }
        public string EncryptString(string plaintext, byte[] key, byte[] iv)
        {
            Aes encryptor = Aes.Create();
            encryptor.Mode = CipherMode.CBC;
            encryptor.Key = key;
            encryptor.IV = iv;
            MemoryStream memorystream = new MemoryStream();
            ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();
            CryptoStream cryptoStream = new CryptoStream(memorystream, aesEncryptor, CryptoStreamMode.Write);
            byte[] plainbytes = Encoding.ASCII.GetBytes(plaintext);
            cryptoStream.Write(plainbytes, 0, plainbytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherbytes = memorystream.ToArray();
            memorystream.Close();
            cryptoStream.Close();
            string ciphertext = Convert.ToBase64String(cipherbytes, 0, cipherbytes.Length);
            return ciphertext;
        }
        public string DecryptString(string ciphertext, byte[] key, byte[] iv)
        {
            Aes encryptor = Aes.Create();
            encryptor.Mode = CipherMode.CBC;
            encryptor.Key = key;
            encryptor.IV = iv;
            MemoryStream memorystream = new MemoryStream();
            ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();
            CryptoStream cryptoStream = new CryptoStream(memorystream, aesDecryptor, CryptoStreamMode.Write);
            string plaintext = String.Empty;
            byte[] cipherbyte = Convert.FromBase64String(ciphertext);
            cryptoStream.Write(cipherbyte, 0, cipherbyte.Length);
            cryptoStream.FlushFinalBlock();
            byte[] plainbytes = memorystream.ToArray();
            plaintext = Encoding.ASCII.GetString(plainbytes, 0, plainbytes.Length);
            memorystream.Close();
            cryptoStream.Close();
            return plaintext;
        }
        public string mahoa(string s)
        {
            string password = "meo meo";
            SHA256 mySha256 = SHA256Managed.Create();
            byte[] key = mySha256.ComputeHash(Encoding.ASCII.GetBytes(password));
            byte[] iv = new byte[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string mess = s;
            string mahoa = EncryptString(mess, key, iv);
            return mahoa;
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
            command.Parameters.AddWithValue("@CauHoi", mahoa(cauHoi));
            command.Parameters.AddWithValue("@DapAn1", mahoa(dapAn1));
            command.Parameters.AddWithValue("@DapAn2", mahoa(dapAn2));
            command.Parameters.AddWithValue("@DapAn3", mahoa(dapAn3));
            command.Parameters.AddWithValue("@DapAn4", mahoa(dapAn4));
            command.Parameters.AddWithValue("@DapAnDung", mahoa(dapAnDung));
            command.Parameters.AddWithValue("@MaCauHoi", mahoa(maCauHoi));
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

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxD_TextChanged(object sender, EventArgs e)
        {

        }

        private void cauhoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void macauhoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SoanDethi_Load(object sender, EventArgs e)
        {

        }
    }
}
