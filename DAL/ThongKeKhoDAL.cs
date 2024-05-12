using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DAL
{
	public class ThongKeKhoDAL
	{
		DatabaseConnection databaseConnection = new DatabaseConnection();
		DataTable dataTable;

		public ThongKeKhoDAL()
		{
		}

		public List<ThongKeKho> ThongKe(DateTime ngaybd, DateTime ngaykt)
		{
			List<ThongKeKho> list = new List<ThongKeKho>();
			string sql = $"SELECT * FROM  Product p and ProductVariety pv and ImportDetails ipd and ImportBill ip where p.IsDeleted != 1 and p.ProductID = pv.ProductID and pv.VarietyID = ipd.VarietyID and ipd.ImportBillID = ip.ImportBillID and Date <= '{ngaybd}' and Date <= '{ngaykt}'";
			if (!databaseConnection.OpenDB()) return null;
			dataTable = databaseConnection.RunQuery(sql);
			ThongKeKho tkk;

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				tkk = new ThongKeKho();
				tkk.VarietyID = (int)dataTable.Rows[i]["VarietyID"];
				tkk.ProductID = (int)dataTable.Rows[i]["ProductID"];
				tkk.ProductName = dataTable.Rows[i]["ProductName"].ToString();
				tkk.ProductVolume = (int)dataTable.Rows[i]["Volume"];
				tkk.Date = (DateTime)dataTable.Rows[i]["Date"];
				tkk.Price = (int)dataTable.Rows[i]["ipd.Price"];
				tkk.Quantity = (int)dataTable.Rows[i]["ipd.Quantity"];
				tkk.ProviderID = (int)dataTable.Rows[i]["ProviderID"];
			}
			return list;
		}
	}

}
