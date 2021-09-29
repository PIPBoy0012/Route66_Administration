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
    }
}
