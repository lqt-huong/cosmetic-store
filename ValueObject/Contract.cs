using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Contract
    {
        private int contractNo;
        private DateTime startingDate;
        private DateTime endingDate;
        private int staffID;
        private int positionID;
        private byte isDeleted;
        public Contract()
        {

        }
        public Contract(int id, DateTime start, DateTime end, int staffid, int posID, byte isDel)
        {
            contractNo = id;
            startingDate = start;
            endingDate = end;
            staffID = staffid;
            positionID = posID;
            isDeleted = isDel;
        }
        public int ContractNo { get { return this.contractNo; } set { this.contractNo = value; } }
        public DateTime StartingDate { get { return this.startingDate; } set { this.startingDate = value; } }
        public DateTime EndingDate { get { return this.endingDate; } set { this.endingDate = value; } }
        public int StaffID { get { return this.staffID; } set { this.staffID = value; } }
        public int PositionID { get { return this.positionID; } set { this.positionID = value; } }
        public byte IsDeleted { get { return this.isDeleted; } set { this.isDeleted = value; } }
    }
}
