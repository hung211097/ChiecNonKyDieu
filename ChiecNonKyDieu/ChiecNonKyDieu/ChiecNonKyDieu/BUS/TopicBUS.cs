using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiecNonKyDieu.DAO;
using ChiecNonKyDieu.DTO;

namespace ChiecNonKyDieu.BUS
{
    class TopicBUS
    {
        DataTopic data = new DataTopic();
        public List<ChuDe> GetAllTopics()
        {
            return data.GetAllTopics();
        }
    }
}
