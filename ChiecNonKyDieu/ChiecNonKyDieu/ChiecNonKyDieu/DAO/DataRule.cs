using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChiecNonKyDieu.DTO;

namespace ChiecNonKyDieu.DAO
{
    class DataRule
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=CNKD;Integrated Security=True");

        public QuyDinhTroChoi GetGuideLine()
        {
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("select * from ThamSo", cnn));
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            int round = Int32.Parse(tb.Rows[0][3].ToString());
            int time = Int32.Parse(tb.Rows[1][3].ToString());

            adapter = new SqlDataAdapter(new SqlCommand("Select * from DanhMuc", cnn));
            tb = new DataTable();
            adapter.Fill(tb);
            string rule = tb.Rows[0][2].ToString();
            cnn.Close();
            return new QuyDinhTroChoi(time, round, rule);
        }

        public void SetThongSo(QuyDinhTroChoi qd)
        {
            cnn.Open();
            SqlCommand com = new SqlCommand("update ThamSo set ThamSo.GiaTri = @round where ThamSo.ID = @id", cnn);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@id", "svong");
            com.Parameters.AddWithValue("@round", qd.NumberRound);
            com.ExecuteNonQuery();

            com = new SqlCommand("update ThamSo set ThamSo.GiaTri = @time where ThamSo.ID = @id", cnn);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@id", "tgcho");
            com.Parameters.AddWithValue("@time", qd.TimeForAnswer);
            com.ExecuteNonQuery();

            cnn.Close();     
        }
    }
}
