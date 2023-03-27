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

namespace App
{
    public partial class XemSuadethi : Form
    {
        private DataTable dataTable;
        private int currentIndex;
        public XemSuadethi()
        {
            InitializeComponent();
        }

        private void XemSuadethi_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = App.Properties.Settings.Default.connectionstring;
            con.Open();
            string query = "SELECT * FROM Dethi";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            currentIndex = 0;
            ShowRecord(currentIndex);
        }
        public string giaima(string s)
        {
            string password = "meo meo";
            SHA256 mySha256 = SHA256Managed.Create();
            byte[] key = mySha256.ComputeHash(Encoding.ASCII.GetBytes(password));
            byte[] iv = new byte[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string mess = s;
            string mahoa = DecryptString(mess, key, iv);
            return mahoa;
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
        private void ShowRecord(int index)
        {
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[index];
                macauhoi.Text = giaima(row["macauhoi"].ToString());
                cauhoi.Text = giaima(row["cauhoi"].ToString());
                string a = giaima(row["dapan1"].ToString());
                string b = giaima(row["dapan2"].ToString());
                string c = giaima(row["dapan3"].ToString());
                string d = giaima(row["dapan4"].ToString());
                textBoxA.Text = a;
                textBoxB.Text = b;
                textBoxC.Text = c;
                textBoxD.Text = d;

                // Hiển thị thông tin các trường dữ liệu khác tương ứng với bảng
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowRecord(currentIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentIndex < dataTable.Rows.Count - 1)
            {
                currentIndex++;
                ShowRecord(currentIndex);
            }
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
            SqlCommand command = new SqlCommand("select * from Dethi where macauhoi = '" + mahoa(maCauHoi) + "' ", con);
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                con.Close();
                con.Open();
                
                SqlCommand cmand = new SqlCommand("UPDATE Dethi SET macauhoi = @MaCauHoi, cauhoi = @CauHoi, dapan1 = @DapAn1, dapan2 = @DapAn2, dapan3 = @DapAn3, dapan4 = @DapAn4, dapandung = @DapAnDung WHERE macauhoi = @MaCauHoi" , con);
                cmand.Parameters.AddWithValue("@CauHoi", mahoa(cauHoi));
                cmand.Parameters.AddWithValue("@DapAn1", mahoa(dapAn1));
                cmand.Parameters.AddWithValue("@DapAn2", mahoa(dapAn2));
                cmand.Parameters.AddWithValue("@DapAn3", mahoa(dapAn3));
                cmand.Parameters.AddWithValue("@DapAn4", mahoa(dapAn4));
                cmand.Parameters.AddWithValue("@DapAnDung", mahoa(dapAnDung));
                cmand.Parameters.AddWithValue("@MaCauHoi", mahoa(maCauHoi));
                cmand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Lưu câu hỏi thành công.");
            }
            else
            {
                MessageBox.Show("Lưu câu hỏi thất bại.");
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
    }
}
