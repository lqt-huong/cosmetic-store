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
	public partial class QLNhaCungCap : UserControl
	{
		NhaCungCapBLL nccbll = new NhaCungCapBLL();
		List<NhaCungCap> list = new List<NhaCungCap>();
		static bool isDeleting = false, isUpdating = false, isAdding = false;

		public QLNhaCungCap()
		{
			InitializeComponent();
			LoadNCC();
		}

		private void RefreshTxt()
		{
			txtMaNCC.Text = nccbll.AutoID().ToString();
			txtTenNCC.Text = "";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtTenNCC.Text))
			{
				MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (!nccbll.KiemTraTrung(Convert.ToInt32(txtMaNCC.Text)))
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

		private void btnSua_Click(object sender, EventArgs e)
		{
			//Kiểm tra thông tin nhập
			if (String.IsNullOrWhiteSpace(txtMaNCC.Text))
			{
				MessageBox.Show("Bạn chưa chọn ncc cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (String.IsNullOrWhiteSpace(txtMaNCC.Text) ||  String.IsNullOrWhiteSpace(txtTenNCC.Text))
			{
				MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (nccbll.KiemTraTrung(Convert.ToInt32(txtMaNCC.Text)))
			{
				MessageBox.Show(" Nha cung cap không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtMaNCC.Text))
			{
				MessageBox.Show("Bạn chưa chọn ncc cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (nccbll.KiemTraTrung(Convert.ToInt32(txtMaNCC.Text)))
			{
				MessageBox.Show("Không tìm thấy ncc phải xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				NhaCungCap nc = new NhaCungCap(Convert.ToInt32(nccbll.AutoID()), txtTenNCC.Text, 0);
				MessageBox.Show(nccbll.Them(nc), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadNCC();
				RefreshTxt();
				isAdding = false;
			}

			else if (isUpdating)
			{
				NhaCungCap nc = new NhaCungCap(Convert.ToInt32(txtMaNCC.Text), txtTenNCC.Text, 0);
				MessageBox.Show(nccbll.Sua(nc), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadNCC();
				RefreshTxt();
				isUpdating = false;
			}

			else if (isDeleting)
			{
				MessageBox.Show(nccbll.Xoa(Convert.ToInt32(txtMaNCC.Text)), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadNCC();
				RefreshTxt();
				isDeleting = false;
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			LoadNCC();
			RefreshTxt();
			isDeleting = false;
			isAdding = false;
			isUpdating = false;
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			string key = txtTimKiem.Text.Trim(new char[] { ' ' });
			if (String.IsNullOrWhiteSpace(key))
			{
				MessageBox.Show("Thanh tìm kiếm trống vui lòng nhập thông tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			else
			{

				list = nccbll.TimKiem(key);

				if (list.Count < 1)
				{
					MessageBox.Show("Không tìm thấy kết quả tìm kiếm hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					dgvNCC.DataSource = list;
				}
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{

			LoadNCC();
			RefreshTxt();
		}

		private void LoadNCC()
		{
			list = nccbll.GetAllNCC();
			//dgvNCC.DataSource = list;
			for (int i = 0; i < list.Count; i++)
			{
				DataGridViewRow newRow = new DataGridViewRow();
				newRow.CreateCells(dgvNCC);
				newRow.Cells[0].Value = list[i].ProviderID;
				newRow.Cells[1].Value = list[i].ProviderName;

				dgvNCC.Rows.Add(newRow);
			}

			txtMaNCC.Text = nccbll.AutoID().ToString();
			// Cập nhật hiện ẩn các nút cần thiết
			btnHuy.Enabled = false;
			btnXacNhan.Enabled = false;
			btnThem.Enabled = true;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
		} 

		private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int i;
			i = dgvNCC.CurrentRow.Index;
			txtMaNCC.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
			txtTenNCC.Text = dgvNCC.Rows[i].Cells[1].Value.ToString();
		}
	}
}
