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
    public partial class FrmMenuPrincipalZouegnaTes : Form
    {
        public FrmMenuPrincipalZouegnaTes()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipalZouegnaTes_Load(object sender, EventArgs e)
        {

        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmZouegnaProduit frm
                = new FrmZouegnaProduit();
            frm.ShowDialog();
        }
    }
}
