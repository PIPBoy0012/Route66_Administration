using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Route66_Administration
{
    public class DataAccess
    {
        private SqlCommand cmd;

        public Brugere vinder()
        {
            throw new NotImplementedException();
        }

        public SqlConnection conn = new SqlConnection( Helper.CnnVal("Route66DB"));

        public void command(string command, SqlConnection conn)
        {
            cmd = new SqlCommand(command, conn);
        }
    }
}
