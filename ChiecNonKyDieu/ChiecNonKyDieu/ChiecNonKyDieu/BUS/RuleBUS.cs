using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiecNonKyDieu.DAO;
using ChiecNonKyDieu.DTO;

namespace ChiecNonKyDieu.BUS
{
    class RuleBUS
    {
        DataRule data = new DataRule();
        public QuyDinhTroChoi GetGuideLine()
        {
            return data.GetGuideLine();
        }

        public void SetThongSo(QuyDinhTroChoi qd)
        {
            data.SetThongSo(qd);
        }
    }
}
