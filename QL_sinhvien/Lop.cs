using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_sinhvien
{
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string sql = "select * from tb_lop";
            DataTable mytable = KN.E_SQL(sql);
            dgv1.DataSource = mytable;
        }
        private void Lop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv1.CurrentRow.Index;
            textBox1.Text = dgv1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dgv1.Rows[i].Cells[1].Value.ToString();
        }
    }
}
