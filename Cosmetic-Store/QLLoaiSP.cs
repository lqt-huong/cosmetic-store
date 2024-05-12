using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;

namespace Cosmetic_Store
{
	public partial class QLLoaiSP : UserControl
	{
		LoaiSPBLL lspBLL = new LoaiSPBLL();
		List<LoaiSP> list = new List<LoaiSP>();
		static bool isDeleting = false, isUpdating = false, isAdding = false;


		private void LoadLSP()
		{
			list = lspBLL.getAllLoaiSP();
			dgvLSP.DataSource = list;

			txtMaLSP.Text = lspBLL.AutoID().ToString();
			// Cập nhật hiện ẩn các nút cần thiết
			btnHuy.Enabled = false;
			btnXacNhan.Enabled = false;
			btnThem.Enabled = true;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{

			if (String.IsNullOrWhiteSpace(txtTenLSP.Text))
			{
				MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (!lspBLL.KiemTraTrung(Convert.ToInt32(txtMaLSP.Text)))
			{
				MessageBox.Show("Bị trùng mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				isAdding = true;
				btnHuy.Enabled = true;
				btnXacNhan.Enabled = true;
				btnThem.Enabled = false;
				btnSua.Enabled = false;
				btnXoa.Enabled = false;
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{

			if (String.IsNullOrWhiteSpace(txtMaLSP.Text))
			{
				MessageBox.Show("Bạn chưa chọn lsp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (lspBLL.KiemTraTrung(Convert.ToInt32(txtMaLSP.Text)))
			{
				MessageBox.Show("Không tìm thấy lsp phải xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				isDeleting = true;
				btnHuy.Enabled = true;
				btnXacNhan.Enabled = true;
				btnThem.Enabled = false;
				btnSua.Enabled = false;
				btnXoa.Enabled = false;
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtMaLSP.Text))
			{
				MessageBox.Show("Bạn chưa chọn lsp cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (String.IsNullOrWhiteSpace(txtMaLSP.Text) || String.IsNullOrWhiteSpace(txtTenLSP.Text))
			{
				MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (lspBLL.KiemTraTrung(Convert.ToInt32(txtMaLSP.Text)))
			{
				MessageBox.Show("Loai sp không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			else
			{
				isUpdating = true;
				btnHuy.Enabled = true;
				btnXacNhan.Enabled = true;
				btnThem.Enabled = false;
				btnSua.Enabled = false;
				btnXoa.Enabled = false;
			}
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			if (isAdding)
			{
				txtSLSP.Text = "0";
				LoaiSP nc = new LoaiSP(Convert.ToInt32(lspBLL.AutoID()), txtTenLSP.Text, Convert.ToInt32(txtSLSP.Text), 0);
				MessageBox.Show(lspBLL.Them(nc), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadLSP();
				RefreshTxt();
				isAdding = false;
			}

			else if (isUpdating)
			{
				LoaiSP nc = new LoaiSP(Convert.ToInt32(txtMaLSP.Text), txtTenLSP.Text, Convert.ToInt32(txtSLSP.Text), 0);
				MessageBox.Show(lspBLL.Sua(nc), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadLSP();
				RefreshTxt();
				isUpdating = false;
			}

			else if (isDeleting)
			{
				MessageBox.Show(lspBLL.Xoa(Convert.ToInt32(txtMaLSP.Text)), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadLSP();
				RefreshTxt();
				isDeleting = false;
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			LoadLSP();
			RefreshTxt();
			isDeleting = false;
			isAdding = false;
			isUpdating = false;

		}

		public QLLoaiSP()
		{
			InitializeComponent();
		}

		private void RefreshTxt()
		{
			txtMaLSP.Text = lspBLL.AutoID().ToString();
			txtTenLSP.Text = "";
			txtSLSP.Text = "";
		}


	}
}
