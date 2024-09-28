namespace Interface
{
    partial class FrmZouegnaProduit
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
            lviewRech = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnAjouter = new Button();
            btnFermer = new Button();
            btnSupprimer = new Button();
            btnConsulter = new Button();
            btnModifier = new Button();
            txtFiltre = new TextBox();
            btnActualiser = new Button();
            SuspendLayout();
            // 
            // lviewRech
            // 
            lviewRech.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lviewRech.FullRowSelect = true;
            lviewRech.GridLines = true;
            lviewRech.Location = new Point(12, 107);
            lviewRech.Name = "lviewRech";
            lviewRech.Size = new Size(1067, 403);
            lviewRech.TabIndex = 0;
            lviewRech.UseCompatibleStateImageBehavior = false;
            lviewRech.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Produit";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Designation";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quantité de Stock";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Date d'inventaire";
            columnHeader4.Width = 400;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Image";
            columnHeader5.Width = 300;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(429, 528);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(943, 528);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(94, 29);
            btnFermer.TabIndex = 2;
            btnFermer.Text = "Femer";
            btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(818, 527);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 29);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnConsulter
            // 
            btnConsulter.Location = new Point(704, 528);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(94, 29);
            btnConsulter.TabIndex = 4;
            btnConsulter.Text = "Consulter";
            btnConsulter.UseVisualStyleBackColor = true;
            btnConsulter.Click += btnConsulter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(560, 527);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(94, 29);
            btnModifier.TabIndex = 5;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // txtFiltre
            // 
            txtFiltre.Location = new Point(805, 54);
            txtFiltre.Name = "txtFiltre";
            txtFiltre.Size = new Size(181, 27);
            txtFiltre.TabIndex = 6;
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(1007, 54);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(94, 29);
            btnActualiser.TabIndex = 7;
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            // 
            // FrmZouegnaProduit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 568);
            Controls.Add(btnActualiser);
            Controls.Add(txtFiltre);
            Controls.Add(btnModifier);
            Controls.Add(btnConsulter);
            Controls.Add(btnSupprimer);
            Controls.Add(btnFermer);
            Controls.Add(btnAjouter);
            Controls.Add(lviewRech);
            Name = "FrmZouegnaProduit";
            Text = "FrmZouegnaProduit";
            Load += FrmZouegnaProduit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lviewRech;
        private Button btn;
        private Button btnFermer;
        private Button btnSupprimer;
        private Button btnConsulter;
        private Button btnModifier;
        private Button btnAjouter;
        private TextBox txtFiltre;
        private Button btnActualiser;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}