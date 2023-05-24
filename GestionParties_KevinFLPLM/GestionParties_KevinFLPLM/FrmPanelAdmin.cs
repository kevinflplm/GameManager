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
            tbxInfo1.Visible = true;
            tbxInfo2.Visible = true;
            tbxInfo3.Visible = true;
            tbxInfo4.Visible = true;
            tbxInfo5.Visible = true;
            ////////////
            string query = "SELECT * FROM users";
            dgvListeUsers.DataSource = db.GetInfoAdmin(query);
            dgvListeUsers.Columns["usr_id"].Visible = false;
        }

        private void BtnGstnEvents_Click(object sender, EventArgs e)
        {
            clear();
            tbxInfo1.Text = string.Empty;
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
            tbxInfo5.Visible = true;
            tbxInfo6.Visible = true;
            tbxInfo7.Visible = true;

            string query = "SELECT * FROM events";
            dgvListeUsers.DataSource = db.GetInfoAdmin(query);
            dgvListeUsers.Columns["evt_id"].Visible = false;

        }

        private void btnGstnGames_Click(object sender, EventArgs e)
        {
            clear();
            ////////////
            lblInfo1.Text = "Nom du Jeux :";
            lblInfo2.Text = "Période :";
            lblInfo3.Text = "Description du Jeux :";

            string query = "SELECT * FROM games";
            dgvListeUsers.DataSource = db.GetInfoAdmin(query);
            dgvListeUsers.Columns["gme_id"].Visible = false;
        }

        private void dgvListeUsers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvListeUsers.CurrentRow.Index != -1)
            {
                tbxInfo1.Text = dgvListeUsers.CurrentRow.Cells[1].Value.ToString();
                if (tbxInfo1.Text != string.Empty)
                {
                    string dateStockee = dgvListeUsers.CurrentRow.Cells[1].Value.ToString();
                    DateTime dateTime = DateTime.Parse(dateStockee);
                    dtpEvents.Value = dateTime;
                }
                tbxInfo2.Text = dgvListeUsers.CurrentRow.Cells[2].Value.ToString();
                tbxInfo3.Text = dgvListeUsers.CurrentRow.Cells[3].Value.ToString();
                tbxInfo4.Text = dgvListeUsers.CurrentRow.Cells[4].Value.ToString();
            }
        }

        void clear()
        {
            tbxInfo1.Text = tbxInfo2.Text = tbxInfo3.Text = tbxInfo4.Text = tbxInfo5.Text = tbxInfo6.Text = tbxInfo7.Text = tbxInfo8.Text = tbxInfo9.Text = string.Empty;
            tbxInfo1.Visible = false;
            tbxInfo2.Visible = false;
            tbxInfo3.Visible = false;
            tbxInfo4.Visible = false;
            tbxInfo5.Visible = false;
            tbxInfo6.Visible = false;
            tbxInfo7.Visible = false;
            tbxInfo8.Visible = false;
            tbxInfo9.Visible = false;
            dtpEvents.Visible = false;
            cbxStatus.Visible = false;

            lblInfo1.Text = string.Empty;
            lblInfo2.Text = string.Empty;
            lblInfo3.Text = string.Empty;
            lblInfo4.Text = string.Empty;
            lblInfo5.Text = string.Empty;
            lblInfo6.Text = string.Empty;
            lblInfo7.Text = string.Empty;
            lblInfo8.Text = string.Empty;
            lblInfo9.Text = string.Empty;

        }
    }
}
