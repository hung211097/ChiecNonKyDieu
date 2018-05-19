using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiecNonKyDieu.DTO
{
    public class QuyDinhTroChoi
    {
        private int thoiGianTraLoi;
        private int soVong;
        private string luat;

        public int TimeForAnswer { get { return thoiGianTraLoi; } set { thoiGianTraLoi = value; } }
        public int NumberRound { get { return soVong; } set { soVong = value; } }
        public string Rule { get { return luat; } set { luat = value; } }

        public QuyDinhTroChoi() { }

        public QuyDinhTroChoi(int time, int round, string rule)
        {
            thoiGianTraLoi = time;
            soVong = round;
            luat = rule;
        }     
    }
}
