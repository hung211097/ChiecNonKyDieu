using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiecNonKyDieu.DTO
{
    class PointAward
    {
        private string ma;
        private string ten;
        private string giatri;

        public string ID { get { return ma; } set { ma = value; } }
        public string Name { get { return ten; } set { ten = value; } }
        public string Value { get { return giatri; } set { giatri = value; } }
        public PointAward() { }
        public PointAward(string Ma, string Ten, string Giatri)
        {
            ma = Ma;
            ten = Ten;
            giatri = Giatri;
        }
    }
}
