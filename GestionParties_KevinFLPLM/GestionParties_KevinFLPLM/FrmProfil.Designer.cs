namespace GestionParties_KevinFLPLM
{
    partial class FrmProfil
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
            lblTitre = new Label();
            llbBack = new LinkLabel();
            lblNom = new Label();
            lblPrenom = new Label();
            lblNumero = new Label();
            lblEmail = new Label();
            lblPseudo = new Label();
            lblMdp = new Label();
            tbxNom = new TextBox();
            tbxPrenom = new TextBox();
            tbxPseudo = new TextBox();
            tbxEmail = new TextBox();
            tbxNumero = new TextBox();
            tbxMdp = new TextBox();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre.Location = new Point(140, 20);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(154, 37);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Mon profil";
            // 
            // llbBack
            // 
            llbBack.AutoSize = true;
            llbBack.Location = new Point(12, 9);
            llbBack.Name = "llbBack";
            llbBack.Size = new Size(101, 15);
            llbBack.TabIndex = 1;
            llbBack.TabStop = true;
            llbBack.Text = "Revenir à l'accueil";
            llbBack.LinkClicked += lblBack_LinkClicked;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNom.Location = new Point(130, 90);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(49, 20);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrenom.Location = new Point(112, 125);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(67, 20);
            lblPrenom.TabIndex = 3;
            lblPrenom.Text = "Prénom :";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumero.Location = new Point(13, 245);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(166, 20);
            lblNumero.TabIndex = 4;
            lblNumero.Text = " Numéro de téléphone :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(126, 205);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email :";
            // 
            // lblPseudo
            // 
            lblPseudo.AutoSize = true;
            lblPseudo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPseudo.Location = new Point(115, 165);
            lblPseudo.Name = "lblPseudo";
            lblPseudo.Size = new Size(64, 20);
            lblPseudo.TabIndex = 6;
            lblPseudo.Text = "Pseudo :";
            // 
            // lblMdp
            // 
            lblMdp.AutoSize = true;
            lblMdp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblMdp.Location = new Point(74, 285);
            lblMdp.Name = "lblMdp";
            lblMdp.Size = new Size(105, 20);
            lblMdp.TabIndex = 7;
            lblMdp.Text = "Mot de passe :";
            // 
            // tbxNom
            // 
            tbxNom.Location = new Point(205, 91);
            tbxNom.Name = "tbxNom";
            tbxNom.ReadOnly = true;
            tbxNom.Size = new Size(145, 23);
            tbxNom.TabIndex = 8;
            // 
            // tbxPrenom
            // 
            tbxPrenom.Location = new Point(205, 126);
            tbxPrenom.Name = "tbxPrenom";
            tbxPrenom.ReadOnly = true;
            tbxPrenom.Size = new Size(145, 23);
            tbxPrenom.TabIndex = 9;
            // 
            // tbxPseudo
            // 
            tbxPseudo.Location = new Point(205, 166);
            tbxPseudo.Name = "tbxPseudo";
            tbxPseudo.ReadOnly = true;
            tbxPseudo.Size = new Size(145, 23);
            tbxPseudo.TabIndex = 10;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(205, 206);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.ReadOnly = true;
            tbxEmail.Size = new Size(145, 23);
            tbxEmail.TabIndex = 11;
            // 
            // tbxNumero
            // 
            tbxNumero.Location = new Point(205, 246);
            tbxNumero.Name = "tbxNumero";
            tbxNumero.ReadOnly = true;
            tbxNumero.Size = new Size(145, 23);
            tbxNumero.TabIndex = 12;
            // 
            // tbxMdp
            // 
            tbxMdp.Location = new Point(205, 286);
            tbxMdp.Name = "tbxMdp";
            tbxMdp.ReadOnly = true;
            tbxMdp.Size = new Size(145, 23);
            tbxMdp.TabIndex = 13;
            tbxMdp.UseSystemPasswordChar = true;
            // 
            // FrmProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 450);
            Controls.Add(tbxMdp);
            Controls.Add(tbxNumero);
            Controls.Add(tbxEmail);
            Controls.Add(tbxPseudo);
            Controls.Add(tbxPrenom);
            Controls.Add(tbxNom);
            Controls.Add(lblMdp);
            Controls.Add(lblPseudo);
            Controls.Add(lblEmail);
            Controls.Add(lblNumero);
            Controls.Add(lblPrenom);
            Controls.Add(lblNom);
            Controls.Add(llbBack);
            Controls.Add(lblTitre);
            MaximizeBox = false;
            Name = "FrmProfil";
            Text = "Mon profil";
            Load += FrmProfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private LinkLabel llbBack;
        private Label lblNom;
        private Label lblPrenom;
        private Label lblNumero;
        private Label lblEmail;
        private Label lblPseudo;
        private Label lblMdp;
        private TextBox tbxNom;
        private TextBox tbxPrenom;
        private TextBox tbxPseudo;
        private TextBox tbxEmail;
        private TextBox tbxNumero;
        private TextBox tbxMdp;
    }
}