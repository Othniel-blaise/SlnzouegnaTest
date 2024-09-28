namespace Interface
{
    partial class FrmMenuPrincipalZouegnaTes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            produitToolStripMenuItem = new ToolStripMenuItem();
            composantToolStripMenuItem = new ToolStripMenuItem();
            constituerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produitToolStripMenuItem, composantToolStripMenuItem, constituerToolStripMenuItem });
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(73, 24);
            gestionToolStripMenuItem.Text = "Gestion";
            // 
            // produitToolStripMenuItem
            // 
            produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            produitToolStripMenuItem.Size = new Size(224, 26);
            produitToolStripMenuItem.Text = "Produit";
            produitToolStripMenuItem.Click += produitToolStripMenuItem_Click;
            // 
            // composantToolStripMenuItem
            // 
            composantToolStripMenuItem.Name = "composantToolStripMenuItem";
            composantToolStripMenuItem.Size = new Size(224, 26);
            composantToolStripMenuItem.Text = "Composant";
            // 
            // constituerToolStripMenuItem
            // 
            constituerToolStripMenuItem.Name = "constituerToolStripMenuItem";
            constituerToolStripMenuItem.Size = new Size(224, 26);
            constituerToolStripMenuItem.Text = "Constituer";
            // 
            // FrmMenuPrincipalZouegnaTes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuPrincipalZouegnaTes";
            Text = "FrmMenuPrincipalZouegnaTes";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenuPrincipalZouegnaTes_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem produitToolStripMenuItem;
        private ToolStripMenuItem composantToolStripMenuItem;
        private ToolStripMenuItem constituerToolStripMenuItem;
    }
}