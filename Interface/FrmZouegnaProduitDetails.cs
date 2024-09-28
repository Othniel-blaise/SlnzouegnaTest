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
    public partial class FrmZouegnaProduitDetails : Form
    {
        char vOptionAppel = 'n'; //attribut permettant de définir le contexte d'appel ('n','m','c','s')
        string vTitre = "";//permet de définir le titre du formulaire en fonction du contexte d'appel
        Produit CurrentUser = null;// objet métier contenant l'utilisateur en cours de traitement
        public FrmZouegnaProduitDetails()
        {
            InitializeComponent();
            InitForm(vOptionAppel);
        }
        public FrmZouegnaProduitDetails(Produit LeUser, char pOptionAppel)
        {
            InitializeComponent();
            CurrentUser = LeUser;//réccupération de l'utilisateur courant dans l'attribut CurrentUser
            vOptionAppel = pOptionAppel; //affectation de l'option d'appel dans l'attribut vOptionAppel
            InitForm(vOptionAppel);// méthode d'initialisation du titre et des contrôles du formulaire selon l'option d'appel
            ChargerLeUser(LeUser);//méthode d'affichage de l'utilisateur en cours de traitement
        }

        private void FrmZouegnaProduitDetails_Load(object sender, EventArgs e)
        {

        }
        private void InitForm(char optionAppel)
        {
            switch (optionAppel)
            {
                case 'n':
                    vTitre = "Nouvel utilisateur";
                    // Configuration des contrôles pour un nouvel utilisateur
                    break;
                case 'm':
                    vTitre = "Modifier utilisateur";
                    // Configuration des contrôles pour la modification d'un utilisateur
                    break;
                case 'c':
                    vTitre = "Consulter utilisateur";
                    // Configuration des contrôles pour la consultation d'un utilisateur
                    break;
                case 's':
                    vTitre = "Supprimer utilisateur";
                    // Configuration des contrôles pour la suppression d'un utilisateur
                    break;
                default:
                    vTitre = "Détail utilisateur";
                    // Configuration par défaut
                    break;
            }
            //this.Text = vTitre; // Mise à jour du titre de la fenêtre
        }
        private void ChargerLeUser(Produit LeUser)
        {
            if (LeUser != null)
            {
                // Vérification et affectation des propriétés de l'utilisateur aux champs du formulaire
                if (!string.IsNullOrEmpty(LeUser.ZmProdID))
                {
                    txtProduit_id.Text = LeUser.ZmProdID;
                }

                if (!string.IsNullOrEmpty(LeUser.ZmDesignation))
                {
                    txtDesignation.Text = LeUser.ZmDesignation;
                }

                if (!string.IsNullOrEmpty(LeUser.ZmQteStock))
                {
                    txtQteStock.Text = LeUser.ZmQteStock;
                }

                if (!string.IsNullOrEmpty(LeUser.ZmDateIvent))
                {
                    txtDateIvent.Text = LeUser.ZmDateIvent;
                }

                if (!string.IsNullOrEmpty(LeUser.ZmImage))
                {
                    txtImage.Text = LeUser.ZmImage;
                }
            }
            else
            {
                // Réinitialisation des champs si LeUser est nul
                txtProduit_id.Text = string.Empty;
                txtDesignation.Text = string.Empty;
                txtQteStock.Text = string.Empty;
                txtDateIvent.Text = string.Empty;
                txtImage.Text = string.Empty;
            }
        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            if (OkSaisie())
            {
                MappFormToObject();
                switch (vOptionAppel)
                {
                    case 'n':
                        if (!Divers.ExisteUtilisateur(txtProduit_id.Text))
                        {
                            CurrentUser.Insert();
                            MessageBox.Show("l'Utilisateur a été enregistré ", Application.ProductName, MessageBoxButtons.OK);
                        }
                        else MessageBox.Show("Risque de doublon. la saisie ne sera pas enregistrée ", Application.ProductName, MessageBoxButtons.OK);
                        break;
                    case 'c':
                        break;
                    //case 'm':
                    //    if (Divers.ExisteUtilisateur(txtProduit_id.Text))
                    //    {
                    //        CurrentUser.Update();
                    //        MessageBox.Show("Les modifications ont été enregistrées ", Application.ProductName, MessageBoxButtons.OK);
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("code utilisateur inexistant! les modifications ont été ignorées", Application.ProductName, MessageBoxButtons.OK);
                    //    }
                    //    break;
                    case 's':
                        CurrentUser.Supprimer(txtProduit_id.Text);
                        MessageBox.Show("L'utilisateur a été désactivé", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
                this.Close();
            }

        }
        private void MappFormToObject()
        {
            // méthode MappFormToObject() qui affecte la saisie à l'objet produit de la classe métier
            CurrentUser = new Produit();
            CurrentUser.ZmProdID = txtProduit_id.Text;
            CurrentUser.ZmDesignation = txtDesignation.Text;
            CurrentUser.ZmQteStock = txtQteStock.Text;
            CurrentUser.ZmDateIvent = txtDateIvent.Text;
            CurrentUser.ZmImage = txtImage.Text;
        }

        private bool OkSaisie()
        {
            /* méthode OkSaisie() de contrôle de la régularité de la saisie de l'utilisateur
             * qui souhaite enregistrer un produit par clic sur le bouton btnEnregistrer
             */

            if (string.IsNullOrEmpty(txtProduit_id.Text))
            {
                MessageBox.Show("Identifiant du produit attendu", Application.ProductName, MessageBoxButtons.OK);
                txtProduit_id.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDesignation.Text))
            {
                MessageBox.Show("Désignation du produit attendue", Application.ProductName, MessageBoxButtons.OK);
                txtDesignation.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtQteStock.Text))
            {
                MessageBox.Show("Quantité en stock attendue", Application.ProductName, MessageBoxButtons.OK);
                txtQteStock.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDateIvent.Text))
            {
                MessageBox.Show("Date d'inventaire attendue", Application.ProductName, MessageBoxButtons.OK);
                txtDateIvent.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtImage.Text))
            {
                MessageBox.Show("Image du produit attendue", Application.ProductName, MessageBoxButtons.OK);
                txtImage.Focus();
                return false;
            }

            return true;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
           Application.Exit();  
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            // Créez une instance d'OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurez les propriétés d'OpenFileDialog
            openFileDialog.InitialDirectory = "SlnzouegnaTest\\image"; // Répertoire par défaut
            openFileDialog.Filter = "Images (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|Tous les fichiers (*.*)|*.*"; // Filtre pour les images
            openFileDialog.FilterIndex = 1; // Le filtre pour les images sera affiché en premier
            openFileDialog.RestoreDirectory = true;

            // Affichez la boîte de dialogue et vérifiez si l'utilisateur a sélectionné un fichier
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtenez le chemin complet du fichier sélectionné
                string selectedFilePath = openFileDialog.FileName;
                txtImage.Text = selectedFilePath;

                // Affichez le chemin du fichier dans une boîte de message
                MessageBox.Show("Image sélectionnée : " + selectedFilePath, "Fichier ouvert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucune image sélectionnée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
           
        }

    }

}
 


      