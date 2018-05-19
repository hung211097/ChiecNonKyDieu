using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChiecNonKyDieu.BUS;

namespace ChiecNonKyDieu.DTO
{

    public abstract class HeThong
    {
        protected string maHeThong = "";
        public HeThong() { }
        public HeThong(string ma)
        {
            maHeThong = ma;
        }

        public string CodeSystem { get { return maHeThong; } set { maHeThong = value; } }
        public abstract List<ChuDe> Topics ();
        public abstract List<CauHoi> Questions ();
        public abstract CauHoi GetQuestion(ChuDe cd);
        public abstract Playerlist PlayerList();
        public abstract void MakeDeal(int index, string code, int NumCharacter);
        public abstract void SaveResult();
        public abstract void SetPlayerlist(Playerlist l);
        public abstract string GetPoint(int x);
        public abstract void GetListPoint();
        public abstract bool ToExtraRound();
        public abstract Player GetWinner();
    }
       
    public class HeThongQuayNon : HeThong
    {
        private List<PointAward> listPoint;

        public override void GetListPoint()
        {
            PointBUS data = new PointBUS();
            listPoint = data.GetListPoint();
        }

        public override void SaveResult()
        {
            throw new NotImplementedException();
        }
        public override string GetPoint(int x)
        {
            int index = 0;
            int tmp = 360 / listPoint.Count;
            int temp = x + (tmp / 2) + 1;
            if (temp % tmp == 0)
                return "again";
            else
            {
                index = temp / tmp;
                return listPoint[index].Value;
            }
            return "error";
            //if (x >= 0 && x < 7 || x >= 353 && x < 360)
            //    return "2000";
            //else if (x >= 8 && x <= 21)
            //    return "100";
            //else if (x >= 23 && x <= 36)
            //    return "500";
            //else if (x >= 38 && x <= 51)
            //    return "x2";
            //else if (x >= 53 && x <= 66)
            //    return "200";
            //else if (x >= 68 && x <= 81)
            //    return "700";
            //else if (x >= 83 && x <= 96)
            //    return "1000";
            //else if (x >= 98 && x <= 111)
            //    return "400";
            //else if (x >= 113 && x <= 126)
            //    return "miss";
            //else if (x >= 128 && x <= 141)
            //    return "900";
            //else if (x >= 143 && x <= 156)
            //    return "lucky";
            //else if (x >= 158 && x <= 171)
            //    return "300";
            //else if (x >= 173 && x <= 186)
            //    return "800";
            //else if (x >= 188 && x <= 201)
            //    return "zero";
            //else if (x >= 203 && x <= 216)
            //    return "1000";
            //else if (x >= 218 && x <= 231)
            //    return "400";
            //else if (x >= 233 && x <= 246)
            //    return "600";
            //else if (x >= 248 && x <= 261)
            //    return "300";
            //else if (x >= 263 && x <= 276)
            //    return "more";
            //else if (x >= 278 && x <= 291)
            //    return "200";
            //else if (x >= 293 && x <= 306)
            //    return "900";
            //else if (x >= 308 && x <= 321)
            //    return "700";
            //else if (x >= 323 && x <= 336)
            //    return "/2";
            //else if (x >= 338 && x <= 351)
            //    return "300";
            //return "again";
        }

        public override CauHoi GetQuestion(ChuDe cd)
        {
            throw new NotImplementedException();
        }

        public override void MakeDeal(int index, string code, int NumCharacter)
        {
            throw new NotImplementedException();
        }

        public override Playerlist PlayerList()
        {
            throw new NotImplementedException();
        }

        public override List<CauHoi> Questions()
        {
            throw new NotImplementedException();
        }

        public override void SetPlayerlist(Playerlist l)
        {
            throw new NotImplementedException();
        }
      
        public override List<ChuDe> Topics()
        {
            throw new NotImplementedException();
        }

        public override bool ToExtraRound()
        {
            throw new NotImplementedException();
        }

        public override Player GetWinner()
        {
            throw new NotImplementedException();
        }
    }

    public class HeThongQuanLyCauHoi : HeThong
    {
        private List<ChuDe> chuDe = new List<ChuDe>();
        private List<CauHoi> cauHoi = new List<CauHoi>();

        public override List<ChuDe> Topics()
        {
            return chuDe;
        }

        public override List<CauHoi> Questions()
        {
            return cauHoi;
        }

        QuestionBUS data = new QuestionBUS();
        public override CauHoi GetQuestion(ChuDe cd)
        {
            List<CauHoi> l = data.GetQuestion(cd);

            Random rdm = new Random();
            bool isSame;
            int ques;
            int count = 0;
            for (int i = 0; i < cauHoi.Count; i++)
                for (int j = 0; j < l.Count; j++)
                    if (cauHoi[i].Topic.IDTopic == l[j].Topic.IDTopic && cauHoi[i].IDQuestion == l[j].IDQuestion)
                        count++;
            do
            {
                isSame = false;
                ques = rdm.Next(l.Count);
                int i;
                for (i = 0; i < cauHoi.Count; i++)
                {
                    if (cauHoi[i].IDQuestion == l[ques].IDQuestion)
                    {
                        isSame = true;
                    }
                }
                if (i == cauHoi.Count && isSame == true && count == l.Count)
                    return new CauHoi("", cd, "", "", "");
            } while (isSame);

            cauHoi.Add(l[ques]);
            return l[ques];
        }

        public override Playerlist PlayerList()
        {
            throw new NotImplementedException();
        }

        public override void MakeDeal(int index, string code, int NumCharacter)
        {
            throw new NotImplementedException();
        }

        public override void SaveResult()
        {
            throw new NotImplementedException();
        }

        public override void SetPlayerlist(Playerlist l)
        {
            throw new NotImplementedException();
        }

        public override string GetPoint(int x)
        {
            throw new NotImplementedException();
        }

        public override void GetListPoint()
        {
            throw new NotImplementedException();
        }

        public override bool ToExtraRound()
        {
            throw new NotImplementedException();
        }

        public override Player GetWinner()
        {
            throw new NotImplementedException();
        }
    }

    public class HeThongTinhDiem : HeThong
    {
        private Playerlist danhSachNguoiChoi;

        public override void SetPlayerlist(Playerlist l)
        {
            danhSachNguoiChoi = l;
        }

        public override Playerlist PlayerList()
        {
            return danhSachNguoiChoi;
        }

        public override void MakeDeal(int index, string code, int NumCharacter)
        {
            switch (code)
            {
                case "x2":
                    danhSachNguoiChoi.ListPLayer[index].Point *= 2;
                    break;
                case "/2":
                    danhSachNguoiChoi.ListPLayer[index].Point /= 2;
                    break;
                case "more":
                    break;                    
                case "zero":
                    danhSachNguoiChoi.ListPLayer[index].Point = 0;
                    break;
                case "correct":
                    danhSachNguoiChoi.ListPLayer[index].Point += (300 *  NumCharacter);
                    break;
                default:
                    danhSachNguoiChoi.ListPLayer[index].Point += (Int32.Parse(code) * NumCharacter);
                    break;
            }
        }

        public override bool ToExtraRound()
        {
            int MAX = 0;
            for (int i = 0; i < danhSachNguoiChoi.ListPLayer.Count; i++)
                if (danhSachNguoiChoi.ListPLayer[i].Point > MAX)
                    MAX = danhSachNguoiChoi.ListPLayer[i].Point;

            int count = 0;
            for (int i = 0; i < danhSachNguoiChoi.ListPLayer.Count; i++)
                if (danhSachNguoiChoi.ListPLayer[i].Point == MAX)
                    count++;
                else
                    danhSachNguoiChoi.ListPLayer[i].IsOut = true;

            bool isExtra = false;
            if (count > 1)
                isExtra = true;

            return isExtra;
        }

        public override void SaveResult()
        {
            RankBUS data = new RankBUS();
            for (int i = 0; i < danhSachNguoiChoi.ListPLayer.Count; i++)
                if(danhSachNguoiChoi.ListPLayer[i].IsOut == false)
                {
                    data.SaveWinner(danhSachNguoiChoi.ListPLayer[i]);
                    break;
                }
        }

        public override Player GetWinner()
        {
            Player player = new Player();
            for (int i = 0; i < danhSachNguoiChoi.ListPLayer.Count; i++)
                if (danhSachNguoiChoi.ListPLayer[i].IsOut == false)
                {
                    player.Nickname = danhSachNguoiChoi.ListPLayer[i].Nickname;
                    player.Point = danhSachNguoiChoi.ListPLayer[i].Point;
                    player.InitTime = danhSachNguoiChoi.ListPLayer[i].InitTime;
                    break;
                }
            return player;
        }

        public override List<CauHoi> Questions()
        {
            throw new NotImplementedException();
        }

        public override List<ChuDe> Topics()
        {
            throw new NotImplementedException();
        }

        public override void GetListPoint()
        {
            throw new NotImplementedException();
        }

        public override string GetPoint(int x)
        {
            throw new NotImplementedException();
        }

        public override CauHoi GetQuestion(ChuDe cd)
        {
            throw new NotImplementedException();
        }      
    }
}
