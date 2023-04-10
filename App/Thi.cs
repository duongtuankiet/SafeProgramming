using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ThuVienHam;
namespace App
{
    public partial class Thi : Form
    {
        Thuvien tv = new Thuvien();
        List<baitap> btList = new List<baitap>();
        private DataTable dataTable;
        private int currentIndex;
        private int diemthi = 0;
        public Thi()
        {
            InitializeComponent();
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
                macauhoi.Text = tv.giaima(btList[index].Macauhoi);
                cauhoi.Text = tv.giaima(btList[index].Cauhoi);
                string a = tv.giaima(btList[index].Dapan1);
                string b = tv.giaima(btList[index].Dapan2);
                string c = tv.giaima(btList[index].Dapan3);
                string d = tv.giaima(btList[index].Dapan4);
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            diemthi = 0;
            foreach (baitap bt in btList)
            {
                if (bt.Dapanchon.ToString() == tv.giaima(bt.Dapandung))
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
