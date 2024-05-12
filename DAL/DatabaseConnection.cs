using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseConnection
    {
        //const string CONNECTION_STRING = @"Data Source=DESKTOP-1E6RROK\SQLEXPRESS;Initial Catalog=27032024_CosmeticStore;Integrated Security=True";
        //const string CONNECTION_STRING = @"Data Source=josie\sqlexpress;Initial Catalog=cosmetic-store;Integrated Security=True"; //connection string của TH
        const string CONNECTION_STRING = @"Data Source=DESKTOP-PT451IS\MSSQLSERVER01;Initial Catalog=27032024_CosmeticStore;Integrated Security=True;Trust Server Certificate=True"; //connection string của Nhi
        SqlConnection conn;
        SqlDataAdapter adapter;

        public DatabaseConnection()
        {
        }

        //Hàm kết nối đến database, nếu thành công sẽ trả về true, nếu thất bại sẽ trả về false
        public bool OpenDB()
        {
            try
            {
                conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
            }
            catch (SqlException ex)
            {
                conn = null;
                Console.WriteLine($"Error: {ex.Number}");
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            return true;
        }

        //Hàm thực thi câu lệnh sql truyền vào, kết quả trả về nếu thành công là một DataTable, nếu thất bại thì trả về null
        public DataTable RunQuery(string sql)
        {
            DataTable returnedDataTable = new DataTable();

            try
            {
                adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(returnedDataTable);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Number}");
                return null;
            }

            return returnedDataTable;
        }

        //Hàm cập nhật lại dữ liệu từ datatable lên database
        public void Update(DataTable dataTable)
        {
            try
            {
                adapter.Update(dataTable);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Number}");
            }
        }

        public void ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Number}");
            }
        }
    }
}
