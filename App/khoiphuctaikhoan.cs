using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App
{
    public partial class khoiphuctaikhoan : Form
    {
        public khoiphuctaikhoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string hoten = textBox1.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = App.Properties.Settings.Default.connectionstring;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            cmd.Connection = con;
            cmd2.Connection = con;
            string sql = "select * from users where username = @username";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 200).Value = hoten;
            cmd.Prepare();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string flag = (string)reader["flag"];
                if (flag == "-1") 
                { 
                string sql3 = "UPDATE users SET flag = '" + "0" + "' where username = @username";
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = con;
                con.Close();
                con.Open();
                cmd3.CommandText = sql3;
                cmd3.Parameters.Add("@username", SqlDbType.NVarChar, 200).Value = hoten;
                cmd3.Prepare();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Mở khóa thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Tài khoản chưa bị khóa mà đòi mở ?", "Thông báo");
                }
            }
            else
            {
                string message = "Kích hoạt thất bại";
                string title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
