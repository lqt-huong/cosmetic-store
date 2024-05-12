using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
	public class HoaDonNhapDAL
	{
		DatabaseConnection databaseConnection = new DatabaseConnection();
		DataTable dataTable;

		public HoaDonNhapDAL()
		{
		}

		public List<HoaDonNhap> getAllImportBill()
		{
			List<HoaDonNhap> listHD = new List<HoaDonNhap>();
			string query = "select * from ImprortBill where IsDeleted != 1";
			if (!databaseConnection.OpenDB()) return null;
			dataTable = databaseConnection.RunQuery(query);
			HoaDonNhap hd;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				hd = new HoaDonNhap();
				hd.ImportBillID = (int)dataTable.Rows[i]["ImportBillID"];
				hd.Date = (DateTime)dataTable.Rows[i]["Date"];
				hd.TotalValue = (int)dataTable.Rows[i]["TotalValue"];
				hd.ProviderID = (int)dataTable.Rows[i]["ProviderID"];
				hd.SatffID = (int)dataTable.Rows[i]["StaffID"];
				listHD.Add(hd);
			}
			return listHD;
		}

		public bool ThemHDNhap(HoaDonNhap hoaDonNhap)
		{
			string query = "select * from ImportBill";
			dataTable = databaseConnection.RunQuery(query);
			DataRow row = dataTable.NewRow();
			row["ImportBillID"] = hoaDonNhap.ImportBillID;
			row["Date"] = hoaDonNhap.Date;
			row["TotalValue"] = hoaDonNhap.TotalValue;
			row["Provider"] = hoaDonNhap.ProviderID;
			row["StaffID"] = hoaDonNhap.SatffID;

			dataTable.Rows.Add(row);
			databaseConnection.Update(dataTable);
			return true;
		}

		public bool XoaHDN(int maHDN)
		{
			try
			{
				string query = $"delete from ImportDetails where ImportBillID = '{maHDN}'";
				databaseConnection.ExecuteNonQuery(query);
				string queryPr = $"delete from ImportBill where ImportBillID = '{maHDN}'";
				databaseConnection.ExecuteNonQuery(queryPr);
			}
			catch (Exception ex)
			{
				return false;
			}
			return true;
		}

		public string getProviderName(int providerID)
		{
			string query = $"select ProviderName from Provider where ProviderID = {providerID}";
			dataTable = databaseConnection.RunQuery(query);
			return dataTable.Rows[0]["ProviderName"].ToString();
		}

		public string getStaffName(int staffID)
		{
			string query = $"select StaffName from Staff where StaffID = {staffID}";
			dataTable = databaseConnection.RunQuery(query);
			return dataTable.Rows[0]["StaffName"].ToString();
		}


		public int AutoID()
		{
			int id;
			string query = "select max(ImportBillID) as max_ID from ImportBill";
			dataTable = databaseConnection.RunQuery(query);
			int num = -1;
			if (!int.TryParse(dataTable.Rows[0]["max_ID"].ToString(), out num)) return 1;
			id = (int)dataTable.Rows[0]["max_ID"];
			return id + 1;
		}

	}
}
