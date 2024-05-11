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
        byte isDeleted;

        public Permission(int permissionID, string permissionName, byte isDeleted)
        {
            this.permissionID = permissionID;
            this.permissionName = permissionName;
            this.isDeleted = isDeleted;
        }

        public Permission()
        {

        }

        public int PermissionID { get { return this.permissionID; } set { this.permissionID = value; } }
        public string PermissionName { get { return this.permissionName; } set { this.permissionName = value; } }
        public byte IsDeleted { get { return this.isDeleted; } set { this.isDeleted = value; } }
    }
}
