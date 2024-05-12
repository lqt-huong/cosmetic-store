using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
	public class CTHoaDonNhap
	{
		int importBillID;
		int varietyID;
		int quantity;
		int importPrice;

		public CTHoaDonNhap()
		{
		}

		public CTHoaDonNhap(int importBillID, int varietyID, int quantity, int importPrice)
		{
			this.importBillID = importBillID;
			this.varietyID = varietyID;
			this.quantity = quantity;
			this.importPrice = importPrice;
		}

		public int ImportBillID { get { return importBillID; } set { importBillID = value; } }
		public int VarietyID { get {return varietyID; } set { varietyID = value; } }
		public int Quantity { get { return quantity; } set { quantity = value; } }
		public int ImportPrice { get { return importPrice; } set { importBillID = value; } }



	}
}
