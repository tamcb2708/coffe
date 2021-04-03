using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QL_sinhvien
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string sql = "select * from tb_sinhvien";
            DataTable mytable = KN.E_SQL(sql);
            dgv.DataSource = mytable;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SINHVIEN1DataSet.tb_lop' table. You can move, or remove it, as needed.
            this.tb_lopTableAdapter.Fill(this.qL_SINHVIEN1DataSet.tb_lop);
            LoadData();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_lopTableAdapter.FillBy(this.qL_SINHVIEN1DataSet.tb_lop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private Boolean ParseB(string _input)
        {
            bool _result =true;
            if (_input.Trim() == "1")
                _result = true;
             else 
             if (_input.Trim() == "0")
                _result = false;
            return _result;
             
        }

        private string ParseBool2string (bool _input)
        {
            string _result ="1";
            if (_input == true)
                _result = "1";
            else
            if (_input == false)
                _result = "0";
            return _result;
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rd1.Checked = false;
            rd2.Checked = false;
            
            int i;
            i = dgv.CurrentRow.Index;
            tb_msv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_tensv.Text = dgv.Rows[i].Cells[2].Value.ToString();
            dTP_ns.Text = dgv.Rows[i].Cells[3].Value.ToString();
            if (ParseB(dgv.Rows[i].Cells[4].Value.ToString()) == true)
                rd1.Checked = true; 
            else 
                rd2.Checked = true; 
            tb_dt.Text = dgv.Rows[i].Cells[5].Value.ToString();
            tb_dc.Text = dgv.Rows[i].Cells[6].Value.ToString();
            cb_lop.Text = dgv.Rows[i].Cells[7].Value.ToString();
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            string value = tb_timkiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                string sql = "select * from tb_sinhvien where msv='" + tb_timkiem.Text + "'";
                DataTable mytable = KN.E_SQL(sql);
                dgv.DataSource = mytable;
            }
            else LoadData();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tb_sinhvien where msv='"+tb_msv.Text+"'";
            KN.ExecuteNonquery_Pro(sql);
            LoadData();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string sql = " update tb_sinhvien set msv='"+tb_msv.Text+"', tensv=N'"+tb_tensv.Text+"',ngaysinh='"+dTP_ns.Text+"',gioitinh='"+ParseBool2string(rd1.Checked)+"',dienthoai='"+tb_dt.Text+"',diachi=N'"+tb_dc.Text+"',malop='"+cb_lop.Text+"'where msv='"+tb_msv.Text+"'";
            KN.ExecuteNonquery_Pro(sql);
            LoadData();
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into tb_sinhvien(msv , tensv , ngaysinh ,gioitinh, dienthoai ,diachi , malop) values('"+tb_msv.Text+"','"+tb_tensv.Text+"','" + dTP_ns.Text+"','"+ ParseBool2string(rd1.Checked)+"','"+tb_dt.Text+"','"+tb_dc.Text+"','"+cb_lop.Text+"')";
            KN.Nonquery(sql);
            LoadData();
        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dTP_ns_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
