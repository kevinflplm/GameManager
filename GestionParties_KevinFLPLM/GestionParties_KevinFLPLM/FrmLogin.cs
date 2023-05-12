using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System.Data;
using System.Data.SqlClient;


/// Auteur  : Kevin.flplm   
/// Date    : 03.05.2023
/// Projet  : Game Manager
/// Détails : Page de connexion

namespace GestionParties_KevinFLPLM
{
    public partial class FrmLogin : Form
    {

        Database db = new Database();

        public FrmLogin()
        {
            InitializeComponent();
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
            string query = string.Concat("SELECT * FROM users WHERE usr_pseudo = '", this.tbxPseudo.Text, "' and usr_password = '", this.tbxMdp.Text, "'");
            List<Utilisateur>? utilisateurs = db.Login(query);

            int nbUsers = utilisateurs.Count();

            if (nbUsers <= 0)
            {
                MessageBox.Show("Le pseudo ou le mot de passe est incorrect.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Program.IsUserLoggedIn = true;
                Program.UserInformation = utilisateurs;  
                FrmAccueil frmAccueil = new FrmAccueil();
                frmAccueil.Show();
                this.Hide();
            }
        }
    }
}