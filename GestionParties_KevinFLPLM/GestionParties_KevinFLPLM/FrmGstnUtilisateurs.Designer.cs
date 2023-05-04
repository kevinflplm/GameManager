namespace GestionParties_KevinFLPLM
{
    partial class FrmGstnUtilisateurs
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
            this.dgvListeUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListeUsers
            // 
            this.dgvListeUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeUsers.Location = new System.Drawing.Point(14, 110);
            this.dgvListeUsers.Name = "dgvListeUsers";
            this.dgvListeUsers.RowTemplate.Height = 25;
            this.dgvListeUsers.Size = new System.Drawing.Size(819, 328);
            this.dgvListeUsers.TabIndex = 0;
            // 
            // FrmGstnUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.dgvListeUsers);
            this.Name = "FrmGstnUtilisateurs";
            this.Text = "FrmGstnUtilisateurs";
            this.Load += new System.EventHandler(this.FrmGstnUtilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvListeUsers;
    }
}