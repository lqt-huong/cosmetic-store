using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
	public class NhaCungCap
	{
		int providerID;
		string providerName;
		int isDeleted;
		public NhaCungCap() 
		{ 
		}

		public NhaCungCap(int providerID, string providerName, int isDeleted)
		{
			this.providerID = providerID;
			this.providerName = providerName;
			this.isDeleted = isDeleted;
		}

		public int ProviderID { get { return providerID; }  set { providerID = value; } }
		public string ProviderName { get { return providerName; } set { providerName = value; } }
		public int IsDeleted { get { return isDeleted; } set { isDeleted = value; } }
	}
}
