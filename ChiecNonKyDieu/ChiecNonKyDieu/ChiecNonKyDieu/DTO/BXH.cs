using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiecNonKyDieu.DTO
{
    public class BXH
    {
        private Playerlist listP;
        
        public Playerlist ListPlayer { get { return listP; } set { listP = value; } }
        public BXH() { }
        public BXH (Playerlist x)
        {
            listP = x;
        }
    }
}
