using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// Auteur  : Kevin.flplm   
/// Date    : 29.05.2023
/// Projet  : Game Manager
/// Détails : Page profil

namespace GestionParties_KevinFLPLM
{
    public partial class FrmProfil : Form
    {
        public List<Utilisateur> infoUtilisateur;

        public FrmProfil()
        {
            InitializeComponent();

            if (Program.IsUserLoggedIn)
            {
                // Accéder aux informations de l'utilisateur connecté
                infoUtilisateur = Program.UserInformation;
            }
        }

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            foreach (Utilisateur utilisateur in infoUtilisateur)
            {
                tbxNom.Text = utilisateur.Nom;
                tbxPrenom.Text = utilisateur.Prenom;
                tbxPseudo.Text = utilisateur.Pseudo;
                tbxEmail.Text = utilisateur.Email;
                tbxNumero.Text = utilisateur.Telephone;
                tbxMdp.Text = utilisateur.Mdp;
            }
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAccueil frm = new FrmAccueil();
            frm.Show();
            this.Close();
        }
    }
}
