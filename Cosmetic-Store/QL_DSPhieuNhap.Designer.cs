namespace Cosmetic_Store
{
	partial class QL_DSPhieuNhap
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
			this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
			this.ImportBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProviderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnTaoPhieuNhap = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.DateNgayNhap = new System.Windows.Forms.DateTimePicker();
			this.txtTenNCC = new System.Windows.Forms.TextBox();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaNCC = new System.Windows.Forms.TextBox();
			this.txtMaPN = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvPhieuNhap
			// 
			this.dgvPhieuNhap.AllowUserToAddRows = false;
			this.dgvPhieuNhap.AllowUserToOrderColumns = true;
			this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImportBillID,
            this.ProviderID,
            this.Date,
            this.TotalValue,
            this.StaffID});
			this.dgvPhieuNhap.GridColor = System.Drawing.Color.White;
			this.dgvPhieuNhap.Location = new System.Drawing.Point(15, 84);
			this.dgvPhieuNhap.Name = "dgvPhieuNhap";
			this.dgvPhieuNhap.RowHeadersWidth = 62;
			this.dgvPhieuNhap.Size = new System.Drawing.Size(771, 226);
			this.dgvPhieuNhap.TabIndex = 1;
			this.dgvPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellContentClick);
			// 
			// ImportBillID
			// 
			this.ImportBillID.HeaderText = "Mã phiếu nhập";
			this.ImportBillID.MinimumWidth = 8;
			this.ImportBillID.Name = "ImportBillID";
			this.ImportBillID.Width = 80;
			// 
			// ProviderID
			// 
			this.ProviderID.HeaderText = "Mã nhà cung cấp";
			this.ProviderID.MinimumWidth = 8;
			this.ProviderID.Name = "ProviderID";
			this.ProviderID.Width = 200;
			// 
			// Date
			// 
			this.Date.HeaderText = "Ngày nhập";
			this.Date.MinimumWidth = 8;
			this.Date.Name = "Date";
			this.Date.Width = 110;
			// 
			// TotalValue
			// 
			this.TotalValue.HeaderText = "Tổng tiền";
			this.TotalValue.MinimumWidth = 8;
			this.TotalValue.Name = "TotalValue";
			this.TotalValue.Width = 110;
			// 
			// StaffID
			// 
			this.StaffID.HeaderText = "Nhân viên nhập";
			this.StaffID.MinimumWidth = 8;
			this.StaffID.Name = "StaffID";
			this.StaffID.Width = 200;
			// 
			// btnTaoPhieuNhap
			// 
			this.btnTaoPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnTaoPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTaoPhieuNhap.ForeColor = System.Drawing.Color.White;
			this.btnTaoPhieuNhap.Location = new System.Drawing.Point(613, 16);
			this.btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
			this.btnTaoPhieuNhap.Size = new System.Drawing.Size(171, 33);
			this.btnTaoPhieuNhap.TabIndex = 42;
			this.btnTaoPhieuNhap.Text = "Tạo phiếu nhập";
			this.btnTaoPhieuNhap.UseVisualStyleBackColor = false;
			this.btnTaoPhieuNhap.Click += new System.EventHandler(this.btnTaoPhieuNhap_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(214)))));
			this.groupBox1.Controls.Add(this.txtTongTien);
			this.groupBox1.Controls.Add(this.DateNgayNhap);
			this.groupBox1.Controls.Add(this.txtTenNCC);
			this.groupBox1.Controls.Add(this.txtTenNV);
			this.groupBox1.Controls.Add(this.txtMaNV);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtMaNCC);
			this.groupBox1.Controls.Add(this.txtMaPN);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(13, 342);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(771, 147);
			this.groupBox1.TabIndex = 43;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chi tiết phiếu nhập";
			// 
			// txtTongTien
			// 
			this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTongTien.Location = new System.Drawing.Point(626, 39);
			this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.Size = new System.Drawing.Size(141, 27);
			this.txtTongTien.TabIndex = 13;
			// 
			// DateNgayNhap
			// 
			this.DateNgayNhap.Enabled = false;
			this.DateNgayNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateNgayNhap.Location = new System.Drawing.Point(502, 85);
			this.DateNgayNhap.Margin = new System.Windows.Forms.Padding(2);
			this.DateNgayNhap.Name = "DateNgayNhap";
			this.DateNgayNhap.Size = new System.Drawing.Size(100, 27);
			this.DateNgayNhap.TabIndex = 12;
			// 
			// txtTenNCC
			// 
			this.txtTenNCC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenNCC.Location = new System.Drawing.Point(388, 39);
			this.txtTenNCC.Margin = new System.Windows.Forms.Padding(2);
			this.txtTenNCC.Name = "txtTenNCC";
			this.txtTenNCC.Size = new System.Drawing.Size(149, 27);
			this.txtTenNCC.TabIndex = 11;
			// 
			// txtTenNV
			// 
			this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenNV.Location = new System.Drawing.Point(235, 86);
			this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(157, 27);
			this.txtTenNV.TabIndex = 10;
			// 
			// txtMaNV
			// 
			this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNV.Location = new System.Drawing.Point(83, 84);
			this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(60, 27);
			this.txtMaNV.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(160, 88);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 20);
			this.label7.TabIndex = 8;
			this.label7.Text = "Tên NV:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(549, 44);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "Tổng tiền:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(308, 44);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Tên NCC:";
			// 
			// txtMaNCC
			// 
			this.txtMaNCC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNCC.Location = new System.Drawing.Point(235, 39);
			this.txtMaNCC.Margin = new System.Windows.Forms.Padding(2);
			this.txtMaNCC.Name = "txtMaNCC";
			this.txtMaNCC.Size = new System.Drawing.Size(60, 27);
			this.txtMaNCC.TabIndex = 5;
			// 
			// txtMaPN
			// 
			this.txtMaPN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaPN.Location = new System.Drawing.Point(83, 39);
			this.txtMaPN.Margin = new System.Windows.Forms.Padding(2);
			this.txtMaPN.Name = "txtMaPN";
			this.txtMaPN.Size = new System.Drawing.Size(60, 27);
			this.txtMaPN.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(410, 88);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ngày nhập:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 88);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mã NV:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(160, 44);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã NNC:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 44);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã PN:";
			// 
			// QL_DSPhieuNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnTaoPhieuNhap);
			this.Controls.Add(this.dgvPhieuNhap);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "QL_DSPhieuNhap";
			this.Size = new System.Drawing.Size(798, 526);
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPhieuNhap;
		private System.Windows.Forms.Button btnTaoPhieuNhap;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtMaNCC;
		private System.Windows.Forms.TextBox txtMaPN;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenNV;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTenNCC;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.DateTimePicker DateNgayNhap;
		private System.Windows.Forms.DataGridViewTextBoxColumn ImportBillID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProviderID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
	}
}
