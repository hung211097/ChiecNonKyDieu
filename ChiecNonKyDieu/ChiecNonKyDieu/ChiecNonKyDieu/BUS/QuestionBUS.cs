using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiecNonKyDieu.DTO;
using ChiecNonKyDieu.DAO;

namespace ChiecNonKyDieu.BUS
{
    class QuestionBUS
    {
        DataQuestion data = new DataQuestion();
        public List<CauHoi> GetQuestion(ChuDe cd)
        {
            return data.GetQuestion(cd);
        }
    }
}
