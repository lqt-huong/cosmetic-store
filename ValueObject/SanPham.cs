using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
	public class SanPham
	{
		int productID;
		string productName;
		int providerID;
		int categoryID;

		public SanPham()
		{
		}

		public SanPham(int productID, string productName, int providerID, int categoryID)
		{
			this.productID = productID;
			this.productName = productName;
			this.providerID = providerID;
			this.categoryID = categoryID;
		}

		public int ProductID { get { return productID; } set { productID = value; } }
		public string ProductName { get { return productName; } set {productName = value; } }
		public int ProviderID { get {return providerID; } set {providerID = value; } }
		public int CategoryID { get {return categoryID; } set {categoryID = value; } }

	}
}
