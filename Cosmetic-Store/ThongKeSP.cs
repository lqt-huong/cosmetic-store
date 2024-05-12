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

	public partial class ThongKeSP : UserControl
	{
		ThongKeKhoBLL tkkbll = new ThongKeKhoBLL();
		List<ThongKeKho> list = new List<ThongKeKho>();
		public ThongKeSP()
		{
			InitializeComponent();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			list = tkkbll.TimKiem(dateFrom.Value, dateTo.Value);

			if (list.Count < 1)
			{
				MessageBox.Show("Không tìm thấy kết quả tìm kiếm hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				dgvSanPham.DataSource = list;
			}
		}

	}
}
