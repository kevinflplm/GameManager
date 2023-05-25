namespace GestionParties_KevinFLPLM
{
    partial class FrmPanelAdmin
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
            dgvListeUsers = new DataGridView();
            btnGstbUsers = new Button();
            btnGstnGames = new Button();
            BtnGstnEvents = new Button();
            lblInfo1 = new Label();
            lblInfo2 = new Label();
            lblInfo3 = new Label();
            tbxInfo1 = new TextBox();
            tbxInfo2 = new TextBox();
            tbxInfo3 = new TextBox();
            lblInfo4 = new Label();
            tbxInfo4 = new TextBox();
            tbxInfo5 = new TextBox();
            lblInfo5 = new Label();
            lblInfo6 = new Label();
            lblInfo7 = new Label();
            lblInfo8 = new Label();
            lblInfo9 = new Label();
            btnSave = new Button();
            btnDel = new Button();
            btnCancel = new Button();
            btnAdd = new Button();
            dtpEvents = new DateTimePicker();
            cbxStatus = new ComboBox();
            nudInfo1 = new NumericUpDown();
            nudInfo2 = new NumericUpDown();
            nudInfo3 = new NumericUpDown();
            cbxPeriod = new ComboBox();
            ofdImage = new OpenFileDialog();
            btnSelectImg = new Button();
            lblInfoImg = new Label();
            tbxInfo6 = new TextBox();
            pibImage = new PictureBox();
            cbxRole = new ComboBox();
            cbxUsrStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListeUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInfo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInfo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInfo3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pibImage).BeginInit();
            SuspendLayout();
            // 
            // dgvListeUsers
            // 
            dgvListeUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListeUsers.Location = new Point(370, 60);
            dgvListeUsers.Name = "dgvListeUsers";
            dgvListeUsers.ReadOnly = true;
            dgvListeUsers.RowTemplate.Height = 25;
            dgvListeUsers.Size = new Size(562, 283);
            dgvListeUsers.TabIndex = 0;
            dgvListeUsers.CellMouseClick += dgvListeUsers_CellMouseClick;
            dgvListeUsers.DoubleClick += dgvListeUsers_DoubleClick;
            // 
            // btnGstbUsers
            // 
            btnGstbUsers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGstbUsers.Location = new Point(370, 12);
            btnGstbUsers.Name = "btnGstbUsers";
            btnGstbUsers.Size = new Size(130, 40);
            btnGstbUsers.TabIndex = 1;
            btnGstbUsers.Text = "Gestion Utilisateur";
            btnGstbUsers.UseVisualStyleBackColor = true;
            btnGstbUsers.Click += btnGstbUsers_Click;
            // 
            // btnGstnGames
            // 
            btnGstnGames.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGstnGames.Location = new Point(597, 12);
            btnGstnGames.Name = "btnGstnGames";
            btnGstnGames.Size = new Size(130, 40);
            btnGstnGames.TabIndex = 2;
            btnGstnGames.Text = "Gestion Jeux";
            btnGstnGames.UseVisualStyleBackColor = true;
            btnGstnGames.Click += btnGstnGames_Click;
            // 
            // BtnGstnEvents
            // 
            BtnGstnEvents.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGstnEvents.Location = new Point(802, 12);
            BtnGstnEvents.Name = "BtnGstnEvents";
            BtnGstnEvents.Size = new Size(130, 40);
            BtnGstnEvents.TabIndex = 3;
            BtnGstnEvents.Text = "Gestion Events";
            BtnGstnEvents.UseVisualStyleBackColor = true;
            BtnGstnEvents.Click += BtnGstnEvents_Click;
            // 
            // lblInfo1
            // 
            lblInfo1.AutoSize = true;
            lblInfo1.Location = new Point(23, 63);
            lblInfo1.Name = "lblInfo1";
            lblInfo1.Size = new Size(0, 15);
            lblInfo1.TabIndex = 4;
            // 
            // lblInfo2
            // 
            lblInfo2.AutoSize = true;
            lblInfo2.Location = new Point(23, 91);
            lblInfo2.Name = "lblInfo2";
            lblInfo2.Size = new Size(0, 15);
            lblInfo2.TabIndex = 6;
            // 
            // lblInfo3
            // 
            lblInfo3.AutoSize = true;
            lblInfo3.Location = new Point(23, 119);
            lblInfo3.Name = "lblInfo3";
            lblInfo3.Size = new Size(0, 15);
            lblInfo3.TabIndex = 7;
            // 
            // tbxInfo1
            // 
            tbxInfo1.Location = new Point(166, 60);
            tbxInfo1.Name = "tbxInfo1";
            tbxInfo1.Size = new Size(137, 23);
            tbxInfo1.TabIndex = 8;
            tbxInfo1.Visible = false;
            // 
            // tbxInfo2
            // 
            tbxInfo2.Location = new Point(166, 88);
            tbxInfo2.Name = "tbxInfo2";
            tbxInfo2.Size = new Size(137, 23);
            tbxInfo2.TabIndex = 9;
            tbxInfo2.Visible = false;
            // 
            // tbxInfo3
            // 
            tbxInfo3.Location = new Point(166, 116);
            tbxInfo3.Multiline = true;
            tbxInfo3.Name = "tbxInfo3";
            tbxInfo3.Size = new Size(137, 50);
            tbxInfo3.TabIndex = 10;
            tbxInfo3.Visible = false;
            // 
            // lblInfo4
            // 
            lblInfo4.AutoSize = true;
            lblInfo4.Location = new Point(23, 172);
            lblInfo4.Name = "lblInfo4";
            lblInfo4.Size = new Size(0, 15);
            lblInfo4.TabIndex = 11;
            // 
            // tbxInfo4
            // 
            tbxInfo4.Location = new Point(166, 169);
            tbxInfo4.Name = "tbxInfo4";
            tbxInfo4.Size = new Size(137, 23);
            tbxInfo4.TabIndex = 12;
            tbxInfo4.Visible = false;
            // 
            // tbxInfo5
            // 
            tbxInfo5.Location = new Point(166, 224);
            tbxInfo5.Name = "tbxInfo5";
            tbxInfo5.Size = new Size(137, 23);
            tbxInfo5.TabIndex = 14;
            tbxInfo5.Visible = false;
            // 
            // lblInfo5
            // 
            lblInfo5.AutoSize = true;
            lblInfo5.Location = new Point(23, 227);
            lblInfo5.Name = "lblInfo5";
            lblInfo5.Size = new Size(0, 15);
            lblInfo5.TabIndex = 13;
            // 
            // lblInfo6
            // 
            lblInfo6.AutoSize = true;
            lblInfo6.Location = new Point(23, 255);
            lblInfo6.Name = "lblInfo6";
            lblInfo6.Size = new Size(0, 15);
            lblInfo6.TabIndex = 15;
            // 
            // lblInfo7
            // 
            lblInfo7.AutoSize = true;
            lblInfo7.Location = new Point(23, 283);
            lblInfo7.Name = "lblInfo7";
            lblInfo7.Size = new Size(0, 15);
            lblInfo7.TabIndex = 17;
            // 
            // lblInfo8
            // 
            lblInfo8.AutoSize = true;
            lblInfo8.Location = new Point(23, 310);
            lblInfo8.Name = "lblInfo8";
            lblInfo8.Size = new Size(0, 15);
            lblInfo8.TabIndex = 19;
            // 
            // lblInfo9
            // 
            lblInfo9.AutoSize = true;
            lblInfo9.Location = new Point(23, 336);
            lblInfo9.Name = "lblInfo9";
            lblInfo9.Size = new Size(0, 15);
            lblInfo9.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.Enabled = false;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(792, 359);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 40);
            btnSave.TabIndex = 23;
            btnSave.Text = "Sauvegarder";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Red;
            btnDel.Enabled = false;
            btnDel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(651, 359);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(115, 40);
            btnDel.TabIndex = 24;
            btnDel.Text = "Supprimer";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkOrange;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(370, 359);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 40);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(512, 359);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 40);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpEvents
            // 
            dtpEvents.Location = new Point(166, 59);
            dtpEvents.Name = "dtpEvents";
            dtpEvents.Size = new Size(137, 23);
            dtpEvents.TabIndex = 27;
            dtpEvents.Visible = false;
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(166, 169);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(137, 23);
            cbxStatus.TabIndex = 28;
            cbxStatus.Visible = false;
            // 
            // nudInfo1
            // 
            nudInfo1.Location = new Point(166, 224);
            nudInfo1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudInfo1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInfo1.Name = "nudInfo1";
            nudInfo1.Size = new Size(120, 23);
            nudInfo1.TabIndex = 29;
            nudInfo1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudInfo1.Visible = false;
            // 
            // nudInfo2
            // 
            nudInfo2.Location = new Point(166, 252);
            nudInfo2.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudInfo2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInfo2.Name = "nudInfo2";
            nudInfo2.Size = new Size(120, 23);
            nudInfo2.TabIndex = 30;
            nudInfo2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudInfo2.Visible = false;
            // 
            // nudInfo3
            // 
            nudInfo3.Location = new Point(166, 281);
            nudInfo3.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudInfo3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInfo3.Name = "nudInfo3";
            nudInfo3.Size = new Size(120, 23);
            nudInfo3.TabIndex = 31;
            nudInfo3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudInfo3.Visible = false;
            // 
            // cbxPeriod
            // 
            cbxPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPeriod.FormattingEnabled = true;
            cbxPeriod.Items.AddRange(new object[] { "Matin", "Après-midi", "Soir" });
            cbxPeriod.Location = new Point(166, 89);
            cbxPeriod.Name = "cbxPeriod";
            cbxPeriod.Size = new Size(137, 23);
            cbxPeriod.TabIndex = 32;
            cbxPeriod.Visible = false;
            // 
            // ofdImage
            // 
            ofdImage.FileName = "openFileDialog1";
            // 
            // btnSelectImg
            // 
            btnSelectImg.Location = new Point(166, 168);
            btnSelectImg.Name = "btnSelectImg";
            btnSelectImg.Size = new Size(75, 23);
            btnSelectImg.TabIndex = 33;
            btnSelectImg.Text = "Choisir";
            btnSelectImg.UseVisualStyleBackColor = true;
            btnSelectImg.Visible = false;
            btnSelectImg.Click += btnSelectImg_Click;
            // 
            // lblInfoImg
            // 
            lblInfoImg.AutoSize = true;
            lblInfoImg.Location = new Point(247, 172);
            lblInfoImg.Name = "lblInfoImg";
            lblInfoImg.Size = new Size(0, 15);
            lblInfoImg.TabIndex = 35;
            // 
            // tbxInfo6
            // 
            tbxInfo6.Location = new Point(166, 252);
            tbxInfo6.Name = "tbxInfo6";
            tbxInfo6.Size = new Size(137, 23);
            tbxInfo6.TabIndex = 36;
            tbxInfo6.UseSystemPasswordChar = true;
            tbxInfo6.Visible = false;
            // 
            // pibImage
            // 
            pibImage.Location = new Point(305, 168);
            pibImage.Name = "pibImage";
            pibImage.Size = new Size(59, 57);
            pibImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pibImage.TabIndex = 37;
            pibImage.TabStop = false;
            pibImage.Visible = false;
            // 
            // cbxRole
            // 
            cbxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRole.FormattingEnabled = true;
            cbxRole.Items.AddRange(new object[] { "Joueur", "MJ à valider", "MJ", "Admin" });
            cbxRole.Location = new Point(166, 307);
            cbxRole.Name = "cbxRole";
            cbxRole.Size = new Size(137, 23);
            cbxRole.TabIndex = 38;
            cbxRole.Visible = false;
            // 
            // cbxUsrStatus
            // 
            cbxUsrStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUsrStatus.FormattingEnabled = true;
            cbxUsrStatus.Items.AddRange(new object[] { "actif", "inactif" });
            cbxUsrStatus.Location = new Point(166, 281);
            cbxUsrStatus.Name = "cbxUsrStatus";
            cbxUsrStatus.Size = new Size(137, 23);
            cbxUsrStatus.TabIndex = 39;
            cbxUsrStatus.Visible = false;
            // 
            // FrmPanelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 411);
            Controls.Add(cbxUsrStatus);
            Controls.Add(cbxRole);
            Controls.Add(pibImage);
            Controls.Add(tbxInfo6);
            Controls.Add(lblInfoImg);
            Controls.Add(btnSelectImg);
            Controls.Add(cbxPeriod);
            Controls.Add(nudInfo3);
            Controls.Add(nudInfo2);
            Controls.Add(nudInfo1);
            Controls.Add(cbxStatus);
            Controls.Add(dtpEvents);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(btnDel);
            Controls.Add(btnSave);
            Controls.Add(lblInfo9);
            Controls.Add(lblInfo8);
            Controls.Add(lblInfo7);
            Controls.Add(lblInfo6);
            Controls.Add(tbxInfo5);
            Controls.Add(lblInfo5);
            Controls.Add(tbxInfo4);
            Controls.Add(lblInfo4);
            Controls.Add(tbxInfo3);
            Controls.Add(tbxInfo2);
            Controls.Add(tbxInfo1);
            Controls.Add(lblInfo3);
            Controls.Add(lblInfo2);
            Controls.Add(lblInfo1);
            Controls.Add(BtnGstnEvents);
            Controls.Add(btnGstnGames);
            Controls.Add(btnGstbUsers);
            Controls.Add(dgvListeUsers);
            MaximizeBox = false;
            Name = "FrmPanelAdmin";
            Text = "FrmGstnUtilisateurs";
            Load += FrmGstnUtilisateurs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListeUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInfo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInfo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInfo3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pibImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListeUsers;
        private Button btnGstbUsers;
        private Button btnGstnGames;
        private Button BtnGstnEvents;
        private Label lblInfo1;
        private Label lblInfo2;
        private Label lblInfo3;
        private TextBox tbxInfo1;
        private TextBox tbxInfo2;
        private TextBox tbxInfo3;
        private Label lblInfo4;
        private TextBox tbxInfo4;
        private TextBox tbxInfo5;
        private Label lblInfo5;
        private Label lblInfo6;
        private Label lblInfo7;
        private Label lblInfo8;
        private Label lblInfo9;
        private Button btnSave;
        private Button btnDel;
        private Button btnCancel;
        private Button btnAdd;
        private DateTimePicker dtpEvents;
        private ComboBox cbxStatus;
        private NumericUpDown nudInfo1;
        private NumericUpDown nudInfo2;
        private NumericUpDown nudInfo3;
        private ComboBox cbxPeriod;
        private OpenFileDialog ofdImage;
        private Button btnSelectImg;
        private Label lblInfoImg;
        private TextBox tbxInfo6;
        private PictureBox pibImage;
        private ComboBox cbxRole;
        private ComboBox cbxUsrStatus;
    }
}