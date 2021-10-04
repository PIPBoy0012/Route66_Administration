using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route66_Administration
{
    public class Brugere
    {
        public int id { get; set; }
        public string navn { get; set; }
        public string mail { get; set; }
        public int telefon { get; set; }
        public string password { get; set; }
        public bool admin { get; set; }

        public Brugere()
        {

        }

        public Brugere(int iD, string nAvn, bool aDmin)
        {
            id = iD;
            navn = nAvn;
            admin = aDmin;
        }
        public Brugere(int iD, string nAvn, string mAil,int tElefon, bool aDmin)
        {
            id = iD;
            navn = nAvn;
            mail = mAil;
            telefon = tElefon;
            admin = aDmin;
        }
        public string getInfo()
        {
            string line = ("ID: " + id.ToString() + ". Bruger: " + navn + ". Is Admin: " + admin);
            return line;
        }
    }
}
