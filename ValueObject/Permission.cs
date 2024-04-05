using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Permission
    {
        int permissionID;
        string permissionName;

        public Permission(int permissionID, string permissionName)
        {
            this.permissionID = permissionID;
            this.permissionName = permissionName;
        }

        public Permission()
        {

        }

        public int PermissionID { get { return this.permissionID; } set { this.permissionID = value; } }
        public string PermissionName { get { return this.permissionName; } set { this.permissionName = value; } }
    }
}
