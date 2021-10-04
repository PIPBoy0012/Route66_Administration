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
        DataAccess db;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            db = new DataAccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.allusers(db.conn, listView1);
        }

        private void hentVinder_Click(object sender, EventArgs e)
        {
            int randomId = rnd.Next(1, db.getMaxID(db.conn, vinderTextbox));
            db.getBruger("Select ID, brugerNavn, admin FROM Brugere WHERE ID =" + randomId, db.conn, vinderTextbox);
            
        }

        
    }
}
