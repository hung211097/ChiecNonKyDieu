using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiecNonKyDieu.DTO;

namespace ChiecNonKyDieu.DAO
{
    class DataQuestion
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=CNKD;Integrated Security=True");
        public List<CauHoi> GetQuestion(ChuDe cd)
        {
            cnn.Open();
            DataTable tb = new DataTable();
            SqlCommand com = new SqlCommand("select * from CauHoi where CauHoi.ChuDe = @ID", cnn);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@ID", cd.IDTopic);
            com.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(tb);

            List<CauHoi> l = new List<CauHoi>();
            for(int i = 0; i < tb.Rows.Count; i++)
            {
                l.Add(new CauHoi(tb.Rows[i][0].ToString(), cd, tb.Rows[i][2].ToString(), tb.Rows[i][3].ToString(), tb.Rows[i][4].ToString()));
            }
            cnn.Close();
            return l;
        }
    }
}
