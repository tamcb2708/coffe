namespace QL_sinhvien
{
    partial class SinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_msv = new System.Windows.Forms.TextBox();
            this.tb_tensv = new System.Windows.Forms.TextBox();
            this.tb_dt = new System.Windows.Forms.TextBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.tb_dc = new System.Windows.Forms.TextBox();
            this.dTP_ns = new System.Windows.Forms.DateTimePicker();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.tblopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SINHVIEN1DataSet = new QL_sinhvien.QL_SINHVIEN1DataSet();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_lopTableAdapter = new QL_sinhvien.QL_SINHVIEN1DataSetTableAdapters.tb_lopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SINHVIEN1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày sinh :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã Lớp :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tìm kiếm mã sinh viên :";
            // 
            // tb_msv
            // 
            this.tb_msv.Location = new System.Drawing.Point(134, 32);
            this.tb_msv.Margin = new System.Windows.Forms.Padding(2);
            this.tb_msv.Name = "tb_msv";
            this.tb_msv.Size = new System.Drawing.Size(134, 20);
            this.tb_msv.TabIndex = 8;
            // 
            // tb_tensv
            // 
            this.tb_tensv.Location = new System.Drawing.Point(133, 64);
            this.tb_tensv.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tensv.Name = "tb_tensv";
            this.tb_tensv.Size = new System.Drawing.Size(134, 20);
            this.tb_tensv.TabIndex = 9;
            // 
            // tb_dt
            // 
            this.tb_dt.Location = new System.Drawing.Point(133, 97);
            this.tb_dt.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dt.Name = "tb_dt";
            this.tb_dt.Size = new System.Drawing.Size(134, 20);
            this.tb_dt.TabIndex = 10;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(481, 133);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(182, 20);
            this.tb_timkiem.TabIndex = 11;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // tb_dc
            // 
            this.tb_dc.Location = new System.Drawing.Point(133, 137);
            this.tb_dc.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dc.Name = "tb_dc";
            this.tb_dc.Size = new System.Drawing.Size(224, 20);
            this.tb_dc.TabIndex = 12;
            // 
            // dTP_ns
            // 
            this.dTP_ns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_ns.Location = new System.Drawing.Point(418, 32);
            this.dTP_ns.Margin = new System.Windows.Forms.Padding(2);
            this.dTP_ns.Name = "dTP_ns";
            this.dTP_ns.Size = new System.Drawing.Size(151, 20);
            this.dTP_ns.TabIndex = 13;
            this.dTP_ns.ValueChanged += new System.EventHandler(this.dTP_ns_ValueChanged);
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(418, 64);
            this.rd1.Margin = new System.Windows.Forms.Padding(2);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(47, 17);
            this.rd1.TabIndex = 14;
            this.rd1.TabStop = true;
            this.rd1.Text = "Nam";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(525, 65);
            this.rd2.Margin = new System.Windows.Forms.Padding(2);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(39, 17);
            this.rd2.TabIndex = 15;
            this.rd2.TabStop = true;
            this.rd2.Text = "Nữ";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(418, 99);
            this.cb_lop.Margin = new System.Windows.Forms.Padding(2);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(151, 21);
            this.cb_lop.TabIndex = 16;
            this.cb_lop.SelectedIndexChanged += new System.EventHandler(this.cb_lop_SelectedIndexChanged);
            // 
            // tblopBindingSource
            // 
            this.tblopBindingSource.DataMember = "tb_lop";
            this.tblopBindingSource.DataSource = this.qL_SINHVIEN1DataSet;
            // 
            // qL_SINHVIEN1DataSet
            // 
            this.qL_SINHVIEN1DataSet.DataSetName = "QL_SINHVIEN1DataSet";
            this.qL_SINHVIEN1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(38, 168);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(623, 211);
            this.dgv.TabIndex = 17;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(308, 402);
            this.bt_them.Margin = new System.Windows.Forms.Padding(2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(56, 19);
            this.bt_them.TabIndex = 18;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(406, 402);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(56, 19);
            this.bt_sua.TabIndex = 19;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(504, 404);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(56, 19);
            this.bt_xoa.TabIndex = 20;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(605, 402);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 21;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_lopTableAdapter
            // 
            this.tb_lopTableAdapter.ClearBeforeFill = true;
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 464);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cb_lop);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.rd1);
            this.Controls.Add(this.dTP_ns);
            this.Controls.Add(this.tb_dc);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.tb_dt);
            this.Controls.Add(this.tb_tensv);
            this.Controls.Add(this.tb_msv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            this.Load += new System.EventHandler(this.SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SINHVIEN1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_msv;
        private System.Windows.Forms.TextBox tb_tensv;
        private System.Windows.Forms.TextBox tb_dt;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.TextBox tb_dc;
        private System.Windows.Forms.DateTimePicker dTP_ns;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button button4;
        private QL_SINHVIEN1DataSet qL_SINHVIEN1DataSet;
        private System.Windows.Forms.BindingSource tblopBindingSource;
        private QL_SINHVIEN1DataSetTableAdapters.tb_lopTableAdapter tb_lopTableAdapter;
    }
}