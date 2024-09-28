using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmConnexionZouegnaTest : Form
    {
        public FrmConnexionZouegnaTest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipalZouegnaTes frm
                = new FrmMenuPrincipalZouegnaTes();
            frm.ShowDialog();   
        }
    }
}
