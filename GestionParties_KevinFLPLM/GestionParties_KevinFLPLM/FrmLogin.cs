namespace GestionParties_KevinFLPLM
{
    public partial class FrmLogin : Form
    {
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
    }
}