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

namespace QL_sinhvien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ANKGFLN\SQLEXPRESS;Initial Catalog=QL_SINHVIEN1;Integrated Security=True");

            try
            {
                con.Open();
                string sql = "select * from tb_nguoidung where taikhoan ='" + textBox1.Text + "' and matkhau='" + textBox2.Text + "'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader sqlDataReader = com.ExecuteReader();
                if( sqlDataReader.Read()== true)
                {
                    ChucNang cn = new ChucNang();
                    cn.Show();
                    MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối !");
            }
        }
    }
}
