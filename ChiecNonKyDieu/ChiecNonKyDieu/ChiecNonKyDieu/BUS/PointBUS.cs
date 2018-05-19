using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiecNonKyDieu.DTO;
using ChiecNonKyDieu.DAO;

namespace ChiecNonKyDieu.BUS
{   
    class PointBUS
    {
        DataPoint data = new DataPoint();
        public List<PointAward> GetListPoint()
        {
            return data.GetListPoint();
        }
    }
}
