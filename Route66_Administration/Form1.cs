using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route66_Administration
{
    public partial class Form1 : Form
    {
        Brugere vinder;

        public Form1()
        {
            InitializeComponent();
        }

        private void vinderBruger_Click(object sender, EventArgs e)
        {

        }

        private void hentVinder_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            vinder = db.vinder();
            db.conn.Open();
            db.command("SELECT * FROM Brugere", db.conn)
        }
    }
}
