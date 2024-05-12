using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
	public class NhaCungCapDAL
	{
		DatabaseConnection databaseConnection = new DatabaseConnection();
		DataTable dataTable;
		public NhaCungCapDAL()
		{
		}

		public List<NhaCungCap> getAllNCC()
		{
			List<NhaCungCap> listNcc = new List<NhaCungCap>();
			string query = "select * from Provider where IsDeleted != 1";
			if (!databaseConnection.OpenDB()) return null;
			dataTable = databaseConnection.RunQuery(query);
			NhaCungCap ncc;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				ncc = new NhaCungCap();
				ncc.ProviderID = (int)dataTable.Rows[i]["ProviderID"];
				ncc.ProviderName = dataTable.Rows[i]["ProviderName"].ToString();
				ncc.IsDeleted = (int)dataTable.Rows[i]["ProviderID"];
				listNcc.Add(ncc);
			}
			return listNcc;
		}

		public bool Them(NhaCungCap ncc)
		{
			try
			{
				string query = $"insert into Provider(ProviderID, ProviderName, IsDeleted) values({ncc.ProviderID}, '{ncc.ProviderName}', '0')";
				databaseConnection.ExecuteNonQuery(query);
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		public bool Sua(NhaCungCap ncc)
		{
			try
			{
				string query = $"update Provider set ProviderName = {ncc.ProviderName} where ProviderID = {ncc.ProviderID}";
				databaseConnection.ExecuteNonQuery(query);
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		public bool Xoa(int providerID)
		{
			try
			{
				string query = $"update Provider set isDeleted = '1' where ProviderID = '{providerID}'";
				databaseConnection.ExecuteNonQuery(query);
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		public int AutoID()
		{
			int id;
			string query = "select max(ProviderID) as max_ID from Provider";
			dataTable = databaseConnection.RunQuery(query);
			int num = -1;
			if (!int.TryParse(dataTable.Rows[0]["max_ID"].ToString(), out num)) return 1;
			id = (int)dataTable.Rows[0]["max_ID"];
			return id + 1;
		}

		public bool KiemTraTrung(int providerID)
		{
			string queryPr = $"select * from Provider where ProviderID = '{providerID}'";
			dataTable = databaseConnection.RunQuery(queryPr);
			if (dataTable.Rows.Count > 0) return false;
			return true;
		}
	}
}
