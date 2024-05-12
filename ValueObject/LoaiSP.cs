using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
	public class LoaiSP
	{
		int categoryID;
		string categoryName;
		int numberOfItems;
		int isDeleted;

		public LoaiSP() 
		{
		}

		public LoaiSP(int categoryID, string categoryName, int numberOfItems, int isDeleted)
		{
			this.categoryID = categoryID;
			this.categoryName = categoryName;
			this.numberOfItems = numberOfItems;
			this.isDeleted = isDeleted;
		}

		public int CategoryID { get { return categoryID; } set { categoryID = value; } }
		public string CategoryName { get { return categoryName; } set { categoryName = value; } }
		public int NumberOfItems { get {return numberOfItems;} set { numberOfItems = value; } }
		public int IsDeleted { get { return isDeleted;} set { isDeleted = value; } }


	}
}
