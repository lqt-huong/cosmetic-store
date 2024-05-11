using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ValueObject;

namespace BLL
{
    public class PositionBLL
    {
        static PositionDAL posDAL;
        static List<Position> posList;
        public PositionBLL()
        {
            posDAL = new PositionDAL();
            posList = posDAL.GetAllPositions();
        }

        public List<Position> GetAllPosition()
        {
            return posDAL.GetAllPositions();
        }
        public bool InsertPosition(Position pos)
        {
            return posDAL.InsertPosition(pos);
        }
        public int AutoID()
        {
            return posDAL.AutoID();
        }
        public bool CheckPositionIDExist(int posID)
        {
            return posDAL.CheckPositionIDExist(posID);
        }

        public bool DeletePostion(int posID)
        {
            if (posDAL.DeletePostion(posID))
            {
                posList = posDAL.GetAllPositions();
                return true;
            }
            return false;
        }

        public bool UpdatePosition(Position pos)
        {
            return posDAL.UpdatePosition(pos);
        }
    }
}
