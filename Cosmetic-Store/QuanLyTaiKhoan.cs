using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ValueObject;

namespace Cosmetic_Store
{
    public partial class QuanLyTaiKhoan : UserControl
    {
        List<Account> listTK = new List<Account>();
        List<Permission> listPQ = new List<Permission>();
        List<PermissionGranting> listCTPQ = new List<PermissionGranting>();
        List<Function> listCN = new List<Function>();
        List<Staff> listNV = new List<Staff>();

        AccountBLL bllTK = new AccountBLL();
        PermissionBLL bllPQ = new PermissionBLL();
        PermissionGrantingBLL bllCTPQ = new PermissionGrantingBLL();
        FunctionBLL bllCN = new FunctionBLL();
        StaffBLL bllnv = new StaffBLL();


        bool isDeleting = false, isUpdating = false;
        int selectedPermission = -1;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            listTK = bllTK.GetAll();
            listPQ = bllPQ.GetAll();
            listNV = bllnv.GetAllStaffs();
            LoadDataGridTK();
            LoadDataGridPQ();
            LoadComboboxChucNang();
        }

        private void LoadDataGridNV()
        {
            dgvNhanVien.Rows.Clear();
            for (int i = 0; i < listNV.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dgvNhanVien);
                newRow.Cells[0].Value = listNV[i].StaffID;
                newRow.Cells[0].Value = listNV[i].FullName;
                newRow.Cells[0].Value = listNV[i].DoB.ToString();
                newRow.Cells[0].Value = listNV[i].Address;

                dgvNhanVien.Rows.Add(newRow);
            }
        }

        private void LoadDataGridTK()
        {
            dgvTaiKhoan.Rows.Clear();
            for (int i = 0; i < listTK.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dgvTaiKhoan);
                newRow.Cells[0].Value = listTK[i].Username;
                newRow.Cells[1].Value = listTK[i].Password;
                newRow.Cells[2].Value = listTK[i].StaffID;
                newRow.Cells[3].Value = listTK[i].PermissionID;

                dgvTaiKhoan.Rows.Add(newRow);
            }
        }

        private void LoadDataGridPQ()
        {
            dgvPhanQuyen.Rows.Clear();
            for (int i = 0; i < listPQ.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dgvPhanQuyen);
                newRow.Cells[0].Value = listPQ[i].PermissionID;
                newRow.Cells[1].Value = listPQ[i].PermissionName;

                dgvPhanQuyen.Rows.Add(newRow);
            }
        }

        private void LoadDataGridCTPQ(int maPQ)
        {
            listCTPQ = bllCTPQ.GetCTPhanQuyen(maPQ);
            dgvChiTietPhanQuyen.Rows.Clear();
            for (int i = 0; i < listCTPQ.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dgvChiTietPhanQuyen);
                newRow.Cells[0].Value = listCTPQ[i].PermissionID;
                newRow.Cells[1].Value = listCTPQ[i].FunctionID;

                dgvChiTietPhanQuyen.Rows.Add(newRow);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoaPQ_Click(object sender, EventArgs e)
        {
            isDeleting = true;
            btnXacNhanPQ.Enabled = true;
            btnHuyPQ.Enabled = true;
            btnXoaPQ.Enabled = false;
            btnCapNhatPQ.Enabled = false;
            btnThemPQ.Enabled = false;
        }

        private void dgvPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int maPQ = Convert.ToInt32(dgvPhanQuyen.SelectedRows[0].Cells[0].Value);
            txtMaPhanQuyen.Text = dgvPhanQuyen.SelectedRows[0].Cells[0].Value.ToString();
            txtTenPhanQuyen.Text = dgvPhanQuyen.SelectedRows[0].Cells[1].Value.ToString();

            LoadDataGridCTPQ(maPQ);
            selectedPermission = maPQ;


        }

        private void LoadComboboxChucNang()
        {

            listCN = bllCN.GetAll();

            cbxMaChucNang.Items.Clear();
            foreach(Function cn in listCN)
            {
                cbxMaChucNang.Items.Add(cn.FunctionID);
            }
        }

        private void btnHuyPQ_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                isDeleting = false;
                btnXacNhanPQ.Enabled = false;
                btnHuyPQ.Enabled = false;
                btnXoaPQ.Enabled = true;
                btnCapNhatPQ.Enabled = true;
                btnThemPQ.Enabled = true;
            }
            else if (isUpdating)
            {
                isUpdating = false;
                btnXacNhanPQ.Enabled = false;
                btnHuyPQ.Enabled = false;
                btnXoaPQ.Enabled = true;
                btnCapNhatPQ.Enabled = true;
                btnThemPQ.Enabled = true;
            }
        }

        private void btnCapNhatPQ_Click(object sender, EventArgs e)
        {
            isUpdating = true;
            btnXacNhanPQ.Enabled = true;
            btnHuyPQ.Enabled = true;
            btnCapNhatPQ.Enabled = false;
            btnXoaPQ.Enabled = false;
            btnThemPQ.Enabled = false;
        }

        private void btnXacNhanPQ_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                if (String.IsNullOrWhiteSpace(txtMaPhanQuyen.Text))
                {
                    MessageBox.Show("Không được để trống Mã phân quyền!", "Thông báo");
                }
                else
                {
                    MessageBox.Show(bllPQ.Delete(Convert.ToInt32(txtMaPhanQuyen.Text)), "Thông báo");
                    isDeleting = false;
                    btnXacNhanPQ.Enabled = false;
                    btnHuyPQ.Enabled = false;
                    btnXoaPQ.Enabled = true;
                    btnCapNhatPQ.Enabled = true;
                    btnThemPQ.Enabled = true;
                    LoadDataGridPQ();
                }
            }
            else if (isUpdating)
            {
                if (String.IsNullOrWhiteSpace(txtMaPhanQuyen.Text) || String.IsNullOrWhiteSpace(txtTenPhanQuyen.Text))
                {
                    MessageBox.Show("Không được để trống thông tin phân quyền!", "Thông báo");
                }
                else
                {
                    Permission phanQuyen = new Permission(Convert.ToInt32(txtMaPhanQuyen.Text), txtTenPhanQuyen.Text);
                    MessageBox.Show(bllPQ.Update(phanQuyen), "Thông báo");
                    isUpdating = false;
                    btnXacNhanPQ.Enabled = false;
                    btnHuyPQ.Enabled = false;
                    btnCapNhatPQ.Enabled = true;
                    btnXoaPQ.Enabled = true;
                    btnThemPQ.Enabled = true;
                    LoadDataGridPQ();
                }
            }
        }

        private void dgvChiTietPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxMaChucNang.SelectedItem = Convert.ToInt32(dgvPhanQuyen.SelectedRows[0].Cells[0].Value);
            txtTenChucNang.Text = dgvChiTietPhanQuyen.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void cbxMaChucNang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTenChucNang.Text = bllCN.GetTenCN(Convert.ToInt32(cbxMaChucNang.SelectedItem));
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbxMaChucNang.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn chức năng cần thêm!", "Thông báo");
            }
            else if (bllCTPQ.TrungMa(new PermissionGranting(selectedPermission, Convert.ToInt32(cbxMaChucNang.SelectedItem))))
            {
                MessageBox.Show("Chức năng được chọn đã có trong phân quyền!", "Thông báo");
            }
            else
            {
                PermissionGranting phanQuyen = new PermissionGranting(selectedPermission, Convert.ToInt32(cbxMaChucNang.SelectedItem));
                MessageBox.Show(bllCTPQ.Insert(phanQuyen), "Thông báo");
                LoadDataGridCTPQ(selectedPermission);
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            isDeleting = true;

            btnThemCT.Enabled = false;
            btnXoaCT.Enabled = false;
            btnXacNhanCT.Enabled = true;
            btnHuyCT.Enabled = true;
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            if(isDeleting)
            {
                isDeleting = false;

                btnThemCT.Enabled = true;
                btnXoaCT.Enabled = true;
                btnXacNhanCT.Enabled = false;
                btnHuyCT.Enabled = false;
            }
        }

        private void btnXacNhanCT_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbxMaChucNang.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn chức năng cần xóa!", "Thông báo");
            }
            else if (!bllCTPQ.TrungMa(new PermissionGranting(selectedPermission, Convert.ToInt32(cbxMaChucNang.SelectedItem))))
            {
                MessageBox.Show("Chức năng được chọn không có trong phân quyền!", "Thông báo");
            }
            else
            {
                MessageBox.Show(bllCTPQ.Delete(new PermissionGranting(selectedPermission, Convert.ToInt32(cbxMaChucNang.SelectedItem))), "Thông báo");
                isDeleting = false;

                btnThemCT.Enabled = true;
                btnXoaCT.Enabled = true;
                btnXacNhanCT.Enabled = false;
                btnHuyCT.Enabled = false;
                LoadDataGridCTPQ(selectedPermission);
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenTaiKhoan.Text = dgvPhanQuyen.SelectedRows[0].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvPhanQuyen.SelectedRows[0].Cells[1].Value.ToString();
            txtMaNhanVien.Text = dgvPhanQuyen.SelectedRows[0].Cells[2].Value.ToString();
            cbxPhanQuyen.SelectedItem= dgvPhanQuyen.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTenTaiKhoan.Text) || String.IsNullOrWhiteSpace(txtMatKhau.Text) || String.IsNullOrWhiteSpace(txtMaNhanVien.Text) || String.IsNullOrWhiteSpace(cbxPhanQuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!", "Thông báo");
            }
            else if (bllTK.TrungTenTK(txtTenTaiKhoan.Text))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!", "Thông báo");
            }
            else
            {
                Account tk = new Account(txtTenTaiKhoan.Text, txtMatKhau.Text, Convert.ToInt32(txtMaNhanVien.Text), Convert.ToInt32(cbxPhanQuyen.SelectedItem));
                MessageBox.Show(bllTK.Insert(tk), "Thông báo");
                LoadDataGridTK();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            isDeleting = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;

            btnXacNhan.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            isUpdating = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;

            btnXacNhan.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isDeleting)
            {
                isDeleting = false;
                
            }
            else if (isUpdating)
            {
                isUpdating = false;
            }
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;

            btnXacNhan.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (isUpdating)
            {
                if (String.IsNullOrWhiteSpace(txtTenTaiKhoan.Text) || String.IsNullOrWhiteSpace(txtMatKhau.Text) || String.IsNullOrWhiteSpace(txtMaNhanVien.Text) || String.IsNullOrWhiteSpace(cbxPhanQuyen.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!", "Thông báo");
                }
                else if (!bllTK.TrungTenTK(txtTenTaiKhoan.Text))
                {
                    MessageBox.Show("Tên tài khoản cần cập nhật không tồn tại!", "Thông báo");
                }
                else
                {
                    Account tk = new Account(txtTenTaiKhoan.Text, txtMatKhau.Text, Convert.ToInt32(txtMaNhanVien.Text), Convert.ToInt32(cbxPhanQuyen.SelectedItem));
                    MessageBox.Show(bllTK.Update(tk), "Thông báo");
                    LoadDataGridTK();
                    isUpdating = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnCapNhat.Enabled = true;

                    btnXacNhan.Enabled = false;
                    btnHuy.Enabled = false;
                }
            }
            else if (isDeleting)
            {
                if (String.IsNullOrWhiteSpace(txtTenTaiKhoan.Text))
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo");
                }
                else if (!bllTK.TrungTenTK(txtTenTaiKhoan.Text))
                {
                    MessageBox.Show("Tên tài khoản cần xóa không tồn tại!", "Thông báo");
                }
                else
                {
                    MessageBox.Show(bllTK.Delete(txtTenTaiKhoan.Text), "Thông báo");
                    LoadDataGridTK();
                    isDeleting = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnCapNhat.Enabled = true;

                    btnXacNhan.Enabled = false;
                    btnHuy.Enabled = false;
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNhanVien.Text = dgvPhanQuyen.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnThemPQ_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTenPhanQuyen.Text))
            {
                MessageBox.Show("Không được để trống Mã phân quyền!", "Thông báo");
            }
            else
            {
                Permission phanQuyen = new Permission(bllPQ.NextID(), txtTenPhanQuyen.Text);
                MessageBox.Show(bllPQ.Insert(phanQuyen), "Thông báo");
                LoadDataGridPQ();
            }
        }
    }
}
