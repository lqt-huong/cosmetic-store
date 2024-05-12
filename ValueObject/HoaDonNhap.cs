using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
	public class HoaDonNhap
	{
		int importBillID;
		DateTime date;
		int totalValue;
		int providerID;
		int satffID;
		int isDeleted;

		public HoaDonNhap() 
		{ 
		}

		public HoaDonNhap(int importBillID, DateTime date, int totalValue, int providerID, int satffID, int isDeleted)
		{
			this.importBillID = importBillID;
			this.date = date;
			this.totalValue = totalValue;
			this.providerID = providerID;
			this.satffID = satffID;
			this.isDeleted = isDeleted;
		}

		public int ImportBillID { get { return importBillID; } set { importBillID = value;  } }
		public DateTime Date { get { return date; } set { date = value; } }
		public int TotalValue { get { return totalValue; } set { totalValue = value; } }
		public int ProviderID { get {return providerID; } set { providerID = value; } }
		public int SatffID { get {return satffID; } set { satffID = value; } }
		public int IsDeleted { get { return isDeleted; } set { isDeleted = value; } }
	}
}
