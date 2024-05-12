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
    public partial class QuanLyNhanSu : UserControl
    {
        StaffBLL staffBLL = new StaffBLL();
        List<Staff> staffList = new List<Staff>();
        List<Staff> listTK = new List<Staff>();
        PositionBLL posBLL = new PositionBLL();
        List<Position> posList = new List<Position>();
        LeaveRequestBLL requestBLL = new LeaveRequestBLL();
        List<LeaveRequest> requestList = new List<LeaveRequest>();
        private const string placeholderText = "Nhận tên nhân viên cần tìm...";
        public QuanLyNhanSu()
        {
            InitializeComponent();
            StaffLoad();
            PositionLoad();
            RequestLoad();
            LoadTTCN();
            LoadThongKe();
        }
        //============= THÔNG TIN NHÂN SỰ ============= //
        public void LoadPlaceholderText()
        {
            txtTimKiem.Text = placeholderText;
            txtTimKiem.ForeColor = SystemColors.GrayText;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //TextBox textBox = (TextBox)sender;
            //if (string.IsNullOrEmpty(textBox.Text))
            //{
            //    textBox.ForeColor = Color.Gray;
            //    textBox.Text = "Nhập tên nhân viên cần tìm..."; // Restore placeholder text
            //}
            //else
            //{
            //    textBox.ForeColor = SystemColors.WindowText;
            //}
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            StaffLoad();
            txtTimKiem.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == placeholderText)
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = SystemColors.WindowText;
            }

        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = placeholderText;
                txtTimKiem.ForeColor = SystemColors.GrayText;
            }
        }

        private void focusButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(146, 146, 214);
            btn.ForeColor = Color.White;
        }
        private void resetButtonColor(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.FromArgb(146, 146, 214);
        }
        //disable 2 button truyền vào, các button còn lại enable
        public void DisableButtonsInGroupBox(GroupBox groupBox, Button btn1, Button btn2)
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            foreach (Control control in groupBox.Controls)
            {
                if (control is Button && (control != btn1 && control != btn2))
                {
                    Button btn = (Button)control;
                    btn.Enabled = true;
                }
            }
        }

        //enable 2 button truyền vào, disable các button còn lại
        public void EnableButtonsInGroupBox(GroupBox groupBox, Button btn1, Button btn2)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            foreach (Control control in groupBox.Controls)
            {
                if (control is Button && (control != btn1 && control != btn2))
                {
                    Button btn = (Button)control;
                    btn.Enabled = false;
                }
            }
        }
        public void EnableAllInputInGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.Enabled = true;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker date = (DateTimePicker)control;
                    date.Enabled = true;
                }
            }
        }
        public void DisableAllInputBoxInGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.Enabled = false;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker date = (DateTimePicker)control;
                    date.Enabled = false;
                }
                else if (control is ComboBox)
                {
                    ComboBox cbb = (ComboBox)control;
                    cbb.Enabled = false;
                }
            }
        }
        public void ResetAllInputInGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.Text = "";
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker date = (DateTimePicker)control;
                    date.Value = DateTime.Today;
                }
                else if (control is ComboBox)
                {
                    ComboBox cbb = (ComboBox)control;
                    cbb.SelectedIndex = 0;
                }
            }
        }


        static bool click_Them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            click_Them = true;
            click_Xoa = false;
            click_Sua = false;
            ResetAllInputInGroupBox(gbTTNV_TTNS);
            int id = staffBLL.AutoID();
            txtStaffID.Text = id.ToString();
            txtFullName.Enabled = true;
            dateDoB.Enabled = true;
            txtAddress.Enabled = true;
            focusButton(btnThem);
            EnableButtonsInGroupBox(gbTTNV_TTNS, btnXacNhan, btnHuy);
        }

        static bool click_Sua = false;
        private void btnSua_Click(object sender, EventArgs e)
        {
            click_Sua = true;
            click_Them = false;
            click_Xoa = false;
            focusButton(btnSua);
            EnableButtonsInGroupBox(gbTTNV_TTNS, btnXacNhan, btnHuy);
            EnableAllInputInGroupBox(gbTTNV_TTNS);
        }

        static bool click_Xoa = false;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            click_Xoa = true;
            click_Them = false;
            click_Sua = false;
            focusButton(btnXoa);
            EnableButtonsInGroupBox(gbTTNV_TTNS, btnHuy, btnXacNhan);
            txtStaffID.Enabled = true;
            txtFullName.Enabled = false;
            dateDoB.Enabled = false;
            txtAddress.Enabled = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvTTNS.CurrentCell = null;
            StaffLoad();
            DisableButtonsInGroupBox(gbTTNV_TTNS, btnXacNhan, btnHuy);
            resetButtonColor(btnThem);
            resetButtonColor(btnSua);
            resetButtonColor(btnXoa);

            txtStaffID.Enabled = false;
            ResetAllInputInGroupBox(gbTTNV_TTNS);
        }
        public bool isValidDoB(DateTime date)
        {
            if (date > DateTime.Today)
                return false;
            return true;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (click_Them)
            {
                if (string.IsNullOrEmpty(txtFullName.Text))
                {
                    MessageBox.Show("Không được để tróng tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Không được để trống địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!isValidDoB(dateDoB.Value))
                {
                    MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Staff staff = new Staff(Convert.ToInt32(txtStaffID.Text), txtFullName.Text.ToString(), dateDoB.Value, txtAddress.Text.ToString(), false);
                    if (staffBLL.InsertStaff(staff))
                    {
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetButtonColor(btnThem);
                        StaffLoad();
                    }
                }
            }
            else if (click_Xoa)
            {

                if (!staffBLL.CheckStaffIDExist(Convert.ToInt32(txtStaffID.Text)))
                {
                    MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Staff staff = new Staff(Convert.ToInt32(txtStaffID.Text), txtFullName.Text.ToString(), dateDoB.Value, txtAddress.Text.ToString(), true);
                if (staffBLL.UpdateStaff(staff))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetButtonColor(btnXoa);
                    StaffLoad();
                }

            }
            else if (click_Sua)
            {
                if (string.IsNullOrEmpty(txtFullName.Text))
                {
                    MessageBox.Show("Không được để tróng tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Không được để tróng tên địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!isValidDoB(dateDoB.Value))
                {
                    MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Staff staff = new Staff(Convert.ToInt32(txtStaffID.Text), txtFullName.Text.ToString(), dateDoB.Value, txtAddress.Text.ToString(), false);
                    if (staffBLL.UpdateStaff(staff))
                    {
                        MessageBox.Show("Chỉnh sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetButtonColor(btnSua);
                        StaffLoad();
                    }

                }
            }
        }

        public void StaffLoad()
        {
            LoadPlaceholderText();
            cbbTimKiem.SelectedIndex = 0;
            txtStaffID.Enabled = false;
            DisableButtonsInGroupBox(gbTTNV_TTNS, btnXacNhan, btnHuy);
            ResetAllInputInGroupBox(gbTTNV_TTNS);
            dgvTTNS.Rows.Clear();
            click_Xoa = false;
            click_Them = false;
            click_Sua = false;
            staffList = staffBLL.GetAllStaff();
            for (int i = 0; i < staffList.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvTTNS);
                newRow.Cells[0].Value = staffList[i].StaffID;
                newRow.Cells[1].Value = staffList[i].FullName;
                newRow.Cells[2].Value = staffList[i].DOB.ToShortDateString();
                newRow.Cells[3].Value = staffList[i].Address;
                dgvTTNS.Rows.Add(newRow);
            }
        }

        private void dgvTTNS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a valid row is clicked
            {
                //Get the DataGridViewRow corresponding to the clicked row
                DataGridViewRow row = dgvTTNS.Rows[e.RowIndex];
                txtStaffID.Text = row.Cells["StaffID"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                dateDoB.Value = Convert.ToDateTime(row.Cells["DoB"].Value);
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.Trim(new char[] { ' ' });
            if(string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Thanh tìm kiếm trống vui lòng nhập thông tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(cbbTimKiem.SelectedIndex == 0 && !int.TryParse(key, out int kq))
            {
                MessageBox.Show("Thông tin nhập sai dữ liệu (không hợp lệ) !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvTTNS.Rows.Clear();
                //maNV {0}
                if (cbbTimKiem.SelectedIndex == 0)
                {
                    //timkiemnv(key,filter)
                    listTK = staffBLL.SearchStaff(key, 0);

                    if (listTK.Count < 1)
                    {
                        MessageBox.Show("Không tìm thấy kết quả tìm kiếm hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        for (int i = 0; i < listTK.Count; i++)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dgvTTNS);
                            newRow.Cells[0].Value = staffList[i].StaffID;
                            newRow.Cells[1].Value = staffList[i].FullName;
                            newRow.Cells[2].Value = staffList[i].DOB.ToShortDateString();
                            newRow.Cells[3].Value = staffList[i].Address;
                            dgvTTNS.Rows.Add(newRow);
                        }
                    }
                }

                //hotenNV {1}
                else if (cbbTimKiem.SelectedIndex == 1)
                {
                    listTK = staffBLL.SearchStaff(key, 1);

                    if (listTK.Count < 1)
                    {
                        MessageBox.Show("Không tìm thấy kết quả tìm kiếm hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        for (int i = 0; i < listTK.Count; i++)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dgvTTNS);
                            newRow.Cells[0].Value = staffList[i].StaffID;
                            newRow.Cells[1].Value = staffList[i].FullName;
                            newRow.Cells[2].Value = staffList[i].DOB.ToShortDateString();
                            newRow.Cells[3].Value = staffList[i].Address;
                            dgvTTNS.Rows.Add(newRow);
                        }
                    }
                }
            }
        }


        //============= CHỨC VỤ ============= //
        public void PositionLoad()
        {
            txtPosID.Enabled = false;
            click_Xoa_CV = false;
            click_Them_CV = false;
            click_Sua_CV = false;
            ResetAllInputInGroupBox(gbTTCV);
            DisableButtonsInGroupBox(gbTTCV, btn_CV_Huy, btn_CV_XacNhan);
            dgvPosition.Rows.Clear();
            posList = posBLL.GetAllPosition();
            for (int i = 0; i < posList.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dgvPosition);
                newRow.Cells[0].Value = posList[i].PositionID;
                newRow.Cells[1].Value = posList[i].PositionName;
                newRow.Cells[2].Value = posList[i].Salary;
                dgvPosition.Rows.Add(newRow);
            }

        }
        private void dgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a valid row is clicked
            {
                //Get the DataGridViewRow corresponding to the clicked row
                DataGridViewRow row = dgvPosition.Rows[e.RowIndex];
                txtPosID.Text = row.Cells["PositionID"].Value.ToString();
                txtPosName.Text = row.Cells["PositionName"].Value.ToString();
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
            }
        }
        static bool click_Them_CV = false;
        private void btn_CV_Them_Click(object sender, EventArgs e)
        {
            click_Them_CV = true;
            click_Sua_CV = false;
            click_Xoa_CV = false;
            ResetAllInputInGroupBox(gbTTCV);
            int id = posBLL.AutoID();
            txtPosID.Text = id.ToString();
            focusButton(btn_CV_Them);
            EnableButtonsInGroupBox(gbTTCV, btn_CV_XacNhan, btn_CV_Huy);
            txtPosName.Enabled = true;
            txtSalary.Enabled = true;
        }

        static bool click_Sua_CV = false;
        private void btn_CV_Sua_Click(object sender, EventArgs e)
        {
            click_Them_CV = false;
            click_Sua_CV = true;
            click_Xoa_CV = false;
            focusButton(btn_CV_Sua);
            EnableButtonsInGroupBox(gbTTCV, btn_CV_XacNhan, btn_CV_Huy);
            txtPosID.Enabled = true;
            txtPosName.Enabled = true;
            txtSalary.Enabled = true;
        }
        static bool click_Xoa_CV = false;
        private void btn_CV_Xoa_Click(object sender, EventArgs e)
        {
            click_Them_CV = false;
            click_Sua_CV = false;
            click_Xoa_CV = true;
            focusButton(btn_CV_Xoa);
            EnableButtonsInGroupBox(gbTTCV, btn_CV_XacNhan, btn_CV_Huy);
            txtPosID.Enabled = true;
            txtPosName.Enabled = false;
            txtSalary.Enabled = false;
        }

        private void btn_CV_Huy_Click(object sender, EventArgs e)
        {
            dgvPosition.CurrentCell = null;
            PositionLoad();
            DisableButtonsInGroupBox(gbTTCV, btn_CV_Huy, btn_CV_XacNhan);
            resetButtonColor(btn_CV_Them);
            resetButtonColor(btn_CV_Xoa);
            resetButtonColor(btn_CV_Sua);
            ResetAllInputInGroupBox(gbTTCV);
            txtPosID.Enabled = false;
        }

        private void btn_CV_XacNhan_Click(object sender, EventArgs e)
        {
            if (click_Them_CV)
            {
                if (string.IsNullOrEmpty(txtPosName.Text))
                {
                    MessageBox.Show("Không được để tróng tên chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtSalary.Text))
                {
                    MessageBox.Show("Không được để tróng lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Position pos = new Position(Convert.ToInt32(txtPosID.Text), txtPosName.Text.ToString(), Convert.ToInt32(txtSalary.Text), 0);
                    if (posBLL.InsertPosition(pos))
                    {
                        MessageBox.Show("Thêm chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PositionLoad();
                        resetButtonColor(btn_CV_Them);
                    }
                }
            }
            else if (click_Xoa_CV)
            {
                if (!posBLL.CheckPositionIDExist(Convert.ToInt32(txtPosID.Text)))
                {
                    MessageBox.Show("Mã chức vụ không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Position pos = new Position(Convert.ToInt32(txtPosID.Text), txtPosName.Text.ToString(), Convert.ToInt32(txtSalary.Text), 1);
                    if (posBLL.UpdatePosition(pos))
                    {
                        MessageBox.Show("Xóa chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PositionLoad();
                        resetButtonColor(btn_CV_Xoa);
                    }
                }

            }
            else if (click_Sua_CV)
            {
                if (string.IsNullOrEmpty(txtPosName.Text))
                {
                    MessageBox.Show("Không được để tróng tên chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtSalary.Text))
                {
                    MessageBox.Show("Không được để tróng lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Position pos = new Position(Convert.ToInt32(txtPosID.Text), txtPosName.Text.ToString(), Convert.ToInt32(txtSalary.Text), 0);
                    if (posBLL.UpdatePosition(pos))
                    {
                        MessageBox.Show("Chỉnh sửa chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PositionLoad();
                        resetButtonColor(btn_CV_Sua);
                    }
                }
            }
        }

        

        //============= NGHỈ PHÉP ============= //
        public void RequestLoad()
        {
            DisableAllInputBoxInGroupBox(gbTTNP);
            DisableButtonsInGroupBox(gbTTNP, btn_XacNhan_NP, btn_Huy_NP);
            ResetAllInputInGroupBox(gbTTNP);
            dgvLeaveRequest.Rows.Clear();
            click_Duyet = false;
            click_TuChoi = false;
            requestList = requestBLL.GetAllLeaveRequests();
            for (int i = 0; i < requestList.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvLeaveRequest);
                newRow.Cells[0].Value = requestList[i].RequestID;
                newRow.Cells[1].Value = requestList[i].StaffID;
                newRow.Cells[2].Value = requestList[i].LeavingDate.ToShortDateString();
                newRow.Cells[3].Value = requestList[i].LeavingDays;
                newRow.Cells[4].Value = requestList[i].LeavingType;
                newRow.Cells[5].Value = requestList[i].RequestContent;
                newRow.Cells[6].Value = requestList[i].AppproveStatus;
                dgvLeaveRequest.Rows.Add(newRow);
            }
        }

        private void dgvLeaveRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a valid row is clicked
            {
                //Get the DataGridViewRow corresponding to the clicked row
                DataGridViewRow row = dgvLeaveRequest.Rows[e.RowIndex];
                txtRequestID.Text = row.Cells["RequestID"].Value.ToString();
                txtLeavingContent.Text = row.Cells["RequestContent"].Value.ToString();
                txtLeavingType.Text = row.Cells["LeavingType"].Value.ToString();
                
                //txtLeavingStatus.Text = row.Cells["ApproveStatus"].Value.ToString();
                if(Convert.ToInt32(row.Cells["ApproveStatus"].Value.ToString()) == 0)
                {
                    txtLeavingStatus.Text = "Chưa duyệt";
                }
                else if(Convert.ToInt32(row.Cells["ApproveStatus"].Value.ToString()) == 1)
                {
                    txtLeavingStatus.Text = "Đã duyệt";
                }
                else txtLeavingStatus.Text = "Từ chối";
            }
        }
        static bool click_Duyet = false;
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            click_Duyet = true;
            focusButton(btnDuyet);
            EnableButtonsInGroupBox(gbTTNP, btn_XacNhan_NP, btn_Huy_NP);
            txtRequestID.Enabled = true;
        }
        static bool click_TuChoi;
        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            click_TuChoi = true;
            focusButton(btnTuChoi);
            EnableButtonsInGroupBox(gbTTNP, btn_XacNhan_NP, btn_Huy_NP);
            txtRequestID.Enabled = true;
        }

        private void btn_Huy_NP_Click(object sender, EventArgs e)
        {
            DisableButtonsInGroupBox(gbTTNP, btn_XacNhan_NP, btn_Huy_NP);
            ResetAllInputInGroupBox(gbTTNP);
            dgvLeaveRequest.CurrentCell = null;
        }

        private void btn_XacNhan_NP_Click(object sender, EventArgs e)
        {
            if (click_Duyet)
            {
                if (string.IsNullOrEmpty(txtRequestID.Text.ToString()))
                {
                    MessageBox.Show("Không được để trống mã đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!requestBLL.CheckRequestIDExist(Convert.ToInt32(txtRequestID.Text.ToString())))
                {
                    MessageBox.Show("Mã đơn không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (requestBLL.UpdateLeaveRequest(Convert.ToInt32(txtRequestID.Text.ToString()), 1))
                {
                    MessageBox.Show("Đơn đã được duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RequestLoad();
                    resetButtonColor(btnDuyet);
                }
            }
            if (click_TuChoi)
            {
                if (string.IsNullOrEmpty(txtRequestID.Text.ToString()))
                {
                    MessageBox.Show("Không được để trống mã đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!requestBLL.CheckRequestIDExist(Convert.ToInt32(txtRequestID.Text.ToString())))
                {
                    MessageBox.Show("Mã đơn không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (requestBLL.UpdateLeaveRequest(Convert.ToInt32(txtRequestID.Text.ToString()), 2))
                {
                    MessageBox.Show("Đã từ chối đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RequestLoad();
                    resetButtonColor(btnTuChoi);
                }
            }
        }


        //============= THÔNG TIN CÁ NHÂN ============= //
        public void LoadTTCN()
        {
            click_GuiDon = false;
            click_Sua_TTNV = false;
            txtStaffID_Form.Enabled = false;
            txtSTaffID_TTNV.Enabled = false;
            DisableButtonsInGroupBox(gbXinNP, btn_XacNhan_Form, btn_Huy_Form);
            DisableButtonsInGroupBox(gbThongTinNhanVien, btn_XacNhan_TTCN, btn_Huy_TTCN);
            //Thêm phần load ra thông tin nhân viên hiện tại
        }

        static bool click_GuiDon = false;
        private void btnGuiDon_Click(object sender, EventArgs e)
        {
            click_GuiDon = true;
            focusButton(btnGuiDon);
            EnableButtonsInGroupBox(gbXinNP, btn_XacNhan_Form, btn_Huy_Form);
        }

        private void btn_Huy_Form_Click(object sender, EventArgs e)
        {
            click_GuiDon = false;
            cbbLeavingType_Form.SelectedIndex = 0;
            dateLeavingDate_Form.Value = DateTime.Today;
            txtleavingDays_Form.Text = "";
            txtContent_Form.Text = "";
            resetButtonColor(btnGuiDon);
        }

        private void btn_XacNhan_Form_Click(object sender, EventArgs e)
        {
            if(click_GuiDon)
            {
                if (string.IsNullOrEmpty(txtleavingDays_Form.Text.ToString()))
                {
                    MessageBox.Show("Không được để trống số ngày nghỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtContent_Form.Text.ToString()))
                {
                    MessageBox.Show("Không được để trống Nội dung đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {//Convert.ToInt32(txtPosID.Text), txtPosName.Text.ToString(), Convert.ToInt32(txtSalary.Text), 0
                    int requestID = requestBLL.AutoID();
                    LeaveRequest request = new LeaveRequest(requestID, 0, txtContent_Form.Text.ToString(), dateLeavingDate_Form.Value, Convert.ToInt32(txtContent_Form.Text.ToString()), cbbLeavingType_Form.SelectedIndex , Convert.ToInt32(txtStaffID_Form.Text.ToString()));
                    if (requestBLL.InsertLeaveRequest(request))
                    {
                        MessageBox.Show("Gửi đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTTCN();
                        resetButtonColor(btnGuiDon);
                    }
                }
            }
        }
        static bool click_Sua_TTNV = false;
        private void btn_Sua_TTCN_Click(object sender, EventArgs e)
        {
            click_Sua_TTNV = true;
            focusButton(btn_Sua_TTCN);
            EnableButtonsInGroupBox(gbThongTinNhanVien, btn_XacNhan_TTCN, btn_Huy_TTCN);
        }

        private void btn_XacNhan_TTCN_Click(object sender, EventArgs e)
        {
            if(click_Sua_TTNV)
            {
                if (string.IsNullOrEmpty(txtFullName_TTNV.Text.ToString()))
                {
                    MessageBox.Show("Không được để trống họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtAdress_TTNV.Text.ToString()))
                {
                    MessageBox.Show("Không được để trống địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!isValidDoB(dateDOB_TTNV.Value))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Staff staff = new Staff(Convert.ToInt32(txtSTaffID_TTNV.Text), txtFullName_TTNV.Text.ToString(), dateDOB_TTNV.Value, txtAdress_TTNV.Text.ToString(), false);
                    if (staffBLL.UpdateStaff(staff))
                    {
                        MessageBox.Show("Chỉnh sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetButtonColor(btn_Sua_TTCN);
                        LoadTTCN();
                    }
                }
            }
        }

        private void btn_Huy_TTCN_Click(object sender, EventArgs e)
        {
            LoadTTCN();
            resetButtonColor(btn_Sua_TTCN);
        }

        //============= THỐNG KÊ LƯƠNG THEO CHỨC VỤ============= //
       public void LoadThongKe()
        {
            dgvThongKeNV_CV.Rows.Clear();
            DataTable dt = staffBLL.ThongKeNhanVienTheoCV();
            foreach (DataRow row in dt.Rows)
            {
                // Lấy dữ liệu từ các cột trong DataTable
                string positionName = row.Field<string>(0);
                int numberOfEmployees = row.Field<int>(1);
                int totalSalary = row.Field<int>(2);

                // Thêm dữ liệu vào DataGridView
                dgvThongKeNV_CV.Rows.Add(positionName, numberOfEmployees, totalSalary);
            }
        }

        
    }
}
