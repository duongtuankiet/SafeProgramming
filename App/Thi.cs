using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace App
{
    public partial class Thi : Form
    {
        List<baitap> btList = new List<baitap>();
        private DataTable dataTable;
        private int currentIndex;
        private int diemthi = 0;
        public Thi()
        {
            InitializeComponent();
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
        private void Thi_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = App.Properties.Settings.Default.connectionstring;
            con.Open();
            string query = "SELECT TOP (10) [macauhoi] ,[dapandung] ,[dapan1] ,[dapan2] ,[dapan3] ,[cauhoi] ,[dapan4] FROM [tracnghiem].[dbo].[Dethi] order by NEWID()";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            currentIndex = 0;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                baitap bt = new baitap();
                DataRow row = dataTable.Rows[i];
                bt.Macauhoi = row["macauhoi"].ToString();
                bt.Cauhoi = row["cauhoi"].ToString();
                string mch = row["macauhoi"].ToString();
                bt.Dapandung = row["dapandung"].ToString();
                bt.Dapan1 = row["dapan1"].ToString();
                bt.Dapan2 = row["dapan2"].ToString();
                bt.Dapan3 = row["dapan3"].ToString();
                bt.Dapan4 = row["dapan4"].ToString();
                btList.Add(bt);
            }

            ShowRecord(currentIndex);

        }
        private void ShowRecord(int index)
        {
            //index = index - 1;

            checkBoxA.Checked = false;
            checkBoxB.Checked = false;
            checkBoxC.Checked = false;
            checkBoxD.Checked = false;

            switch (btList[index].Dapanchon)
            {
                case 1:
                    {
                        checkBoxA.Checked = true;
                        break;
                    }
                case 2:
                    {
                        checkBoxB.Checked = true;
                        break;
                    }
                case 3:
                    {
                        checkBoxC.Checked = true;
                        break;
                    }
                case 4:
                    {
                        checkBoxD.Checked = true;
                        break;
                    }
                default:
                    break;

            }
            if (dataTable.Rows.Count > 0)
            {
                macauhoi.Text = giaima(btList[index].Macauhoi);
                cauhoi.Text = giaima(btList[index].Cauhoi);
                string a = giaima(btList[index].Dapan1);
                string b = giaima(btList[index].Dapan2);
                string c = giaima(btList[index].Dapan3);
                string d = giaima(btList[index].Dapan4);
                cauA.Text = a;
                cauB.Text = b;
                cauC.Text = c;
                cauD.Text = d;

            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin của bản ghi được chọn và hiển thị lên form
            currentIndex = e.RowIndex;
            ShowRecord(currentIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < dataTable.Rows.Count - 1)
            {
                currentIndex++;
                ShowRecord(currentIndex);
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowRecord(currentIndex);
            }
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            diemthi = 0;
            foreach (baitap bt in btList)
            {
                if (bt.Dapanchon.ToString() == giaima(bt.Dapandung))
                {
                    diemthi++;
                }
            }
            MessageBox.Show("Điểm thi của bạn là " + diemthi.ToString());
        }

        private void checkBoxA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxA.Checked == true)
            {
                btList[currentIndex].Dapanchon = 1;
                checkBoxB.Checked = false;
                checkBoxC.Checked = false;
                checkBoxD.Checked = false;
            }
        }

        private void checkBoxB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxB.Checked == true)
            {
                btList[currentIndex].Dapanchon = 2;
                checkBoxA.Checked = false;
                checkBoxC.Checked = false;
                checkBoxD.Checked = false;
            }
        }

        private void checkBoxC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxC.Checked == true)
            {
                btList[currentIndex].Dapanchon = 3;
                checkBoxB.Checked = false;
                checkBoxA.Checked = false;
                checkBoxD.Checked = false;
            }
        }

        private void checkBoxD_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxD.Checked == true)
            {
                btList[currentIndex].Dapanchon = 4;
                checkBoxB.Checked = false;
                checkBoxC.Checked = false;
                checkBoxA.Checked = false;
            }
        }
    }
}
