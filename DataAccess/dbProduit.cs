using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess
{
    public class dbProduit
    {
       
            SqlConnection SqlConX = null;

        public void CloseConnexion()
        {
            if ((SqlConX != null) && SqlConX.State == ConnectionState.Open)
            {
                SqlConX.Close();
            }
        }
        //Méthode SelectAll qui exécute la procédure stockée SPX_Utilisateur_SelectAll
        public DataTable SelectAll(string pUserNomComplet)
        {
            SqlConX = mUtilities.maDBConnection();
            SqlConX.Open();
            SqlCommand cmd = new SqlCommand("SPX_ZouegnaProduit_SelectAll", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;
            //Ajout des paramètres
            SqlParameter prm;
            prm = new SqlParameter("@ZmDesignation", SqlDbType.VarChar, 50);
            prm.Value = pUserNomComplet;
            cmd.Parameters.Add(prm);
            //récupération des données
            DataTable dt;
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Remplissage du datatable
            da.Fill(dt);
            //Fermer la connexion
            CloseConnexion();
            return dt;
        }

        public string Insert(strProduit pUser)
        {
            try
            {
                SqlConX = mUtilities.maDBConnection();
                SqlConX.Open();
                SqlCommand cmd = new SqlCommand("SPX_ZouegnaProduit_Insert", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;
                //Ajout des paramètres
                SqlParameter prm;
                prm = new SqlParameter("@ZmProdID", SqlDbType.VarChar, 10);
                prm.Value = pUser.ZmProdID;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@ZmDesignation", SqlDbType.VarChar, 10);
                prm.Value = pUser.ZmDesignation;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@ZmQteStock", SqlDbType.VarChar, 50);
                prm.Value = pUser.ZmQteStock;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@ZmDateIvent", SqlDbType.VarChar, 20);
                prm.Value = pUser.ZmDateIvent;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@ZmImage", SqlDbType.VarChar, 50);
                prm.Value = pUser.ZmImage;
                cmd.Parameters.Add(prm);
                string res = (string)cmd.ExecuteScalar();
                CloseConnexion();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string Supprimer(string pLogin)
        {
            try
            {
                //Définition de la chaine de connexion
                SqlConX = mUtilities.maDBConnection();
                SqlConX.Open();
                SqlCommand cmd = new SqlCommand("SPX_ZouegnaProduit_Delete", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;
                //Ajout des paramètres
                SqlParameter prm;
                prm = new SqlParameter("@ZmProdID", SqlDbType.VarChar, 10);
                prm.Value = pLogin;
                cmd.Parameters.Add(prm);
                string res = (string)cmd.ExecuteScalar();
                SqlConX.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(strProduit pUser)
        {
            try
            {
                SqlConX = mUtilities.maDBConnection();
                SqlConX.Open();
                SqlCommand cmd = new SqlCommand("SPX_ZouegnaProduit_Update", SqlConX);
                cmd.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres
                SqlParameter prm;
                prm = new SqlParameter("@ZmProdID", SqlDbType.VarChar);
                prm.Value = pUser.ZmProdID;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@ZmDesignation", SqlDbType.VarChar, 10);
                prm.Value = pUser.ZmDesignation;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@ZmQteStock", SqlDbType.VarChar, 50);
                prm.Value = pUser.ZmQteStock;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@ZmQteStock", SqlDbType.VarChar, 50);
                prm.Value = pUser.ZmQteStock;
                cmd.Parameters.Add(prm);
                prm = new SqlParameter("@ZmDateIvent", SqlDbType.VarChar, 20);
                prm.Value = pUser.ZmDateIvent;
                prm = new SqlParameter("@ZmImage", SqlDbType.VarChar, 20);
                prm.Value = pUser.ZmImage;
                cmd.Parameters.Add(prm);
                // Exécuter la requête
                int rowsAffected = cmd.ExecuteNonQuery();

                CloseConnexion();
                return rowsAffected > 0; // Retourne vrai si une ligne a été mise à jour
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IDataReader GetObject(string pLogin)
        {
            IDataReader dr = null;
            //Définition de la chaine de connexion
            SqlConX = mUtilities.maDBConnection();
            SqlConX.Open();
            //Commande
            SqlCommand cmd = new SqlCommand("SPX_ZouegnaProduit_Get", SqlConX);
            cmd.CommandType = CommandType.StoredProcedure;
            //Paramètres
            SqlParameter prm;
            prm = new SqlParameter("@ZmProdID", SqlDbType.VarChar, 10);
            prm.Value = pLogin;
            cmd.Parameters.Add(prm);
            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}

