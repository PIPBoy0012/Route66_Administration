using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route66_Administration
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static bool IsAdmin(byte input)
        {
            if (input == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
             
        }

        
    }
}
