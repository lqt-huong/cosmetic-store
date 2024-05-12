
namespace Cosmetic_Store
{
    partial class QuanLyTaiKhoan
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabQLTaiKhoan = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbxPhanQuyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPermissionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabQLPhanQuyen = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxMaChucNang = new System.Windows.Forms.ComboBox();
            this.btnXacNhanCT = new System.Windows.Forms.Button();
            this.btnHuyCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.txtTenChucNang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.colMaPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChiTietPhanQuyen = new System.Windows.Forms.DataGridView();
            this.colMaPQ_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCN_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatPQ = new System.Windows.Forms.Button();
            this.btnXacNhanPQ = new System.Windows.Forms.Button();
            this.btnHuyPQ = new System.Windows.Forms.Button();
            this.btnXoaPQ = new System.Windows.Forms.Button();
            this.btnThemPQ = new System.Windows.Forms.Button();
            this.txtTenPhanQuyen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhanQuyen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabQLTaiKhoan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.tabQLPhanQuyen.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhanQuyen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabQLTaiKhoan);
            this.tabControl.Controls.Add(this.tabQLPhanQuyen);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(840, 570);
            this.tabControl.TabIndex = 1;
            // 
            // tabQLTaiKhoan
            // 
            this.tabQLTaiKhoan.Controls.Add(this.groupBox1);
            this.tabQLTaiKhoan.Controls.Add(this.dgvTaiKhoan);
            this.tabQLTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabQLTaiKhoan.Location = new System.Drawing.Point(4, 44);
            this.tabQLTaiKhoan.Name = "tabQLTaiKhoan";
            this.tabQLTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLTaiKhoan.Size = new System.Drawing.Size(832, 522);
            this.tabQLTaiKhoan.TabIndex = 0;
            this.tabQLTaiKhoan.Text = "Quản lý tài khoản";
            this.tabQLTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(214)))));
            this.groupBox1.Controls.Add(this.dgvNhanVien);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbxPhanQuyen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(396, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 523);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colNgaySinh,
            this.colDiaChi});
            this.dgvNhanVien.Location = new System.Drawing.Point(23, 166);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(391, 150);
            this.dgvNhanVien.TabIndex = 14;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXacNhan.Location = new System.Drawing.Point(198, 476);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(105, 30);
            this.btnXacNhan.TabIndex = 13;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHuy.Location = new System.Drawing.Point(309, 476);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 30);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(309, 440);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 30);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCapNhat.Location = new System.Drawing.Point(198, 440);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(105, 30);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(87, 440);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 30);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxPhanQuyen
            // 
            this.cbxPhanQuyen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxPhanQuyen.FormattingEnabled = true;
            this.cbxPhanQuyen.Location = new System.Drawing.Point(172, 332);
            this.cbxPhanQuyen.Name = "cbxPhanQuyen";
            this.cbxPhanQuyen.Size = new System.Drawing.Size(242, 40);
            this.cbxPhanQuyen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(19, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phân quyền";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(337, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Chọn NV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaNhanVien.Location = new System.Drawing.Point(172, 122);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(159, 39);
            this.txtMaNhanVien.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhân viên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMatKhau.Location = new System.Drawing.Point(172, 76);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(242, 39);
            this.txtMatKhau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(172, 32);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(242, 39);
            this.txtTenTaiKhoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colPassword,
            this.colStaffID,
            this.colPermissionID});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(6, 6);
            this.dgvTaiKhoan.MultiSelect = false;
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(384, 523);
            this.dgvTaiKhoan.TabIndex = 1;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Tên tài khoản";
            this.colUsername.MinimumWidth = 8;
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            this.colUsername.Width = 150;
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "Mật khẩu";
            this.colPassword.MinimumWidth = 8;
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Width = 150;
            // 
            // colStaffID
            // 
            this.colStaffID.HeaderText = "Mã nhân viên";
            this.colStaffID.MinimumWidth = 8;
            this.colStaffID.Name = "colStaffID";
            this.colStaffID.ReadOnly = true;
            this.colStaffID.Width = 150;
            // 
            // colPermissionID
            // 
            this.colPermissionID.HeaderText = "Mã phân quyền";
            this.colPermissionID.MinimumWidth = 8;
            this.colPermissionID.Name = "colPermissionID";
            this.colPermissionID.ReadOnly = true;
            this.colPermissionID.Width = 150;
            // 
            // tabQLPhanQuyen
            // 
            this.tabQLPhanQuyen.Controls.Add(this.groupBox3);
            this.tabQLPhanQuyen.Controls.Add(this.dgvPhanQuyen);
            this.tabQLPhanQuyen.Controls.Add(this.dgvChiTietPhanQuyen);
            this.tabQLPhanQuyen.Controls.Add(this.groupBox2);
            this.tabQLPhanQuyen.Location = new System.Drawing.Point(4, 44);
            this.tabQLPhanQuyen.Name = "tabQLPhanQuyen";
            this.tabQLPhanQuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLPhanQuyen.Size = new System.Drawing.Size(832, 522);
            this.tabQLPhanQuyen.TabIndex = 1;
            this.tabQLPhanQuyen.Text = "Quản lý phân quyền";
            this.tabQLPhanQuyen.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(214)))));
            this.groupBox3.Controls.Add(this.cbxMaChucNang);
            this.groupBox3.Controls.Add(this.btnXacNhanCT);
            this.groupBox3.Controls.Add(this.btnHuyCT);
            this.groupBox3.Controls.Add(this.btnXoaCT);
            this.groupBox3.Controls.Add(this.btnThemCT);
            this.groupBox3.Controls.Add(this.txtTenChucNang);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(466, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 198);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chỉnh sửa chi tiết quyền";
            // 
            // cbxMaChucNang
            // 
            this.cbxMaChucNang.FormattingEnabled = true;
            this.cbxMaChucNang.Location = new System.Drawing.Point(164, 38);
            this.cbxMaChucNang.Name = "cbxMaChucNang";
            this.cbxMaChucNang.Size = new System.Drawing.Size(190, 40);
            this.cbxMaChucNang.TabIndex = 14;
            this.cbxMaChucNang.SelectionChangeCommitted += new System.EventHandler(this.cbxMaChucNang_SelectionChangeCommitted);
            // 
            // btnXacNhanCT
            // 
            this.btnXacNhanCT.Enabled = false;
            this.btnXacNhanCT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXacNhanCT.Location = new System.Drawing.Point(138, 156);
            this.btnXacNhanCT.Name = "btnXacNhanCT";
            this.btnXacNhanCT.Size = new System.Drawing.Size(105, 30);
            this.btnXacNhanCT.TabIndex = 13;
            this.btnXacNhanCT.Text = "Xác nhận";
            this.btnXacNhanCT.UseVisualStyleBackColor = true;
            this.btnXacNhanCT.Click += new System.EventHandler(this.btnXacNhanCT_Click);
            // 
            // btnHuyCT
            // 
            this.btnHuyCT.Enabled = false;
            this.btnHuyCT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHuyCT.Location = new System.Drawing.Point(249, 156);
            this.btnHuyCT.Name = "btnHuyCT";
            this.btnHuyCT.Size = new System.Drawing.Size(105, 30);
            this.btnHuyCT.TabIndex = 12;
            this.btnHuyCT.Text = "Hủy";
            this.btnHuyCT.UseVisualStyleBackColor = true;
            this.btnHuyCT.Click += new System.EventHandler(this.btnHuyCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaCT.Location = new System.Drawing.Point(249, 120);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(105, 30);
            this.btnXoaCT.TabIndex = 11;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemCT.Location = new System.Drawing.Point(138, 120);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(105, 30);
            this.btnThemCT.TabIndex = 9;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // txtTenChucNang
            // 
            this.txtTenChucNang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenChucNang.Location = new System.Drawing.Point(164, 76);
            this.txtTenChucNang.Name = "txtTenChucNang";
            this.txtTenChucNang.Size = new System.Drawing.Size(190, 39);
            this.txtTenChucNang.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(19, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên chức năng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(19, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã chức năng";
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.AllowUserToAddRows = false;
            this.dgvPhanQuyen.AllowUserToDeleteRows = false;
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPQ,
            this.colTenPQ});
            this.dgvPhanQuyen.Location = new System.Drawing.Point(3, 6);
            this.dgvPhanQuyen.MultiSelect = false;
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.ReadOnly = true;
            this.dgvPhanQuyen.RowHeadersWidth = 62;
            this.dgvPhanQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanQuyen.Size = new System.Drawing.Size(433, 319);
            this.dgvPhanQuyen.TabIndex = 5;
            this.dgvPhanQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanQuyen_CellClick);
            // 
            // colMaPQ
            // 
            this.colMaPQ.HeaderText = "Mã phân quyền";
            this.colMaPQ.Name = "colMaPQ";
            this.colMaPQ.ReadOnly = true;
            this.colMaPQ.Width = 160;
            // 
            // colTenPQ
            // 
            this.colTenPQ.HeaderText = "Tên phân quyền";
            this.colTenPQ.Name = "colTenPQ";
            this.colTenPQ.ReadOnly = true;
            this.colTenPQ.Width = 300;
            // 
            // dgvChiTietPhanQuyen
            // 
            this.dgvChiTietPhanQuyen.AllowUserToAddRows = false;
            this.dgvChiTietPhanQuyen.AllowUserToDeleteRows = false;
            this.dgvChiTietPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPQ_CT,
            this.colMaCN_CT});
            this.dgvChiTietPhanQuyen.Location = new System.Drawing.Point(466, 6);
            this.dgvChiTietPhanQuyen.MultiSelect = false;
            this.dgvChiTietPhanQuyen.Name = "dgvChiTietPhanQuyen";
            this.dgvChiTietPhanQuyen.ReadOnly = true;
            this.dgvChiTietPhanQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPhanQuyen.Size = new System.Drawing.Size(360, 319);
            this.dgvChiTietPhanQuyen.TabIndex = 4;
            this.dgvChiTietPhanQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhanQuyen_CellClick);
            // 
            // colMaPQ_CT
            // 
            this.colMaPQ_CT.HeaderText = "Mã phân quyền";
            this.colMaPQ_CT.Name = "colMaPQ_CT";
            this.colMaPQ_CT.ReadOnly = true;
            this.colMaPQ_CT.Width = 170;
            // 
            // colMaCN_CT
            // 
            this.colMaCN_CT.HeaderText = "Mã chức năng";
            this.colMaCN_CT.Name = "colMaCN_CT";
            this.colMaCN_CT.ReadOnly = true;
            this.colMaCN_CT.Width = 170;
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(214)))));
            this.groupBox2.Controls.Add(this.btnCapNhatPQ);
            this.groupBox2.Controls.Add(this.btnXacNhanPQ);
            this.groupBox2.Controls.Add(this.btnHuyPQ);
            this.groupBox2.Controls.Add(this.btnXoaPQ);
            this.groupBox2.Controls.Add(this.btnThemPQ);
            this.groupBox2.Controls.Add(this.txtTenPhanQuyen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMaPhanQuyen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(6, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 198);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phân quyền";
            // 
            // btnCapNhatPQ
            // 
            this.btnCapNhatPQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCapNhatPQ.Location = new System.Drawing.Point(198, 120);
            this.btnCapNhatPQ.Name = "btnCapNhatPQ";
            this.btnCapNhatPQ.Size = new System.Drawing.Size(105, 30);
            this.btnCapNhatPQ.TabIndex = 14;
            this.btnCapNhatPQ.Text = "Cập nhật";
            this.btnCapNhatPQ.UseVisualStyleBackColor = true;
            this.btnCapNhatPQ.Click += new System.EventHandler(this.btnCapNhatPQ_Click);
            // 
            // btnXacNhanPQ
            // 
            this.btnXacNhanPQ.Enabled = false;
            this.btnXacNhanPQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXacNhanPQ.Location = new System.Drawing.Point(198, 156);
            this.btnXacNhanPQ.Name = "btnXacNhanPQ";
            this.btnXacNhanPQ.Size = new System.Drawing.Size(105, 30);
            this.btnXacNhanPQ.TabIndex = 13;
            this.btnXacNhanPQ.Text = "Xác nhận";
            this.btnXacNhanPQ.UseVisualStyleBackColor = true;
            this.btnXacNhanPQ.Click += new System.EventHandler(this.btnXacNhanPQ_Click);
            // 
            // btnHuyPQ
            // 
            this.btnHuyPQ.Enabled = false;
            this.btnHuyPQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHuyPQ.Location = new System.Drawing.Point(309, 156);
            this.btnHuyPQ.Name = "btnHuyPQ";
            this.btnHuyPQ.Size = new System.Drawing.Size(105, 30);
            this.btnHuyPQ.TabIndex = 12;
            this.btnHuyPQ.Text = "Hủy";
            this.btnHuyPQ.UseVisualStyleBackColor = true;
            this.btnHuyPQ.Click += new System.EventHandler(this.btnHuyPQ_Click);
            // 
            // btnXoaPQ
            // 
            this.btnXoaPQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaPQ.Location = new System.Drawing.Point(309, 120);
            this.btnXoaPQ.Name = "btnXoaPQ";
            this.btnXoaPQ.Size = new System.Drawing.Size(105, 30);
            this.btnXoaPQ.TabIndex = 11;
            this.btnXoaPQ.Text = "Xóa";
            this.btnXoaPQ.UseVisualStyleBackColor = true;
            this.btnXoaPQ.Click += new System.EventHandler(this.btnXoaPQ_Click);
            // 
            // btnThemPQ
            // 
            this.btnThemPQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemPQ.Location = new System.Drawing.Point(87, 120);
            this.btnThemPQ.Name = "btnThemPQ";
            this.btnThemPQ.Size = new System.Drawing.Size(105, 30);
            this.btnThemPQ.TabIndex = 9;
            this.btnThemPQ.Text = "Thêm";
            this.btnThemPQ.UseVisualStyleBackColor = true;
            this.btnThemPQ.Click += new System.EventHandler(this.btnThemPQ_Click);
            // 
            // txtTenPhanQuyen
            // 
            this.txtTenPhanQuyen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenPhanQuyen.Location = new System.Drawing.Point(198, 76);
            this.txtTenPhanQuyen.Name = "txtTenPhanQuyen";
            this.txtTenPhanQuyen.Size = new System.Drawing.Size(216, 39);
            this.txtTenPhanQuyen.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(19, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên phân quyền";
            // 
            // txtMaPhanQuyen
            // 
            this.txtMaPhanQuyen.Enabled = false;
            this.txtMaPhanQuyen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaPhanQuyen.Location = new System.Drawing.Point(198, 32);
            this.txtMaPhanQuyen.Name = "txtMaPhanQuyen";
            this.txtMaPhanQuyen.Size = new System.Drawing.Size(216, 39);
            this.txtMaPhanQuyen.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(19, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã phân quyền";
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 250;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "QuanLyTaiKhoan";
            this.Size = new System.Drawing.Size(846, 576);
            this.tabControl.ResumeLayout(false);
            this.tabQLTaiKhoan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.tabQLPhanQuyen.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhanQuyen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabQLTaiKhoan;
        private System.Windows.Forms.TabPage tabQLPhanQuyen;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbxPhanQuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhanQuyen;
        private System.Windows.Forms.DataGridView dgvChiTietPhanQuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXacNhanPQ;
        private System.Windows.Forms.Button btnHuyPQ;
        private System.Windows.Forms.Button btnXoaPQ;
        private System.Windows.Forms.Button btnThemPQ;
        private System.Windows.Forms.TextBox txtTenPhanQuyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhanQuyen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxMaChucNang;
        private System.Windows.Forms.Button btnXacNhanCT;
        private System.Windows.Forms.Button btnHuyCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.TextBox txtTenChucNang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPermissionID;
        private System.Windows.Forms.Button btnCapNhatPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPQ_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCN_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    }
}
