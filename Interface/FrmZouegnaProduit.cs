using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace Interface
{
    public partial class FrmZouegnaProduit : Form
    {
        public FrmZouegnaProduit()
        {
            InitializeComponent();
            rafraichirList();
        }
        private void rafraichirList()
        {
            lviewRech.Items.Clear();
            DataTable dt = Produit.SelectAll(txtFiltre.Text);

            // Handle case when dt is null
            //if (dt == null)
            //{
            //    MessageBox.Show("No data available or an error occurred while fetching data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            foreach (DataRow row in dt.Rows)
            {
                string vProdID = "";
                string vDesignation = "";
                string vQteStock = "";
                string vDateIvent = "";
                string vImage = "";

                if (!DBNull.Value.Equals(row["ZmProdID"])) vProdID = (string)row["ZmProdID"];
                if (!DBNull.Value.Equals(row["ZmDesignation"])) vDesignation = (string)row["ZmDesignation"];
                if (!DBNull.Value.Equals(row["ZmQteStock"])) vQteStock = (string)row["ZmQteStock"];
                if (!DBNull.Value.Equals(row["ZmDateIvent"])) vDateIvent = (string)row["ZmDateIvent"];
                if (!DBNull.Value.Equals(row["ZmImage"])) vImage = (string)row["ZmImage"];

                ListViewItem itm = lviewRech.Items.Add(vProdID);
                itm.SubItems.Add(vDesignation);
                itm.SubItems.Add(vQteStock);
                itm.SubItems.Add(vDateIvent);
                itm.SubItems.Add(vImage);
                itm.Tag = vProdID;
            }
        }
        private void FrmZouegnaProduit_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmZouegnaProduitDetails frm = new
                FrmZouegnaProduitDetails(null, 'n');
            frm.ShowDialog();
            rafraichirList();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lviewRech.SelectedItems.Count > 0)
            {
                string vid = (string)lviewRech.SelectedItems[0].Tag;
                Produit leUser = new Produit(vid);
                FrmZouegnaProduitDetails frm = new FrmZouegnaProduitDetails(leUser, 'm');
                frm.ShowDialog();
                rafraichirList();
            }
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {
            if (lviewRech.SelectedItems.Count > 0)
            {
                string vid = (string)lviewRech.SelectedItems[0].Tag;
                Produit leUser = new Produit(vid);
                FrmZouegnaProduitDetails frm = new FrmZouegnaProduitDetails(leUser, 'c');
                frm.ShowDialog();
                rafraichirList();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lviewRech.SelectedItems.Count > 0)
            {
                string vid = (string)lviewRech.SelectedItems[0].Tag;
                Produit leUser = new Produit(vid);
                FrmZouegnaProduitDetails frm = new FrmZouegnaProduitDetails(leUser, 's');
                frm.ShowDialog();
                rafraichirList();
            }
        }
    }
}
