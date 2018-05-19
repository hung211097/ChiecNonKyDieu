using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiecNonKyDieu.DTO
{
    public class Player
    {
        private string tenHienThi;
        private int soDiem;
        private string thoiGianTao;
        private bool biloai = false;

        public string Nickname { get { return tenHienThi; } set { tenHienThi = value; } }
        public int Point { get { return soDiem; } set { soDiem = value; } }
        public string InitTime { get { return thoiGianTao; } set { thoiGianTao = value; } }
        public bool IsOut { get { return biloai; } set { biloai = value;} }

        public Player() { }
        public Player(string ten, int diem, string time)
        {
            tenHienThi = ten;
            soDiem = diem;
            thoiGianTao = time;
        }       
    }

    public class Playerlist
    {
        private List<Player> listP = new List<Player>();

        public List<Player> ListPLayer { get { return listP;  } set { listP = value; } }
        public Playerlist() { }
        public Playerlist(List<Player> x) { listP = x; }
        public void AddPlayer(Player x)
        {
            listP.Add(x);
        }
    }
}