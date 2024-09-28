namespace Interface
{
    partial class FrmConnexionZouegnaTest
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
            label2 = new Label();
            label1 = new Label();
            txtId = new TextBox();
            txtPssw = new TextBox();
            btnOk = new Button();
            btnFermer = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 187);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Mot de passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 71);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "identifiant";
            // 
            // txtId
            // 
            txtId.Location = new Point(350, 67);
            txtId.Name = "txtId";
            txtId.Size = new Size(201, 27);
            txtId.TabIndex = 3;
            // 
            // txtPssw
            // 
            txtPssw.Location = new Point(350, 187);
            txtPssw.Name = "txtPssw";
            txtPssw.Size = new Size(201, 27);
            txtPssw.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(169, 342);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 5;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(457, 342);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(94, 29);
            btnFermer.TabIndex = 6;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // FrmConnexionZouegnaTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFermer);
            Controls.Add(btnOk);
            Controls.Add(txtPssw);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "FrmConnexionZouegnaTest";
            Text = "FrmConnexionZouegnaTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox txtId;
        private TextBox txtPssw;
        private Button btnOk;
        private Button btnFermer;
    }
}