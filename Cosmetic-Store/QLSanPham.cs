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
	public partial class QLSanPham : UserControl
	{
		SanPhamBLL spdal = new SanPhamBLL();
		List<SanPham> list = new List<SanPham>();
		static bool isDeleting = false, isUpdating = false, isAdding = false;


		public QLSanPham()
		{
			InitializeComponent();
			LoadSP();
		}

		private void LoadSP()
		{
			list = spdal.GetAllSP();
			//dgvSanPham.DataSource = list;
			for (int i = 0; i < list.Count; i++)
			{
				DataGridViewRow newRow = new DataGridViewRow();
				newRow.CreateCells(dgvSanPham);
				newRow.Cells[0].Value = list[i].ProductID;
				newRow.Cells[1].Value = list[i].ProductName;
				newRow.Cells[2].Value = list[i].CategoryID;
				newRow.Cells[3].Value = list[i].ProviderID;
				dgvSanPham.Rows.Add(newRow);

			}

			txtMaSP.Text = spdal.AutoID().ToString();
			// Cập nhật hiện ẩn các nút cần thiết
			btnHuy.Enabled = false;
			btnXacNhan.Enabled = false;
			btnThem.Enabled = true;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
			txtTenSP.Enabled = true;
			cbbMaLSP.Enabled = true;
			cbbMaNCC.Enabled = true;

		}

		private void RefreshTxt()
		{
			txtMaSP.Text = spdal.AutoID().ToString();
			txtTenSP.Text = "";
			cbbMaLSP.Text = string.Empty;
			txtTenLoai.Text = "";
			cbbMaNCC.Text = string.Empty;
			txtTenNCC.Text = "";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtTenSP.Text) || String.IsNullOrWhiteSpace(cbbMaLSP.SelectedItem.ToString()) || String.IsNullOrWhiteSpace(cbbMaNCC.SelectedItem.ToString()))
			{
				MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (!spdal.KiemTraTrung(Convert.ToInt32(txtMaSP.Text)))
			{
				MessageBox.Show("Sản phẩm bị trùng mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				isAdding = true;
				btnHuy.Enabled = true;
				btnXacNhan.Enabled = true;
				btnThem.Enabled = false;
				btnSua.Enabled = false;
				btnXoa.Enabled = false;
				txtTenSP.Enabled = false;
				cbbMaLSP.Enabled = false;
				cbbMaNCC.Enabled = false;
			}
		}


		private void btnSua_Click(object sender, EventArgs e)
		{
			//Kiểm tra thông tin nhập
			if (String.IsNullOrWhiteSpace(txtMaSP.Text))
			{
				MessageBox.Show("Bạn chưa chọn sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (String.IsNullOrWhiteSpace(txtTenSP.Text) || String.IsNullOrWhiteSpace(cbbMaLSP.SelectedItem.ToString()) || String.IsNullOrWhiteSpace(cbbMaNCC.SelectedItem.ToString()))
			{
				MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (spdal.KiemTraTrung(Convert.ToInt32(txtMaSP.Text)))
			{
				MessageBox.Show("Sản phẩm không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			else
			{
				isUpdating = true;
				btnHuy.Enabled = true;
				btnXacNhan.Enabled = true;
				btnThem.Enabled = false;
				btnSua.Enabled = false;
				btnXoa.Enabled = false;
				txtTenSP.Enabled = false;
				cbbMaLSP.Enabled = false;
				cbbMaNCC.Enabled = false;
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtMaSP.Text))
			{
				MessageBox.Show("Bạn chưa chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (spdal.KiemTraTrung(Convert.ToInt32(txtMaSP.Text)))
			{
				MessageBox.Show("Không tìm thấy sản phẩm phải xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			if (isAdding)
			{
				SanPham sanPham = new SanPham(Convert.ToInt32(spdal.AutoID()), txtTenSP.Text, Convert.ToInt32(cbbMaLSP.SelectedItem), Convert.ToInt32(cbbMaNCC.SelectedItem) );
				MessageBox.Show(spdal.Them(sanPham), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadSP();
				RefreshTxt();
				isAdding = false;
			}

			else if (isUpdating)
			{
				SanPham sanPham = new SanPham(Convert.ToInt32(txtMaSP.Text), txtTenSP.Text, Convert.ToInt32(cbbMaLSP.SelectedItem), Convert.ToInt32(cbbMaNCC.SelectedItem));
				MessageBox.Show(spdal.Sua(sanPham), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadSP();
				RefreshTxt();
				isUpdating = false;
			}

			else if (isDeleting)
			{
				MessageBox.Show(spdal.Xoa(Convert.ToInt32(txtMaSP.Text)), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadSP();
				RefreshTxt();
				isDeleting = false;
			}

		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadSP();
			RefreshTxt();
			
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			LoadSP();
			RefreshTxt();
			isDeleting = false;
			isAdding = false;
			isUpdating = false;
		}

		private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int i;
			i = dgvSanPham.CurrentRow.Index;
			txtMaSP.Text = dgvSanPham.Rows[i].Cells[0].Value.ToString();
			txtTenSP.Text = dgvSanPham.Rows[i].Cells[1].Value.ToString();
			cbbMaLSP.Text = dgvSanPham.Rows[i].Cells[2].Value.ToString();
			txtTenLoai.Text = spdal.GetCategoryName((int)dgvSanPham.Rows[i].Cells[2].Value);
			cbbMaNCC.Text = dgvSanPham.Rows[i].Cells[3].Value.ToString();
			txtTenNCC.Text = spdal.GetProviderName((int)dgvSanPham.Rows[i].Cells[3].Value);
		}
	}
}
