using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class PermissionGranting
    {
        int permissionID;
        int functionID;

        public PermissionGranting(int permissionID, int functionID)
        {
            this.permissionID = permissionID;
            this.functionID = functionID;
        }

        public PermissionGranting()
        {

        }

        public int PermissionID { get { return this.permissionID; } set { this.permissionID = value; } }
        public int FunctionID { get { return this.functionID; } set { this.functionID = value; } }
    }
}
