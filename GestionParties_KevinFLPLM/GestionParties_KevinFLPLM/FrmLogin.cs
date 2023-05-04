using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace GestionParties_KevinFLPLM
{
    public partial class FrmLogin : Form
    {

        Database db = new Database();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void llbConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmInscription frm = new FrmInscription();
            frm.Show();
            this.Hide();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrWhiteSpace(this.tbxPseudo.Text))
           {
                MessageBox.Show("Merci d'entrer un Pseudo.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tbxPseudo.Focus();
                return;
           }
           if (string.IsNullOrWhiteSpace(this.tbxMdp.Text))
           {
                MessageBox.Show("Merci d'entrer un mot de passe.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tbxMdp.Focus();
                return;
           }
           string query  = string.Concat("SELECT COUNT(*) FROM users WHERE usr_pseudo = '", this.tbxPseudo.Text,"' and usr_password = '",this.tbxMdp.Text,"'");
            if (Convert.ToInt16(db.Login(query)) <= 0)
            {
                MessageBox.Show("Le pseudo ou le mot de passe est incorrect.");
                return;
            }
            else
            {
                FrmAccueil frmAccueil = new FrmAccueil();
                frmAccueil.Show();
                this.Hide();
            }

        }
    }
}