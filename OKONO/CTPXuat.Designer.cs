namespace đồ_án
{
    partial class CTPXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTPXuat));
            this.numericUpDown1 = new System.Windows.Forms.TextBox();
            this.txt_tt = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.Label();
            this.txt_mactpx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.Label();
            this.txt_dg = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cTPNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oKONODataSet = new đồ_án.OKONODataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ThongTin = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mah = new System.Windows.Forms.ComboBox();
            this.hangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cTPXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DanhSach = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgv_CTPXuat = new System.Windows.Forms.DataGridView();
            this.MaCTPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPNhapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNhapTableAdapter = new đồ_án.OKONODataSetTableAdapters.CTPNhapTableAdapter();
            this.hangTableAdapter = new đồ_án.OKONODataSetTableAdapters.HangTableAdapter();
            this.cTPXuatTableAdapter = new đồ_án.OKONODataSetTableAdapters.CTPXuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKONODataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXuatBindingSource)).BeginInit();
            this.DanhSach.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTPXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNhapBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(711, 210);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(200, 30);
            this.numericUpDown1.TabIndex = 68;
            this.numericUpDown1.Text = "10%";
            // 
            // txt_tt
            // 
            this.txt_tt.Location = new System.Drawing.Point(238, 299);
            this.txt_tt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tt.Name = "txt_tt";
            this.txt_tt.ReadOnly = true;
            this.txt_tt.Size = new System.Drawing.Size(246, 30);
            this.txt_tt.TabIndex = 67;
            this.txt_tt.TextChanged += new System.EventHandler(this.txt_tt_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoSize = true;
            this.txtMaNV.Location = new System.Drawing.Point(9, 138);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(214, 25);
            this.txtMaNV.TabIndex = 66;
            this.txtMaNV.Text = "Mã Chi Tiết Phiếu Xuất";
            // 
            // txt_mactpx
            // 
            this.txt_mactpx.Location = new System.Drawing.Point(238, 133);
            this.txt_mactpx.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mactpx.Name = "txt_mactpx";
            this.txt_mactpx.Size = new System.Drawing.Size(246, 30);
            this.txt_mactpx.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "Mã Phiếu Xuất";
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(711, 48);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(246, 30);
            this.txt_sl.TabIndex = 59;
            this.txt_sl.ValueChanged += new System.EventHandler(this.txt_sl_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Mã Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Đơn Giá Xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Số Lượng Xuất";
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Location = new System.Drawing.Point(555, 218);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(58, 25);
            this.txtSDT.TabIndex = 47;
            this.txtSDT.Text = "Thuế";
            // 
            // txt_dg
            // 
            this.txt_dg.Location = new System.Drawing.Point(711, 133);
            this.txt_dg.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dg.Name = "txt_dg";
            this.txt_dg.Size = new System.Drawing.Size(246, 30);
            this.txt_dg.TabIndex = 45;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(358, 509);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 57);
            this.button3.TabIndex = 72;
            this.button3.Text = "Sửa";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(44, 509);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 57);
            this.button1.TabIndex = 70;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(835, 509);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 57);
            this.button4.TabIndex = 73;
            this.button4.Text = "Làm Mới";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(610, 509);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 57);
            this.button2.TabIndex = 71;
            this.button2.Text = "Xóa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "CHI TIẾT PHIẾU XUẤT";
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1014, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 34);
            this.button5.TabIndex = 67;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(970, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 34);
            this.button7.TabIndex = 68;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 39;
            // 
            // cTPNhapBindingSource
            // 
            this.cTPNhapBindingSource.DataMember = "CTPNhap";
            this.cTPNhapBindingSource.DataSource = this.oKONODataSet;
            // 
            // oKONODataSet
            // 
            this.oKONODataSet.DataSetName = "OKONODataSet";
            this.oKONODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ThongTin);
            this.tabControl1.Controls.Add(this.DanhSach);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 437);
            this.tabControl1.TabIndex = 69;
            // 
            // ThongTin
            // 
            this.ThongTin.BackColor = System.Drawing.Color.White;
            this.ThongTin.Controls.Add(this.groupBox1);
            this.ThongTin.Location = new System.Drawing.Point(4, 29);
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Padding = new System.Windows.Forms.Padding(3);
            this.ThongTin.Size = new System.Drawing.Size(1031, 404);
            this.ThongTin.TabIndex = 0;
            this.ThongTin.Text = "Thông Tin";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.txt_mah);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.txt_tt);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txt_mactpx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_sl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txt_dg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 348);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu xuất";
            // 
            // txt_mah
            // 
            this.txt_mah.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_mah.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_mah.DataSource = this.hangBindingSource;
            this.txt_mah.DisplayMember = "TenHang";
            this.txt_mah.FormattingEnabled = true;
            this.txt_mah.Location = new System.Drawing.Point(238, 210);
            this.txt_mah.Name = "txt_mah";
            this.txt_mah.Size = new System.Drawing.Size(246, 33);
            this.txt_mah.TabIndex = 72;
            this.txt_mah.ValueMember = "MaHang";
            // 
            // hangBindingSource
            // 
            this.hangBindingSource.DataMember = "Hang";
            this.hangBindingSource.DataSource = this.oKONODataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 71;
            this.label7.Text = "Thành Tiền";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.cTPXuatBindingSource;
            this.comboBox1.DisplayMember = "MaPhieuXuat";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 33);
            this.comboBox1.TabIndex = 70;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cTPXuatBindingSource
            // 
            this.cTPXuatBindingSource.DataMember = "CTPXuat";
            this.cTPXuatBindingSource.DataSource = this.oKONODataSet;
            // 
            // DanhSach
            // 
            this.DanhSach.Controls.Add(this.groupBox2);
            this.DanhSach.Location = new System.Drawing.Point(4, 29);
            this.DanhSach.Name = "DanhSach";
            this.DanhSach.Padding = new System.Windows.Forms.Padding(3);
            this.DanhSach.Size = new System.Drawing.Size(1031, 404);
            this.DanhSach.TabIndex = 1;
            this.DanhSach.Text = "Danh Sách";
            this.DanhSach.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.dgv_CTPXuat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1019, 376);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết phiếu xuất";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(748, 30);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 41);
            this.button6.TabIndex = 6;
            this.button6.Text = "Tìm kiếm";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(216, 41);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(451, 30);
            this.txtTimKiem.TabIndex = 5;
            // 
            // dgv_CTPXuat
            // 
            this.dgv_CTPXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CTPXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTPXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTPX,
            this.SoLuongXuat,
            this.DonGiaXuat,
            this.Thue,
            this.ThanhTien,
            this.MaPhieuXuat});
            this.dgv_CTPXuat.Location = new System.Drawing.Point(23, 96);
            this.dgv_CTPXuat.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_CTPXuat.Name = "dgv_CTPXuat";
            this.dgv_CTPXuat.RowHeadersWidth = 51;
            this.dgv_CTPXuat.Size = new System.Drawing.Size(989, 268);
            this.dgv_CTPXuat.TabIndex = 7;
            this.dgv_CTPXuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CTPXuat_CellContentClick);
            // 
            // MaCTPX
            // 
            this.MaCTPX.DataPropertyName = "MaCTPX";
            this.MaCTPX.HeaderText = "Mã chi tiết phiếu xuất";
            this.MaCTPX.MinimumWidth = 6;
            this.MaCTPX.Name = "MaCTPX";
            this.MaCTPX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.DataPropertyName = "SoLuongXuat";
            this.SoLuongXuat.HeaderText = "Số Lượng Xuất";
            this.SoLuongXuat.MinimumWidth = 6;
            this.SoLuongXuat.Name = "SoLuongXuat";
            // 
            // DonGiaXuat
            // 
            this.DonGiaXuat.DataPropertyName = "DonGiaXuat";
            this.DonGiaXuat.HeaderText = "Đơn Giá Xuất";
            this.DonGiaXuat.Name = "DonGiaXuat";
            // 
            // Thue
            // 
            this.Thue.DataPropertyName = "Thue";
            this.Thue.HeaderText = "Thuế";
            this.Thue.Name = "Thue";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // MaPhieuXuat
            // 
            this.MaPhieuXuat.DataPropertyName = "MaPhieuXuat";
            this.MaPhieuXuat.HeaderText = "Mã Phiếu Xuất";
            this.MaPhieuXuat.Name = "MaPhieuXuat";
            // 
            // cTPNhapBindingSource1
            // 
            this.cTPNhapBindingSource1.DataMember = "CTPNhap";
            this.cTPNhapBindingSource1.DataSource = this.oKONODataSet;
            // 
            // cTPNhapTableAdapter
            // 
            this.cTPNhapTableAdapter.ClearBeforeFill = true;
            // 
            // hangTableAdapter
            // 
            this.hangTableAdapter.ClearBeforeFill = true;
            // 
            // cTPXuatTableAdapter
            // 
            this.cTPXuatTableAdapter.ClearBeforeFill = true;
            // 
            // CTPXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 589);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CTPXuat";
            this.Text = "CTPXuat";
            this.Load += new System.EventHandler(this.CTPXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKONODataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ThongTin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXuatBindingSource)).EndInit();
            this.DanhSach.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTPXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNhapBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numericUpDown1;
        private System.Windows.Forms.TextBox txt_tt;
        private System.Windows.Forms.Label txtMaNV;
        private System.Windows.Forms.TextBox txt_mactpx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_sl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.TextBox txt_dg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource cTPNhapBindingSource;
        private OKONODataSet oKONODataSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ThongTin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txt_mah;
        private System.Windows.Forms.BindingSource cTPNhapBindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage DanhSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgv_CTPXuat;
        private OKONODataSetTableAdapters.CTPNhapTableAdapter cTPNhapTableAdapter;
        private System.Windows.Forms.BindingSource hangBindingSource;
        private OKONODataSetTableAdapters.HangTableAdapter hangTableAdapter;
        private System.Windows.Forms.BindingSource cTPXuatBindingSource;
        private OKONODataSetTableAdapters.CTPXuatTableAdapter cTPXuatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuXuat;
    }
}