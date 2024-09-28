using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DataAccess;

namespace Metier
{
    public class Produit
    {
        // Définition des attributs
        private string _ZmProdID;
        private string _ZmDesignation;
        private string _ZmQteStock;
        private string _ZmDateIvent;
        private string _ZmImage;

        // Définition des propriétés ou accesseurs
        public string ZmProdID
        {
            get { return _ZmProdID; }
            set { _ZmProdID = value; }
        }

        public string ZmDesignation
        {
            get { return _ZmDesignation; }
            set { _ZmDesignation = value; }
        }

        public string ZmQteStock
        {
            get { return _ZmQteStock; }
            set { _ZmQteStock = value; }
        }

        public string ZmDateIvent
        {
            get { return _ZmDateIvent; }
            set { _ZmDateIvent = value; }
        }

        public string ZmImage
        {
            get { return _ZmImage; }
            set { _ZmImage = value; }
        }

         strProduit MyStructure
        {
            get
            {
                strProduit st = new strProduit();
                st.ZmProdID = this._ZmProdID;
                st.ZmDesignation = this._ZmDesignation;
                st.ZmQteStock = this._ZmQteStock;
                st.ZmDateIvent = this._ZmDateIvent;
                st.ZmImage = this._ZmImage;
                return st;
            }
        }

        // Méthode de mapping depuis un IDataReader
        public void MapFromDataReader(IDataReader dreader)
        {
            if (!(DBNull.Value.Equals(dreader["ZmProdID"])))
            {
                _ZmProdID = (string)dreader["ZmProdID"];
            }
            if (!(DBNull.Value.Equals(dreader["ZmDesignation"])))
            {
                _ZmDesignation = (string)dreader["ZmDesignation"];
            }
            if (!(DBNull.Value.Equals(dreader["ZmQteStock"])))
            {
                _ZmQteStock = (string)dreader["ZmQteStock"];
            }
            if (!(DBNull.Value.Equals(dreader["ZmDateIvent"])))
            {
                _ZmDateIvent = (string)dreader["ZmDateIvent"];
            }
            if (!(DBNull.Value.Equals(dreader["ZmImage"])))
            {
                _ZmImage = (string)dreader["ZmImage"];
            }
        }

        // Méthode pour sélectionner tous les produits
        public static DataTable SelectAll(string pUserNom)
        {
            dbProduit undbUser = new dbProduit();
            DataTable dt = undbUser.SelectAll(pUserNom);
            return dt;
        }

        // Méthode d'insertion
        public void Insert()
        {
            dbProduit undbUser = new dbProduit();
            undbUser.Insert(this.MyStructure);
        }

        // Méthode de mise à jour
        public void Update()
        {
            dbProduit undbUser = new dbProduit();
            undbUser.Update(this.MyStructure);
        }

        // Méthode de suppression
        public void Supprimer(string pLogin)
        {
            dbProduit undbUser = new dbProduit();
            undbUser.Supprimer(pLogin);
        }

        // Constructeur pour obtenir un produit par ID
        public Produit(string pLogin)
        {
            dbProduit db = new dbProduit();
            IDataReader dreader = db.GetObject(pLogin);
            if (dreader.Read())
            {
                this.MapFromDataReader(dreader);
            }
            db.CloseConnexion();
        }

        // Constructeur par défaut
        public Produit()
        { }
    }
}

