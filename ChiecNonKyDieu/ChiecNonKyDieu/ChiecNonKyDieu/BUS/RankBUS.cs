using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiecNonKyDieu.DTO;
using ChiecNonKyDieu.DAO;

namespace ChiecNonKyDieu.BUS
{
    class RankBUS
    {
        DataRank data = new DataRank();
        public BXH GetTop10()
        {
            return data.GetTop10();
        }

        public void SaveWinner(Player pl)
        {
            data.SaveWinner(pl);
        }
    }
}
