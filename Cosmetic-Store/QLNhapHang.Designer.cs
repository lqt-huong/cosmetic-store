namespace Cosmetic_Store
{
	partial class QLNhapHang
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvCTHDN = new System.Windows.Forms.DataGridView();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.groupBox_TTSanPham = new System.Windows.Forms.GroupBox();
			this.txtTenNCC = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtMaDSP = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtMaSP = new System.Windows.Forms.TextBox();
			this.txtTenSP = new System.Windows.Forms.TextBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.btnThem = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtGiaNhap = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dgvSanPham = new System.Windows.Forms.DataGridView();
			this.VarietyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QuantityKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cbbNCC = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.txtMaPN = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ImportBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductVarietyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).BeginInit();
			this.groupBox_TTSanPham.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCTHDN
			// 
			this.dgvCTHDN.AllowUserToAddRows = false;
			this.dgvCTHDN.AllowUserToOrderColumns = true;
			this.dgvCTHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCTHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImportBillID,
            this.ProductVarietyID,
            this.Quantity,
            this.ImportPrice});
			this.dgvCTHDN.GridColor = System.Drawing.Color.White;
			this.dgvCTHDN.Location = new System.Drawing.Point(6, 345);
			this.dgvCTHDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvCTHDN.Name = "dgvCTHDN";
			this.dgvCTHDN.RowHeadersWidth = 62;
			this.dgvCTHDN.Size = new System.Drawing.Size(786, 182);
			this.dgvCTHDN.TabIndex = 44;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(508, 535);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(284, 34);
			this.btnSave.TabIndex = 58;
			this.btnSave.Text = "Lưu phiếu nhập";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.ForeColor = System.Drawing.Color.White;
			this.btnHuy.Location = new System.Drawing.Point(407, 535);
			this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(79, 34);
			this.btnHuy.TabIndex = 59;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// groupBox_TTSanPham
			// 
			this.groupBox_TTSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(214)))));
			this.groupBox_TTSanPham.Controls.Add(this.txtTenNCC);
			this.groupBox_TTSanPham.Controls.Add(this.label12);
			this.groupBox_TTSanPham.Controls.Add(this.txtTongTien);
			this.groupBox_TTSanPham.Controls.Add(this.label4);
			this.groupBox_TTSanPham.Controls.Add(this.label3);
			this.groupBox_TTSanPham.Controls.Add(this.groupBox1);
			this.groupBox_TTSanPham.Controls.Add(this.dateTimePicker1);
			this.groupBox_TTSanPham.Controls.Add(this.cbbNCC);
			this.groupBox_TTSanPham.Controls.Add(this.label7);
			this.groupBox_TTSanPham.Controls.Add(this.txtMaNV);
			this.groupBox_TTSanPham.Controls.Add(this.txtMaPN);
			this.groupBox_TTSanPham.Controls.Add(this.label9);
			this.groupBox_TTSanPham.Controls.Add(this.label2);
			this.groupBox_TTSanPham.Controls.Add(this.label1);
			this.groupBox_TTSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_TTSanPham.ForeColor = System.Drawing.Color.White;
			this.groupBox_TTSanPham.Location = new System.Drawing.Point(5, 8);
			this.groupBox_TTSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox_TTSanPham.Name = "groupBox_TTSanPham";
			this.groupBox_TTSanPham.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox_TTSanPham.Size = new System.Drawing.Size(790, 327);
			this.groupBox_TTSanPham.TabIndex = 60;
			this.groupBox_TTSanPham.TabStop = false;
			this.groupBox_TTSanPham.Text = "Tổng tiền:";
			// 
			// txtTenNCC
			// 
			this.txtTenNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenNCC.Location = new System.Drawing.Point(380, 70);
			this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTenNCC.Name = "txtTenNCC";
			this.txtTenNCC.Size = new System.Drawing.Size(111, 25);
			this.txtTenNCC.TabIndex = 57;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(258, 73);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(120, 17);
			this.label12.TabIndex = 56;
			this.label12.Text = "Tên nhà cung cấp:";
			// 
			// txtTongTien
			// 
			this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTongTien.Location = new System.Drawing.Point(638, 70);
			this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.Size = new System.Drawing.Size(133, 25);
			this.txtTongTien.TabIndex = 55;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(553, 74);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 17);
			this.label4.TabIndex = 54;
			this.label4.Text = "Tổng tiền:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(552, 39);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 17);
			this.label3.TabIndex = 53;
			this.label3.Text = "Ngày nhập:";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.groupBox1.Controls.Add(this.txtMaDSP);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtMaSP);
			this.groupBox1.Controls.Add(this.txtTenSP);
			this.groupBox1.Controls.Add(this.btnXoa);
			this.groupBox1.Controls.Add(this.btnSua);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtGiaNhap);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dgvSanPham);
			this.groupBox1.Controls.Add(this.txtSoLuong);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(7, 103);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 217);
			this.groupBox1.TabIndex = 43;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin sản phẩm trong phiếu nhập";
			// 
			// txtMaDSP
			// 
			this.txtMaDSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaDSP.Location = new System.Drawing.Point(641, 12);
			this.txtMaDSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaDSP.Name = "txtMaDSP";
			this.txtMaDSP.Size = new System.Drawing.Size(128, 25);
			this.txtMaDSP.TabIndex = 64;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(530, 14);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 17);
			this.label11.TabIndex = 63;
			this.label11.Text = "Mã DSP";
			// 
			// txtMaSP
			// 
			this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaSP.Location = new System.Drawing.Point(641, 45);
			this.txtMaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaSP.Name = "txtMaSP";
			this.txtMaSP.Size = new System.Drawing.Size(128, 25);
			this.txtMaSP.TabIndex = 62;
			// 
			// txtTenSP
			// 
			this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenSP.Location = new System.Drawing.Point(641, 79);
			this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTenSP.Name = "txtTenSP";
			this.txtTenSP.Size = new System.Drawing.Size(128, 25);
			this.txtTenSP.TabIndex = 61;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Location = new System.Drawing.Point(690, 178);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(65, 31);
			this.btnXoa.TabIndex = 60;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.White;
			this.btnSua.Location = new System.Drawing.Point(620, 178);
			this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(65, 31);
			this.btnSua.TabIndex = 59;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(530, 47);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(95, 17);
			this.label10.TabIndex = 58;
			this.label10.Text = "Mã sản phẩm:";
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.White;
			this.btnThem.Location = new System.Drawing.Point(549, 178);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(65, 31);
			this.btnThem.TabIndex = 57;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(529, 81);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 17);
			this.label6.TabIndex = 56;
			this.label6.Text = "Tên sản phẩm:";
			// 
			// txtGiaNhap
			// 
			this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGiaNhap.Location = new System.Drawing.Point(641, 112);
			this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtGiaNhap.Name = "txtGiaNhap";
			this.txtGiaNhap.Size = new System.Drawing.Size(128, 25);
			this.txtGiaNhap.TabIndex = 55;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(530, 116);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 17);
			this.label5.TabIndex = 54;
			this.label5.Text = "Giá nhập:";
			// 
			// dgvSanPham
			// 
			this.dgvSanPham.AllowUserToAddRows = false;
			this.dgvSanPham.AllowUserToOrderColumns = true;
			this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarietyID,
            this.ProductID,
            this.QuantityKho,
            this.Volume,
            this.Price});
			this.dgvSanPham.GridColor = System.Drawing.Color.White;
			this.dgvSanPham.Location = new System.Drawing.Point(5, 25);
			this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvSanPham.Name = "dgvSanPham";
			this.dgvSanPham.RowHeadersWidth = 62;
			this.dgvSanPham.Size = new System.Drawing.Size(515, 188);
			this.dgvSanPham.TabIndex = 1;
			this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
			// 
			// VarietyID
			// 
			this.VarietyID.HeaderText = "Mã DSP";
			this.VarietyID.MinimumWidth = 8;
			this.VarietyID.Name = "VarietyID";
			this.VarietyID.Width = 60;
			// 
			// ProductID
			// 
			this.ProductID.HeaderText = "Mã sản phẩm";
			this.ProductID.Name = "ProductID";
			this.ProductID.Width = 80;
			// 
			// QuantityKho
			// 
			this.QuantityKho.HeaderText = "Số lượng tồn";
			this.QuantityKho.MinimumWidth = 8;
			this.QuantityKho.Name = "QuantityKho";
			this.QuantityKho.Width = 70;
			// 
			// Volume
			// 
			this.Volume.HeaderText = "Dung tích";
			this.Volume.MinimumWidth = 8;
			this.Volume.Name = "Volume";
			// 
			// Price
			// 
			this.Price.HeaderText = "Giá bán";
			this.Price.Name = "Price";
			this.Price.Width = 130;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoLuong.Location = new System.Drawing.Point(641, 146);
			this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(128, 25);
			this.txtSoLuong.TabIndex = 19;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(530, 151);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 17);
			this.label8.TabIndex = 7;
			this.label8.Text = "Số lượng:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(638, 36);
			this.dateTimePicker1.MaxDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
			this.dateTimePicker1.MinDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(133, 23);
			this.dateTimePicker1.TabIndex = 52;
			this.dateTimePicker1.Value = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
			// 
			// cbbNCC
			// 
			this.cbbNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbNCC.FormattingEnabled = true;
			this.cbbNCC.Location = new System.Drawing.Point(124, 70);
			this.cbbNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbbNCC.Name = "cbbNCC";
			this.cbbNCC.Size = new System.Drawing.Size(113, 25);
			this.cbbNCC.TabIndex = 30;
			this.cbbNCC.SelectedIndexChanged += new System.EventHandler(this.cbbNCC_SelectedIndexChanged);
			this.cbbNCC.SelectionChangeCommitted += new System.EventHandler(this.cbbNCC_SelectionChangeCommitted);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(1403, 74);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 21);
			this.label7.TabIndex = 25;
			// 
			// txtMaNV
			// 
			this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNV.Location = new System.Drawing.Point(380, 34);
			this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(111, 25);
			this.txtMaNV.TabIndex = 14;
			// 
			// txtMaPN
			// 
			this.txtMaPN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaPN.Location = new System.Drawing.Point(124, 34);
			this.txtMaPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMaPN.Name = "txtMaPN";
			this.txtMaPN.Size = new System.Drawing.Size(113, 25);
			this.txtMaPN.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(13, 73);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 17);
			this.label9.TabIndex = 8;
			this.label9.Text = "Nhà cung cấp:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(258, 37);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Người phụ trách:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 36);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã phiếu nhập:";
			// 
			// ImportBillID
			// 
			this.ImportBillID.HeaderText = "Mã HDN";
			this.ImportBillID.Name = "ImportBillID";
			// 
			// ProductVarietyID
			// 
			this.ProductVarietyID.HeaderText = "Mã DSP";
			this.ProductVarietyID.Name = "ProductVarietyID";
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Số lượng";
			this.Quantity.Name = "Quantity";
			// 
			// ImportPrice
			// 
			this.ImportPrice.HeaderText = "Giá nhập";
			this.ImportPrice.Name = "ImportPrice";
			// 
			// QLNhapHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox_TTSanPham);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dgvCTHDN);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "QLNhapHang";
			this.Size = new System.Drawing.Size(798, 576);
			((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).EndInit();
			this.groupBox_TTSanPham.ResumeLayout(false);
			this.groupBox_TTSanPham.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvCTHDN;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.GroupBox groupBox_TTSanPham;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtGiaNhap;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgvSanPham;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cbbNCC;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.TextBox txtMaPN;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.TextBox txtMaSP;
		private System.Windows.Forms.TextBox txtTenSP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.DataGridViewTextBoxColumn VarietyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuantityKho;
		private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.TextBox txtMaDSP;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtTenNCC;
		private System.Windows.Forms.DataGridViewTextBoxColumn ImportBillID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductVarietyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ImportPrice;
	}
}
