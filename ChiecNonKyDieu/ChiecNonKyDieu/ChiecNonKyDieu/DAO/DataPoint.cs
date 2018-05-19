using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using ChiecNonKyDieu.DTO;

namespace ChiecNonKyDieu.DAO
{
    class DataPoint
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=CNKD;Integrated Security=True");
        public List<PointAward> GetListPoint()
        {
            List<PointAward> l = new List<PointAward>();
            cnn.Open();

            DataTable tb = new DataTable();
            SqlCommand com = new SqlCommand("select * from DiemThuong", cnn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(tb);

            for (int i = 0; i < tb.Rows.Count; i++)
                l.Add(new PointAward(tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString(), tb.Rows[i][2].ToString()));

            cnn.Close();
            return l;
        }
    }
}
