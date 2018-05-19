using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiecNonKyDieu.DTO
{
    public class CauHoi
    {
        private string maCauHoi;
        private ChuDe chuDe;
        private string noiDung;
        private string dapAn;
        private string dapAnDayDu;

        public string IDQuestion { get { return maCauHoi; } set { maCauHoi = value;} }
        public ChuDe Topic { get { return chuDe; } set { chuDe = value; } }
        public string Content { get { return noiDung; } set { noiDung = value; } }
        public string Answer { get { return dapAn; } set { dapAn = value; } }
        public string FullAnswer { get { return dapAnDayDu; } set { dapAnDayDu = value; } }

        public CauHoi() { }
        public CauHoi(string ma, ChuDe cd, string ndung, string dapan, string daydu)
        {
            maCauHoi = ma;
            chuDe = cd;
            noiDung = ndung;
            dapAn = dapan;
            dapAnDayDu = daydu;
        }
    }

    public class ChuDe
    {
        private string maChuDe;
        private string tenChuDe;

        public string IDTopic { get { return maChuDe; } set { maChuDe = value; } }
        public string NameTopic { get { return tenChuDe; } set { tenChuDe = value; } }
        public ChuDe() { }
        public ChuDe(string ma, string ten)
        {
            maChuDe = ma;
            tenChuDe = ten;
        }
    }
}