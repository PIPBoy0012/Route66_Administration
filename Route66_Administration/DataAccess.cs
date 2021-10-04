using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Route66_Administration
{
    public class DataAccess
    {
        private SqlCommand cmd;

        public SqlConnection conn = new SqlConnection( Helper.CnnVal("Route66DB"));

        public DataAccess()
        {
           // List<string>
        }
        public int getMaxID(SqlConnection conn, TextBox textBox)
        {
            int MaxID = 1;
            conn.Open();
            cmd = new SqlCommand("Select max(ID) from Brugere", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MaxID = reader.GetInt32(0);
            }
            reader.Close();
            conn.Close();
            return MaxID + 1 ;
        }
        public void allusers(SqlConnection conn, ListView listView)
        {
            conn.Open();
            cmd = new SqlCommand("Select * from Brugere", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Brugere bruger = new Brugere(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), Helper.IsAdmin(reader.GetByte(5)));
                listView.Items.Add(bruger.getInfo());
            }
            reader.Close();
            conn.Close();
        }
        public void getBruger(string command, SqlConnection conn, TextBox textBox)
        {
            conn.Open();
            cmd = new SqlCommand(command, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Brugere bruger = new Brugere(reader.GetInt32(0), reader.GetString(1),Helper.IsAdmin(reader.GetByte(2)));
                textBox.Text = bruger.getInfo();
            }
            reader.Close();
            conn.Close();
        }
    }
}
