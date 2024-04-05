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

        public Account(string username, string password, int staffID, int permisisonID)
        {
            this.username = username;
            this.password = password;
            this.staffID = staffID;
            this.permisisonID = permisisonID;
        }

        public Account()
        {

        }

        public string Username { get { return this.username; } set { this.username = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }
        public int StaffID { get { return this.staffID; } set { this.staffID = value; } }
        public int PermissionID { get { return this.permisisonID; } set { this.permisisonID = value; } }
    }
}
