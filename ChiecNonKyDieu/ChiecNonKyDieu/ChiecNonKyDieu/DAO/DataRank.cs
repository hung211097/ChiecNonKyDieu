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
    class DataRank
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=CNKD;Integrated Security=True");
        public BXH GetTop10()
        {
            cnn.Open();
            SqlCommand com = new SqlCommand("select top 10 * from BangXepHang order by SoDiem desc", cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable tb = new DataTable();
            com.ExecuteNonQuery();

            adapter.Fill(tb);
            BXH bxh = new BXH();
            Playerlist list = new Playerlist();
            for(int i = 0; i < tb.Rows.Count; i++)
            {                 
                DateTime date = (DateTime)tb.Rows[i][1];
                Player player = new Player(tb.Rows[i][0].ToString(), Int32.Parse(tb.Rows[i][2].ToString()), date.ToString());
                list.AddPlayer(player);  
            }
            bxh.ListPlayer = list;
            cnn.Close();
            return bxh;
        }

        public void SaveWinner(Player pl)
        {
            cnn.Open();
            SqlCommand com = new SqlCommand("insert into BangXepHang values(@ten, @tgian, @point)", cnn);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@ten", pl.Nickname);
            com.Parameters.AddWithValue("@tgian", pl.InitTime);
            com.Parameters.AddWithValue("@point", pl.Point);
            com.ExecuteNonQuery();

            cnn.Close();        
        }
    }
}
