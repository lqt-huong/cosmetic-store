namespace Cosmetic_Store
{
	partial class ThongKeSP
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
			this.groupBox_TimKiem = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTo = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.dateFrom = new System.Windows.Forms.DateTimePicker();
			this.btnTim = new System.Windows.Forms.Button();
			this.dgvSanPham = new System.Windows.Forms.DataGridView();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox_TimKiem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox_TimKiem
			// 
			this.groupBox_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(214)))));
			this.groupBox_TimKiem.Controls.Add(this.label1);
			this.groupBox_TimKiem.Controls.Add(this.dateTo);
			this.groupBox_TimKiem.Controls.Add(this.label3);
			this.groupBox_TimKiem.Controls.Add(this.dateFrom);
			this.groupBox_TimKiem.Controls.Add(this.btnTim);
			this.groupBox_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_TimKiem.Location = new System.Drawing.Point(11, 13);
			this.groupBox_TimKiem.Name = "groupBox_TimKiem";
			this.groupBox_TimKiem.Size = new System.Drawing.Size(771, 77);
			this.groupBox_TimKiem.TabIndex = 48;
			this.groupBox_TimKiem.TabStop = false;
			this.groupBox_TimKiem.Text = "Thống kê kho hàng";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(364, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 17);
			this.label1.TabIndex = 57;
			this.label1.Text = "đến";
			// 
			// dateTo
			// 
			this.dateTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTo.Location = new System.Drawing.Point(398, 33);
			this.dateTo.Margin = new System.Windows.Forms.Padding(2);
			this.dateTo.MaxDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
			this.dateTo.MinDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
			this.dateTo.Name = "dateTo";
			this.dateTo.Size = new System.Drawing.Size(102, 23);
			this.dateTo.TabIndex = 56;
			this.dateTo.Value = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(147, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 17);
			this.label3.TabIndex = 55;
			this.label3.Text = "Ngày nhập từ :";
			// 
			// dateFrom
			// 
			this.dateFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateFrom.Location = new System.Drawing.Point(260, 33);
			this.dateFrom.Margin = new System.Windows.Forms.Padding(2);
			this.dateFrom.MaxDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
			this.dateFrom.MinDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
			this.dateFrom.Name = "dateFrom";
			this.dateFrom.Size = new System.Drawing.Size(101, 23);
			this.dateFrom.TabIndex = 54;
			this.dateFrom.Value = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
			// 
			// btnTim
			// 
			this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.Location = new System.Drawing.Point(518, 29);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(106, 30);
			this.btnTim.TabIndex = 1;
			this.btnTim.Text = "Thống kê";
			this.btnTim.UseVisualStyleBackColor = false;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// dgvSanPham
			// 
			this.dgvSanPham.AllowUserToAddRows = false;
			this.dgvSanPham.AllowUserToOrderColumns = true;
			this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Volume,
            this.Category,
            this.Date,
            this.ImportPrice,
            this.Price,
            this.Quantity,
            this.Provider});
			this.dgvSanPham.GridColor = System.Drawing.Color.White;
			this.dgvSanPham.Location = new System.Drawing.Point(13, 122);
			this.dgvSanPham.Name = "dgvSanPham";
			this.dgvSanPham.RowHeadersWidth = 62;
			this.dgvSanPham.Size = new System.Drawing.Size(771, 346);
			this.dgvSanPham.TabIndex = 49;
			// 
			// ProductID
			// 
			this.ProductID.HeaderText = "Mã SP";
			this.ProductID.MinimumWidth = 8;
			this.ProductID.Name = "ProductID";
			this.ProductID.Width = 70;
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "Tên sản phẩm";
			this.ProductName.MinimumWidth = 8;
			this.ProductName.Name = "ProductName";
			this.ProductName.Width = 300;
			// 
			// Volume
			// 
			this.Volume.HeaderText = "Dung tích";
			this.Volume.MinimumWidth = 8;
			this.Volume.Name = "Volume";
			this.Volume.Width = 110;
			// 
			// Category
			// 
			this.Category.HeaderText = "Phân loại";
			this.Category.MinimumWidth = 8;
			this.Category.Name = "Category";
			this.Category.Width = 150;
			// 
			// Date
			// 
			this.Date.HeaderText = "Ngày nhập";
			this.Date.Name = "Date";
			// 
			// ImportPrice
			// 
			this.ImportPrice.HeaderText = "Giá nhập";
			this.ImportPrice.MinimumWidth = 8;
			this.ImportPrice.Name = "ImportPrice";
			this.ImportPrice.Width = 115;
			// 
			// Price
			// 
			this.Price.HeaderText = "Giá bán";
			this.Price.MinimumWidth = 8;
			this.Price.Name = "Price";
			this.Price.Width = 115;
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Số lượng";
			this.Quantity.MinimumWidth = 8;
			this.Quantity.Name = "Quantity";
			this.Quantity.Width = 80;
			// 
			// Provider
			// 
			this.Provider.HeaderText = "Nhà cung cấp";
			this.Provider.MinimumWidth = 8;
			this.Provider.Name = "Provider";
			this.Provider.Width = 150;
			// 
			// ThongKeSP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvSanPham);
			this.Controls.Add(this.groupBox_TimKiem);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ThongKeSP";
			this.Size = new System.Drawing.Size(798, 526);
			this.groupBox_TimKiem.ResumeLayout(false);
			this.groupBox_TimKiem.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_TimKiem;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateFrom;
		private System.Windows.Forms.DataGridView dgvSanPham;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
		private System.Windows.Forms.DataGridViewTextBoxColumn Category;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn ImportPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Provider;
	}
}
