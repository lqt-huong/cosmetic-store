
namespace Cosmetic_Store
{
    partial class QuanLyKho
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.TSMenu_QLSanPham = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMenu_QLNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMenu_QLNhapHang = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMenu_ThongKeKho = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlQLKho = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.White;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenu_QLSanPham,
            this.TSMenu_QLNhaCungCap,
            this.TSMenu_QLNhapHang,
            this.TSMenu_ThongKeKho});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(798, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// TSMenu_QLSanPham
			// 
			this.TSMenu_QLSanPham.BackColor = System.Drawing.Color.White;
			this.TSMenu_QLSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TSMenu_QLSanPham.ForeColor = System.Drawing.Color.Black;
			this.TSMenu_QLSanPham.Name = "TSMenu_QLSanPham";
			this.TSMenu_QLSanPham.Size = new System.Drawing.Size(115, 20);
			this.TSMenu_QLSanPham.Text = "Quản lý sản phẩm";
			this.TSMenu_QLSanPham.Click += new System.EventHandler(this.TSMenu_QLSanPham_Click);
			// 
			// TSMenu_QLNhaCungCap
			// 
			this.TSMenu_QLNhaCungCap.BackColor = System.Drawing.Color.White;
			this.TSMenu_QLNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TSMenu_QLNhaCungCap.ForeColor = System.Drawing.Color.Black;
			this.TSMenu_QLNhaCungCap.Name = "TSMenu_QLNhaCungCap";
			this.TSMenu_QLNhaCungCap.Size = new System.Drawing.Size(135, 20);
			this.TSMenu_QLNhaCungCap.Text = "Quản lý nhà cung cấp";
			this.TSMenu_QLNhaCungCap.Click += new System.EventHandler(this.TSMenu_QLNhaCungCap_Click);
			// 
			// TSMenu_QLNhapHang
			// 
			this.TSMenu_QLNhapHang.BackColor = System.Drawing.Color.White;
			this.TSMenu_QLNhapHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TSMenu_QLNhapHang.ForeColor = System.Drawing.Color.Black;
			this.TSMenu_QLNhapHang.Name = "TSMenu_QLNhapHang";
			this.TSMenu_QLNhapHang.Size = new System.Drawing.Size(120, 20);
			this.TSMenu_QLNhapHang.Text = "Quản lý nhập hàng";
			// 
			// TSMenu_ThongKeKho
			// 
			this.TSMenu_ThongKeKho.BackColor = System.Drawing.Color.White;
			this.TSMenu_ThongKeKho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TSMenu_ThongKeKho.ForeColor = System.Drawing.Color.Black;
			this.TSMenu_ThongKeKho.Name = "TSMenu_ThongKeKho";
			this.TSMenu_ThongKeKho.Size = new System.Drawing.Size(71, 20);
			this.TSMenu_ThongKeKho.Text = "Thống kê";
			// 
			// pnlQLKho
			// 
			this.pnlQLKho.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlQLKho.Location = new System.Drawing.Point(0, 24);
			this.pnlQLKho.Name = "pnlQLKho";
			this.pnlQLKho.Size = new System.Drawing.Size(798, 526);
			this.pnlQLKho.TabIndex = 1;
			this.pnlQLKho.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQLKho_Paint);
			// 
			// QuanLyKho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pnlQLKho);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "QuanLyKho";
			this.Size = new System.Drawing.Size(798, 550);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_QLSanPham;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_QLNhaCungCap;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_QLNhapHang;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_ThongKeKho;
		private System.Windows.Forms.Panel pnlQLKho;
	}
}
