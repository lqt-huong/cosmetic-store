using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Position
    {
        private int positionID;
        private string positionName;
        private int salary;
        private byte isDeleted;

        public Position()
        {
                
        }
        public Position(int id, string name, int sal, byte isDel)
        {
            positionID = id;
            positionName = name;
            salary = sal;
            isDeleted = isDel;

        }
        public int PositionID { get { return this.positionID; } set { this.positionID = value; } }
        public string PositionName { get { return this.positionName; } set { this.positionName = value; } }
        public int Salary { get { return this.salary; } set { this.salary = value; } }
        public byte IsDeleted { get { return this.isDeleted; } set { this.isDeleted = value; } }

    }
}
