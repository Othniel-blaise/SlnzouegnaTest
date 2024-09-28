namespace Interface
{
    partial class FrmZouegnaProduitDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProduit_id = new TextBox();
            txtQteStock = new TextBox();
            txtImage = new TextBox();
            txtDateIvent = new TextBox();
            txtDesignation = new TextBox();
            btnEnregistre = new Button();
            btnFermer = new Button();
            openFileDialog1 = new OpenFileDialog();
            buttonOpenFileDialog = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 85);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Identifiant Produit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 151);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Designation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 227);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 2;
            label3.Text = "Quantité Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 293);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 3;
            label4.Text = "Date Iventaire";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 347);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Image";
            // 
            // txtProduit_id
            // 
            txtProduit_id.Location = new Point(337, 85);
            txtProduit_id.Name = "txtProduit_id";
            txtProduit_id.Size = new Size(252, 27);
            txtProduit_id.TabIndex = 5;
            // 
            // txtQteStock
            // 
            txtQteStock.Location = new Point(337, 227);
            txtQteStock.Name = "txtQteStock";
            txtQteStock.Size = new Size(252, 27);
            txtQteStock.TabIndex = 6;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(337, 347);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(252, 27);
            txtImage.TabIndex = 7;
            // 
            // txtDateIvent
            // 
            txtDateIvent.Location = new Point(337, 286);
            txtDateIvent.Name = "txtDateIvent";
            txtDateIvent.Size = new Size(252, 27);
            txtDateIvent.TabIndex = 8;
            // 
            // txtDesignation
            // 
            txtDesignation.Location = new Point(337, 151);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(252, 27);
            txtDesignation.TabIndex = 9;
            // 
            // btnEnregistre
            // 
            btnEnregistre.Location = new Point(347, 411);
            btnEnregistre.Name = "btnEnregistre";
            btnEnregistre.Size = new Size(94, 29);
            btnEnregistre.TabIndex = 10;
            btnEnregistre.Text = "Enregistre";
            btnEnregistre.UseVisualStyleBackColor = true;
            btnEnregistre.Click += btnEnregistre_Click;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(495, 409);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(94, 29);
            btnFermer.TabIndex = 11;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // buttonOpenFileDialog
            // 
            buttonOpenFileDialog.Location = new Point(606, 343);
            buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            buttonOpenFileDialog.Size = new Size(94, 29);
            buttonOpenFileDialog.TabIndex = 12;
            buttonOpenFileDialog.Text = "...";
            buttonOpenFileDialog.UseVisualStyleBackColor = true;
            buttonOpenFileDialog.Click += buttonOpenFileDialog_Click;
            // 
            // FrmZouegnaProduitDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOpenFileDialog);
            Controls.Add(btnFermer);
            Controls.Add(btnEnregistre);
            Controls.Add(txtDesignation);
            Controls.Add(txtDateIvent);
            Controls.Add(txtImage);
            Controls.Add(txtQteStock);
            Controls.Add(txtProduit_id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmZouegnaProduitDetails";
            Text = "FrmZouegnaProduitDetails";
            Load += FrmZouegnaProduitDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProduit_id;
        private TextBox txtQteStock;
        private TextBox txtImage;
        private TextBox txtDateIvent;
        private TextBox txtDesignation;
        private Button btnEnregistre;
        private Button btnFermer;
        private OpenFileDialog openFileDialog1;
        private Button buttonOpenFileDialog;
    }
}