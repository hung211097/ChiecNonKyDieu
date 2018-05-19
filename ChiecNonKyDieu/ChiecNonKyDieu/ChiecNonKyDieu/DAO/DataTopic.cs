using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiecNonKyDieu.DTO;

namespace ChiecNonKyDieu.DAO
{
    class DataTopic
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=CNKD;Integrated Security=True");

        public List<ChuDe> GetAllTopics()
        {
            cnn.Open();
            List<ChuDe> l = new List<ChuDe>();
            SqlCommand com = new SqlCommand("select * from ChuDe", cnn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();

            DataTable tb = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(tb);

            for(int i = 0; i < tb.Rows.Count; i++)
            {
                l.Add(new ChuDe(tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString()));
            }


            cnn.Close();
            return l;
        }
    }
}
