using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common
{
    public class mUtilities
    {

        public static SqlConnection maDBConnection()
        {
            //définition de la chaine de connexion
            string conxstr = @"Data Source=(local);Initial Catalog=dbZouegnaOthnielTest;Integrated Security=True";
            SqlConnection conX = new SqlConnection(conxstr);
            return conX;
        }
    }
}
