using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;


namespace Cosmetic_Store
{
    public partial class TestConnectionDB : Form
    {
        const string CONNECTION_STRING = @"Data Source=josie\sqlexpress;Initial Catalog=cosmetic-store;Integrated Security=True";
        SqlConnection conn;
        testBLL testConn = new testBLL();
        public TestConnectionDB()
        {
            InitializeComponent();
            OpenDB();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo kết nối mới
                using (conn = new SqlConnection(CONNECTION_STRING))
                {
                    // Mở kết nối
                    conn.Open();

                    // Kiểm tra kết nối thành công
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Kết nối thành công đến cơ sở dữ liệu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestConnectionDB_Load(object sender, EventArgs e)
        {

        }
        public void OpenDB()
        {
            if(!testConn.OpenDB())
                MessageBox.Show("Kết nối không thành công đến cơ sở dữ liệu!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Kết nối thành công đến cơ sở dữ liệu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    
}
