
namespace Cosmetic_Store
{
    partial class QLHoaDon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colMaHD_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnXacNhanHD = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 570);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê Doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê Sản Phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(829, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý hóa đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colNgayHD,
            this.colMaNV});
            this.dataGridView1.Location = new System.Drawing.Point(6, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // colMaHD
            // 
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.Width = 150;
            // 
            // colNgayHD
            // 
            this.colNgayHD.HeaderText = "Ngày xuất hàng";
            this.colNgayHD.Name = "colNgayHD";
            this.colNgayHD.Width = 150;
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Nhân viên xuất hàng";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD_CT,
            this.colMaSP,
            this.colSoLuong,
            this.colDonGia});
            this.dataGridView2.Location = new System.Drawing.Point(411, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(412, 263);
            this.dataGridView2.TabIndex = 1;
            // 
            // colMaHD_CT
            // 
            this.colMaHD_CT.HeaderText = "Mã hóa đơn";
            this.colMaHD_CT.Name = "colMaHD_CT";
            // 
            // colMaSP
            // 
            this.colMaSP.HeaderText = "Mã loại sản phẩm";
            this.colMaSP.Name = "colMaSP";
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Giá xuất";
            this.colDonGia.Name = "colDonGia";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(214)))));
            this.groupBox1.Controls.Add(this.btnXacNhanHD);
            this.groupBox1.Controls.Add(this.btnHuyHD);
            this.groupBox1.Controls.Add(this.btnXoaHD);
            this.groupBox1.Controls.Add(this.btnThemHD);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(6, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông tin hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chi tiết hóa đơn";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(194, 28);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(199, 29);
            this.txtTenTaiKhoan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(16, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày xuất";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(16, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã nhân viên";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(193, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 29);
            this.textBox1.TabIndex = 7;
            // 
            // btnXacNhanHD
            // 
            this.btnXacNhanHD.Enabled = false;
            this.btnXacNhanHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXacNhanHD.Location = new System.Drawing.Point(162, 174);
            this.btnXacNhanHD.Name = "btnXacNhanHD";
            this.btnXacNhanHD.Size = new System.Drawing.Size(119, 30);
            this.btnXacNhanHD.TabIndex = 29;
            this.btnXacNhanHD.Text = "Xác nhận";
            this.btnXacNhanHD.UseVisualStyleBackColor = true;
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Enabled = false;
            this.btnHuyHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHuyHD.Location = new System.Drawing.Point(287, 174);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(105, 30);
            this.btnHuyHD.TabIndex = 28;
            this.btnHuyHD.Text = "Hủy";
            this.btnHuyHD.UseVisualStyleBackColor = true;
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaHD.Location = new System.Drawing.Point(287, 138);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(105, 30);
            this.btnXoaHD.TabIndex = 27;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            // 
            // btnThemHD
            // 
            this.btnThemHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemHD.Location = new System.Drawing.Point(162, 138);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(119, 30);
            this.btnThemHD.TabIndex = 26;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(214)))));
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(411, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 219);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(162, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 29;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(287, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 30);
            this.button2.TabIndex = 28;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(287, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 30);
            this.button3.TabIndex = 27;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(38, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 30);
            this.button4.TabIndex = 26;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(194, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 29);
            this.textBox2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(16, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giá xuất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(16, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số lượng";
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox3.Location = new System.Drawing.Point(194, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 29);
            this.textBox3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(16, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã loại sản phẩm";
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox4.Location = new System.Drawing.Point(194, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 29);
            this.textBox4.TabIndex = 30;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(163, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 30);
            this.button5.TabIndex = 31;
            this.button5.Text = "Cập nhật";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // QLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "QLHoaDon";
            this.Size = new System.Drawing.Size(846, 576);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXacNhanHD;
        private System.Windows.Forms.Button btnHuyHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnThemHD;
    }
}
