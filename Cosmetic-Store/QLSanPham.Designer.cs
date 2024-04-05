namespace Cosmetic_Store
{
	partial class QLSanPham
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvSanPham = new System.Windows.Forms.DataGridView();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PriceImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox_TTSanPham = new System.Windows.Forms.GroupBox();
			this.txtGiaBan = new System.Windows.Forms.TextBox();
			this.txtGiaNhap = new System.Windows.Forms.TextBox();
			this.txtPhanLoai = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNhaCC = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.txtDungTich = new System.Windows.Forms.TextBox();
			this.txtTenSP = new System.Windows.Forms.TextBox();
			this.txtIDSP = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox_TimKiem = new System.Windows.Forms.GroupBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
			this.panel2.SuspendLayout();
			this.groupBox_TTSanPham.SuspendLayout();
			this.groupBox_TimKiem.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvSanPham);
			this.panel1.Location = new System.Drawing.Point(13, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(771, 266);
			this.panel1.TabIndex = 3;
			// 
			// dgvSanPham
			// 
			this.dgvSanPham.AllowUserToAddRows = false;
			this.dgvSanPham.AllowUserToDeleteRows = false;
			this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Volume,
            this.Category,
            this.PriceImport,
            this.priceSale,
            this.Quantity,
            this.Provider});
			this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSanPham.GridColor = System.Drawing.Color.White;
			this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
			this.dgvSanPham.Name = "dgvSanPham";
			this.dgvSanPham.ReadOnly = true;
			this.dgvSanPham.Size = new System.Drawing.Size(771, 266);
			this.dgvSanPham.TabIndex = 0;
			// 
			// ProductID
			// 
			this.ProductID.HeaderText = "Mã SP";
			this.ProductID.Name = "ProductID";
			this.ProductID.ReadOnly = true;
			this.ProductID.Width = 50;
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "Tên Sản Phẩm";
			this.ProductName.Name = "ProductName";
			this.ProductName.ReadOnly = true;
			this.ProductName.Width = 200;
			// 
			// Volume
			// 
			this.Volume.HeaderText = "Dung Tích";
			this.Volume.Name = "Volume";
			this.Volume.ReadOnly = true;
			this.Volume.Width = 70;
			// 
			// Category
			// 
			this.Category.HeaderText = "Phân Loại";
			this.Category.Name = "Category";
			this.Category.ReadOnly = true;
			// 
			// PriceImport
			// 
			this.PriceImport.HeaderText = "Giá nhập";
			this.PriceImport.Name = "PriceImport";
			this.PriceImport.ReadOnly = true;
			this.PriceImport.Width = 80;
			// 
			// priceSale
			// 
			this.priceSale.HeaderText = "Giá bán";
			this.priceSale.Name = "priceSale";
			this.priceSale.ReadOnly = true;
			this.priceSale.Width = 80;
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Số lượng";
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
			this.Quantity.Width = 50;
			// 
			// Provider
			// 
			this.Provider.HeaderText = "Nhà cung cấp";
			this.Provider.Name = "Provider";
			this.Provider.ReadOnly = true;
			this.Provider.Width = 97;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox_TTSanPham);
			this.panel2.Location = new System.Drawing.Point(13, 374);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(771, 142);
			this.panel2.TabIndex = 5;
			// 
			// groupBox_TTSanPham
			// 
			this.groupBox_TTSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(214)))));
			this.groupBox_TTSanPham.Controls.Add(this.txtGiaBan);
			this.groupBox_TTSanPham.Controls.Add(this.txtGiaNhap);
			this.groupBox_TTSanPham.Controls.Add(this.txtPhanLoai);
			this.groupBox_TTSanPham.Controls.Add(this.label7);
			this.groupBox_TTSanPham.Controls.Add(this.label6);
			this.groupBox_TTSanPham.Controls.Add(this.label5);
			this.groupBox_TTSanPham.Controls.Add(this.label4);
			this.groupBox_TTSanPham.Controls.Add(this.txtNhaCC);
			this.groupBox_TTSanPham.Controls.Add(this.txtSoLuong);
			this.groupBox_TTSanPham.Controls.Add(this.txtDungTich);
			this.groupBox_TTSanPham.Controls.Add(this.txtTenSP);
			this.groupBox_TTSanPham.Controls.Add(this.txtIDSP);
			this.groupBox_TTSanPham.Controls.Add(this.label9);
			this.groupBox_TTSanPham.Controls.Add(this.label8);
			this.groupBox_TTSanPham.Controls.Add(this.label3);
			this.groupBox_TTSanPham.Controls.Add(this.label2);
			this.groupBox_TTSanPham.Controls.Add(this.label1);
			this.groupBox_TTSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_TTSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_TTSanPham.ForeColor = System.Drawing.Color.White;
			this.groupBox_TTSanPham.Location = new System.Drawing.Point(0, 0);
			this.groupBox_TTSanPham.Name = "groupBox_TTSanPham";
			this.groupBox_TTSanPham.Size = new System.Drawing.Size(771, 142);
			this.groupBox_TTSanPham.TabIndex = 3;
			this.groupBox_TTSanPham.TabStop = false;
			this.groupBox_TTSanPham.Text = "Thông tin sản phẩm";
			// 
			// txtGiaBan
			// 
			this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGiaBan.Location = new System.Drawing.Point(618, 72);
			this.txtGiaBan.Name = "txtGiaBan";
			this.txtGiaBan.Size = new System.Drawing.Size(133, 25);
			this.txtGiaBan.TabIndex = 28;
			// 
			// txtGiaNhap
			// 
			this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGiaNhap.Location = new System.Drawing.Point(365, 71);
			this.txtGiaNhap.Name = "txtGiaNhap";
			this.txtGiaNhap.Size = new System.Drawing.Size(142, 25);
			this.txtGiaNhap.TabIndex = 27;
			// 
			// txtPhanLoai
			// 
			this.txtPhanLoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhanLoai.Location = new System.Drawing.Point(117, 70);
			this.txtPhanLoai.Name = "txtPhanLoai";
			this.txtPhanLoai.Size = new System.Drawing.Size(115, 25);
			this.txtPhanLoai.TabIndex = 26;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(842, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 21);
			this.label7.TabIndex = 25;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(521, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 17);
			this.label6.TabIndex = 24;
			this.label6.Text = "Giá bán:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(243, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 17);
			this.label5.TabIndex = 23;
			this.label5.Text = "Giá nhập:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 17);
			this.label4.TabIndex = 22;
			this.label4.Text = "Phân loại:";
			// 
			// txtNhaCC
			// 
			this.txtNhaCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNhaCC.Location = new System.Drawing.Point(365, 107);
			this.txtNhaCC.Name = "txtNhaCC";
			this.txtNhaCC.Size = new System.Drawing.Size(142, 25);
			this.txtNhaCC.TabIndex = 20;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoLuong.Location = new System.Drawing.Point(117, 105);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(115, 25);
			this.txtSoLuong.TabIndex = 19;
			// 
			// txtDungTich
			// 
			this.txtDungTich.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDungTich.Location = new System.Drawing.Point(618, 37);
			this.txtDungTich.Name = "txtDungTich";
			this.txtDungTich.Size = new System.Drawing.Size(133, 25);
			this.txtDungTich.TabIndex = 15;
			// 
			// txtTenSP
			// 
			this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenSP.Location = new System.Drawing.Point(365, 35);
			this.txtTenSP.Name = "txtTenSP";
			this.txtTenSP.Size = new System.Drawing.Size(142, 25);
			this.txtTenSP.TabIndex = 14;
			// 
			// txtIDSP
			// 
			this.txtIDSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIDSP.Location = new System.Drawing.Point(117, 35);
			this.txtIDSP.Name = "txtIDSP";
			this.txtIDSP.Size = new System.Drawing.Size(115, 25);
			this.txtIDSP.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(243, 111);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 17);
			this.label9.TabIndex = 8;
			this.label9.Text = "Nhà cung cấp:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(20, 110);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 17);
			this.label8.TabIndex = 7;
			this.label8.Text = "Số lượng:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(521, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Dung tích:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(243, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên sản phẩm:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã sản phẩm:";
			// 
			// groupBox_TimKiem
			// 
			this.groupBox_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(214)))));
			this.groupBox_TimKiem.Controls.Add(this.btnRefresh);
			this.groupBox_TimKiem.Controls.Add(this.btnTim);
			this.groupBox_TimKiem.Controls.Add(this.textBox1);
			this.groupBox_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_TimKiem.Location = new System.Drawing.Point(13, 6);
			this.groupBox_TimKiem.Name = "groupBox_TimKiem";
			this.groupBox_TimKiem.Size = new System.Drawing.Size(734, 57);
			this.groupBox_TimKiem.TabIndex = 39;
			this.groupBox_TimKiem.TabStop = false;
			this.groupBox_TimKiem.Text = "Tìm kiếm sản phẩm";
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.ForeColor = System.Drawing.Color.White;
			this.btnRefresh.Location = new System.Drawing.Point(601, 22);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(94, 29);
			this.btnRefresh.TabIndex = 2;
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.UseVisualStyleBackColor = false;
			// 
			// btnTim
			// 
			this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.Location = new System.Drawing.Point(459, 22);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(65, 29);
			this.btnTim.TabIndex = 1;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(40, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(422, 29);
			this.textBox1.TabIndex = 0;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.Black;
			this.btnThem.Location = new System.Drawing.Point(53, 341);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(144, 30);
			this.btnThem.TabIndex = 34;
			this.btnThem.Text = "Thêm sản phẩm";
			this.btnThem.UseVisualStyleBackColor = false;
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.Black;
			this.btnSua.Location = new System.Drawing.Point(353, 341);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(144, 30);
			this.btnSua.TabIndex = 35;
			this.btnSua.Text = "Chỉnh sửa sản phẩm";
			this.btnSua.UseVisualStyleBackColor = false;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.Black;
			this.btnXoa.Location = new System.Drawing.Point(203, 341);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(144, 30);
			this.btnXoa.TabIndex = 36;
			this.btnXoa.Text = "Xóa sản phẩm";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapNhat.ForeColor = System.Drawing.Color.White;
			this.btnCapNhat.Location = new System.Drawing.Point(537, 341);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(102, 30);
			this.btnCapNhat.TabIndex = 37;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = false;
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.ForeColor = System.Drawing.Color.White;
			this.btnHuy.Location = new System.Drawing.Point(645, 341);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(102, 30);
			this.btnHuy.TabIndex = 38;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = false;
			// 
			// QLSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox_TimKiem);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnCapNhat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "QLSanPham";
			this.Size = new System.Drawing.Size(798, 526);
			this.Load += new System.EventHandler(this.QLSanPham_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
			this.panel2.ResumeLayout(false);
			this.groupBox_TTSanPham.ResumeLayout(false);
			this.groupBox_TTSanPham.PerformLayout();
			this.groupBox_TimKiem.ResumeLayout(false);
			this.groupBox_TimKiem.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvSanPham;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox_TTSanPham;
		private System.Windows.Forms.TextBox txtGiaBan;
		private System.Windows.Forms.TextBox txtGiaNhap;
		private System.Windows.Forms.TextBox txtPhanLoai;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNhaCC;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.TextBox txtDungTich;
		private System.Windows.Forms.TextBox txtTenSP;
		private System.Windows.Forms.TextBox txtIDSP;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
		private System.Windows.Forms.DataGridViewTextBoxColumn Category;
		private System.Windows.Forms.DataGridViewTextBoxColumn PriceImport;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceSale;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Provider;
		private System.Windows.Forms.GroupBox groupBox_TimKiem;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnHuy;
	}
}
