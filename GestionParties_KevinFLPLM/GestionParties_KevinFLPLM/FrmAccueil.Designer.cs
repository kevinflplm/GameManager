namespace GestionParties_KevinFLPLM
{
    partial class FrmAccueil
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
            openFileDialog1 = new OpenFileDialog();
            llbCompte = new LinkLabel();
            llbAdmin = new LinkLabel();
            llbDeco = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(402, 86);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 0;
            label1.Text = "Évènements à venir";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // llbCompte
            // 
            llbCompte.AutoSize = true;
            llbCompte.Location = new Point(12, 9);
            llbCompte.Name = "llbCompte";
            llbCompte.Size = new Size(76, 15);
            llbCompte.TabIndex = 2;
            llbCompte.TabStop = true;
            llbCompte.Text = "Mon compte";
            llbCompte.LinkClicked += llbCompte_LinkClicked;
            // 
            // llbAdmin
            // 
            llbAdmin.AutoSize = true;
            llbAdmin.Location = new Point(94, 9);
            llbAdmin.Name = "llbAdmin";
            llbAdmin.Size = new Size(73, 15);
            llbAdmin.TabIndex = 3;
            llbAdmin.TabStop = true;
            llbAdmin.Text = "Panel admin";
            llbAdmin.Visible = false;
            llbAdmin.LinkClicked += linkLabel1_LinkClicked;
            // 
            // llbDeco
            // 
            llbDeco.AutoSize = true;
            llbDeco.Location = new Point(964, 9);
            llbDeco.Name = "llbDeco";
            llbDeco.Size = new Size(88, 15);
            llbDeco.TabIndex = 4;
            llbDeco.TabStop = true;
            llbDeco.Text = "Se déconnecter";
            llbDeco.LinkClicked += llbDeco_LinkClicked;
            // 
            // FrmAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 632);
            Controls.Add(llbDeco);
            Controls.Add(llbAdmin);
            Controls.Add(llbCompte);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmAccueil";
            Text = "FrmAccueil";
            Load += FrmAccueil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pibTest;
        private OpenFileDialog openFileDialog1;
        private LinkLabel llbCompte;
        private LinkLabel llbAdmin;
        private LinkLabel llbDeco;
    }
}