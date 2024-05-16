using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Staff
    {
        private int staffID;
        private string fullName;
        private DateTime dOB;
        private string address;
        private bool isDeleted;
        public Staff()
        {

        }

        public Staff(int id, string name, DateTime date, string addr, bool isDel)
        {
            staffID = id;
            fullName = name;
            dOB = date;
            address = addr;
            isDeleted = isDel;
        }

        public int StaffID { get {return this.staffID; } set{this.staffID = value;} }
        public string FullName { get { return this.fullName; } set { this.fullName = value; } }
        public DateTime DOB{ get { return this.dOB; } set { this.dOB = value; } }
        public string Address{ get { return this.address; } set { this.address = value; } }
        public bool IsDeleted { get { return this.isDeleted; } set { this.isDeleted = value; } }

    }
}
