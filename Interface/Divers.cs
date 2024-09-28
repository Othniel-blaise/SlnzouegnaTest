using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Divers
    {
        public static Boolean ExisteUtilisateur(string pCode)
        {
            Produit unUser = new Produit(pCode);
            if (unUser.ZmProdID == null)
            {
                return false;
            }
            else
            {
                if (unUser.ZmProdID.ToUpper() == pCode.ToUpper())
                {
                    return true;
                }
                return false;
            }
        }

    }
}