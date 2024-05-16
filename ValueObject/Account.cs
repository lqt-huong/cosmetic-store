using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Account
    { 
        string username;
        string password;
        int staffID;
        int permisisonID;
        byte isDeleted;

        public Account(string username, string password, int staffID, int permisisonID, byte isDeleted)
        {
            this.username = username;
            this.password = password;
            this.staffID = staffID;
            this.permisisonID = permisisonID;
            this.isDeleted = isDeleted;
        }

        public Account()
        {

        }

        public string Username { get { return this.username; } set { this.username = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }
        public int StaffID { get { return this.staffID; } set { this.staffID = value; } }
        public int PermissionID { get { return this.permisisonID; } set { this.permisisonID = value; } }
        public byte IsDeleted { get { return this.isDeleted; } set { this.isDeleted = value; } }
    }
}
