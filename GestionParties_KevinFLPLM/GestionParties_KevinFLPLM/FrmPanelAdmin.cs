using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParties_KevinFLPLM
{
    public partial class FrmPanelAdmin : Form
    {
        Database db = new Database();
        private string selectedImagePath;

        public FrmPanelAdmin()
        {
            InitializeComponent();
        }

        private void FrmGstnUtilisateurs_Load(object sender, EventArgs e)
        {
            List<string> listEnum = db.GetEnumValue();
            foreach (string s in listEnum)
            {
                cbxStatus.Items.Add(s);
            }
            cbxStatus.SelectedIndex = 0;
            cbxPeriod.SelectedIndex = 0;
            cbxRole.SelectedIndex = 0;
            cbxUsrStatus.SelectedIndex = 0;

        }

        private void btnGstbUsers_Click(object sender, EventArgs e)
        {
            clear();
            ////////////
            lblInfo1.Text = "Prénom :";
            lblInfo2.Text = "Nom :";
            lblInfo3.Text = "Numéro de téléphone :";
            lblInfo4.Text = "Email :";
            lblInfo5.Text = "Pseudo :";
            lblInfo6.Text = "Mot de passe :";
            lblInfo7.Text = "Status :";
            lblInfo8.Text = "Rôle :";
            tbxInfo1.Visible = true;
            tbxInfo2.Visible = true;
            tbxInfo3.Visible = true;
            tbxInfo4.Visible = true;
            tbxInfo5.Visible = true;
            tbxInfo6.Visible = true;
            cbxUsrStatus.Visible = true;
            cbxRole.Visible = true;
            ////////////
            string query = "SELECT * FROM users";
            dgvListeUsers.DataSource = db.GetInfoAdmin(query);
            dgvListeUsers.Columns["usr_id"].Visible = false;
        }

        private void BtnGstnEvents_Click(object sender, EventArgs e)
        {
            clear();
            btnAdd.Enabled = true;
            nudInfo1.Maximum = 20;
            nudInfo2.Maximum = 20;
            nudInfo3.Maximum = 20;
            ////////////
            lblInfo1.Text = "Date :";
            lblInfo2.Text = "Nom :";
            lblInfo3.Text = "Lieux :";
            lblInfo4.Text = "Status :";
            lblInfo5.Text = "Parties max matin :";
            lblInfo6.Text = "Parties max après-midi :";
            lblInfo7.Text = "Parties max soir :";
            ////////////
            dtpEvents.Visible = true;
            tbxInfo2.Visible = true;
            tbxInfo3.Visible = true;
            cbxStatus.Visible = true;
            nudInfo1.Visible = true;
            nudInfo2.Visible = true;
            nudInfo3.Visible = true;

            string query = "SELECT * FROM events";
            dgvListeUsers.DataSource = db.GetInfoAdmin(query);
            dgvListeUsers.Columns["evt_id"].Visible = false;

        }

        private void btnGstnGames_Click(object sender, EventArgs e)
        {
            clear();
            btnAdd.Enabled = true;
            nudInfo1.Maximum = 100;
            nudInfo2.Maximum = 100;
            nudInfo3.Maximum = 1000000;
            ////////////
            lblInfo1.Text = "Nom du Jeux :";
            lblInfo2.Text = "Période :";
            lblInfo3.Text = "Description du Jeux :";
            lblInfo4.Text = "Image :";
            lblInfo5.Text = "Joueurs minimum :";
            lblInfo6.Text = "Joueurs maximum :";
            lblInfo7.Text = "Récompenses :";
            tbxInfo1.Visible = true;
            cbxPeriod.Visible = true;
            tbxInfo3.Visible = true;
            btnSelectImg.Visible = true;
            nudInfo1.Visible = true;
            nudInfo2.Visible = true;
            nudInfo3.Visible = true;


            string query = "SELECT * FROM games";
            dgvListeUsers.DataSource = db.GetInfoAdmin(query);
            dgvListeUsers.Columns["gme_id"].Visible = false;
        }

        private void dgvListeUsers_DoubleClick(object sender, EventArgs e)
        {
            dgvListeUsers.CurrentRow.Selected = true;
            if (dgvListeUsers.CurrentRow.Index != -1)
            {
                btnAdd.Enabled = false;
                tbxInfo1.Text = dgvListeUsers.CurrentRow.Cells[1].Value.ToString();
                tbxInfo2.Text = dgvListeUsers.CurrentRow.Cells[2].Value.ToString();
                if (tbxInfo1.Visible == false)
                {
                    tbxInfo1.Text = dgvListeUsers.CurrentRow.Cells[0].Value.ToString();
                    string dateStockee = dgvListeUsers.CurrentRow.Cells[1].Value.ToString();
                    DateTime dateTime = DateTime.Parse(dateStockee);
                    dtpEvents.Value = dateTime;
                    if (dgvListeUsers.CurrentRow.Cells[4].Value.ToString() == "Visible")
                    {
                        cbxStatus.SelectedIndex = 0;
                    }
                    else
                    {
                        cbxStatus.SelectedIndex = 1;
                    }
                    nudInfo1.Value = Convert.ToInt32(dgvListeUsers.CurrentRow.Cells[5].Value.ToString());
                    nudInfo2.Value = Convert.ToInt32(dgvListeUsers.CurrentRow.Cells[6].Value.ToString());
                    nudInfo3.Value = Convert.ToInt32(dgvListeUsers.CurrentRow.Cells[7].Value.ToString());
                }
                if (tbxInfo2.Visible == false)
                {
                    tbxInfo2.Text = dgvListeUsers.CurrentRow.Cells[0].Value.ToString();
                    string period = dgvListeUsers.CurrentRow.Cells[2].Value.ToString();
                    switch (period)
                    {
                        case "Matin":
                            cbxPeriod.SelectedIndex = 0;
                            break;
                        case "Après-midi":
                            cbxPeriod.SelectedIndex = 1;
                            break;
                        case "Soir":
                            cbxPeriod.SelectedIndex = 2;
                            break;
                    }
                    object imgStocke = dgvListeUsers.CurrentRow.Cells[4].Value;
                    if (imgStocke != null && imgStocke is byte[])
                    {
                        // Convertion de la valeur de la cellule en objet de type Byte
                        byte[] imageBytes = (byte[])imgStocke;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image image = Image.FromStream(ms);


                            pibImage.Visible = true;
                            pibImage.Image = image;
                        }
                    }
                    nudInfo1.Value = Convert.ToInt32(dgvListeUsers.CurrentRow.Cells[5].Value.ToString());
                    nudInfo2.Value = Convert.ToInt32(dgvListeUsers.CurrentRow.Cells[6].Value.ToString());
                    nudInfo3.Value = Convert.ToInt32(dgvListeUsers.CurrentRow.Cells[7].Value.ToString());
                }
                if (cbxRole.Visible == true)
                {
                    string role = dgvListeUsers.CurrentRow.Cells[8].Value.ToString();
                    string usrStatus = dgvListeUsers.CurrentRow.Cells[7].Value.ToString();
                    switch (role)
                    {
                        case "Joueur":
                            cbxRole.SelectedIndex = 0;
                            break;
                        case "MJ à valider":
                            cbxRole.SelectedIndex = 1;
                            break;
                        case "MJ":
                            cbxRole.SelectedIndex = 2;
                            break;
                        case "Admin":
                            cbxRole.SelectedIndex = 3;
                            break;
                    }
                    switch (usrStatus)
                    {
                        case "actif":
                            cbxRole.SelectedIndex = 0;
                            break;
                        case "inactif":
                            cbxRole.SelectedIndex = 1;
                            break;
                    }
                }
                tbxInfo3.Text = dgvListeUsers.CurrentRow.Cells[3].Value.ToString();
                tbxInfo4.Text = dgvListeUsers.CurrentRow.Cells[4].Value.ToString();
                tbxInfo5.Text = dgvListeUsers.CurrentRow.Cells[5].Value.ToString();
                tbxInfo6.Text = dgvListeUsers.CurrentRow.Cells[6].Value.ToString();

                btnSave.Enabled = true;
                btnDel.Enabled = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxInfo1.Visible == false)
            {
                int evtId = Convert.ToInt32(tbxInfo1.Text);
                DateTime dt = dtpEvents.Value;
                string name = tbxInfo2.Text;
                string location = tbxInfo3.Text;
                string status = cbxStatus.Text;
                string maxMor = nudInfo1.Value.ToString();
                string maxAft = nudInfo2.Value.ToString();
                string maxEvn = nudInfo3.Value.ToString();
                db.UpdateInfoEvent(evtId, dt, name, location, status, maxMor, maxAft, maxEvn);
                MessageBox.Show("OK");
            }
            if (tbxInfo2.Visible == false)
            {
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    int gmeId = Convert.ToInt32(tbxInfo2.Text);
                    byte[] imageBytes = File.ReadAllBytes(selectedImagePath);
                    string name = tbxInfo1.Text;
                    string period = cbxPeriod.Text;
                    string desc = tbxInfo3.Text;
                    string minPlayers = nudInfo1.Value.ToString();
                    string maxPlayers = nudInfo2.Value.ToString();
                    string price = nudInfo3.Value.ToString();
                    db.UpdateInfoGame(name, period, desc, imageBytes, minPlayers, maxPlayers, price, 1, 3, gmeId);
                    MessageBox.Show("OK");
                }
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbxInfo1.Visible == false)
            {
                int evtId = Convert.ToInt32(tbxInfo1.Text);
                db.RemoveEvent(evtId);
                MessageBox.Show("OK");
            }
            if (tbxInfo2.Visible == false)
            {
                int gmeId = Convert.ToInt32(tbxInfo2.Text);
                db.RemoveEvent(gmeId);
                MessageBox.Show("OK");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            dgvListeUsers.DataSource = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxInfo1.Visible == false)
            {
                if (dtpEvents.Value != null && tbxInfo2.Text != string.Empty && tbxInfo3.Text != string.Empty && nudInfo1.Value != null && nudInfo2.Value != null && nudInfo3.Value != null)
                {
                    DateTime dt = dtpEvents.Value;
                    string name = tbxInfo2.Text;
                    string location = tbxInfo3.Text;
                    string status = cbxStatus.Text;
                    string maxMor = nudInfo1.Value.ToString();
                    string maxAft = nudInfo2.Value.ToString();
                    string maxEvn = nudInfo3.Value.ToString();
                    db.AddNewEvent(dt, name, location, status, maxMor, maxAft, maxEvn);
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs !", "required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (tbxInfo2.Visible == false)
            {
                if (tbxInfo1.Text != string.Empty && tbxInfo3.Text != string.Empty && lblInfoImg.Text != string.Empty)
                {
                    if (!string.IsNullOrEmpty(selectedImagePath))
                    {
                        byte[] imageBytes = File.ReadAllBytes(selectedImagePath);
                        string name = tbxInfo1.Text;
                        string period = cbxPeriod.Text;
                        string desc = tbxInfo3.Text;
                        string minPlayers = nudInfo1.Value.ToString();
                        string maxPlayers = nudInfo2.Value.ToString();
                        string price = nudInfo3.Value.ToString();
                        db.AddNewGame(name, period, desc, imageBytes, minPlayers, maxPlayers, price, 1, 1);
                        MessageBox.Show("OK");
                    }
                }
            }
        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "Fichiers image (*.jpg, *.jpeg, *.png) |*.jpg;*.jpeg;*.png;*.gif|Tous les fichiers|*.*";

            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofdImage.FileName;

                lblInfoImg.Text = selectedImagePath;
                lblInfoImg.Visible = false;
                pibImage.Visible = true;
                pibImage.Image = Image.FromFile(selectedImagePath);

            }
        }

        private void dgvListeUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvListeUsers.CurrentRow.Selected = true;
        }

        void clear()
        {
            btnSave.Enabled = false;
            btnDel.Enabled = false;
            btnAdd.Enabled = false;
            tbxInfo1.Text = tbxInfo2.Text = tbxInfo3.Text = tbxInfo4.Text = tbxInfo5.Text = tbxInfo6.Text = string.Empty;
            tbxInfo1.Visible = false;
            tbxInfo2.Visible = false;
            tbxInfo3.Visible = false;
            tbxInfo4.Visible = false;
            tbxInfo5.Visible = false;
            tbxInfo6.Visible = false;
            dtpEvents.Visible = false;
            cbxStatus.Visible = false;
            cbxPeriod.Visible = false;
            nudInfo1.Visible = false;
            nudInfo2.Visible = false;
            nudInfo3.Visible = false;
            btnSelectImg.Visible = false;

            lblInfo1.Text = string.Empty;
            lblInfo2.Text = string.Empty;
            lblInfo3.Text = string.Empty;
            lblInfo4.Text = string.Empty;
            lblInfo5.Text = string.Empty;
            lblInfo6.Text = string.Empty;
            lblInfo7.Text = string.Empty;
            lblInfo8.Text = string.Empty;
            lblInfo9.Text = string.Empty;
            lblInfoImg.Text = string.Empty;
            cbxStatus.SelectedIndex = 0;
            cbxPeriod.SelectedIndex = 0;
            nudInfo1.Maximum = 20;
            nudInfo2.Maximum = 20;
            nudInfo3.Maximum = 20;
            pibImage.Visible = false;
            cbxUsrStatus.Visible = false;
            cbxRole.Visible = false;

        }
    }
}