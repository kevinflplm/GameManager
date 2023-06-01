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

/// Auteur  : Kevin.flplm   
/// Date    : 03.05.2023
/// Projet  : Game Manager
/// Détails : Page d'inscription

namespace GestionParties_KevinFLPLM
{
    public partial class FrmInscription : Form
    {
        Database db = new Database();
        public FrmInscription()
        {
            InitializeComponent();
        }

        private void llbConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs
            string nom = tbxNom.Text;
            string prenom = tbxPrenom.Text;
            string pseudo = tbxPseudo.Text;
            string email = tbxEmail.Text;
            string telephone = tbxNumTel.Text;
            string motDePasse = tbxMdp.Text;
            string status = "actif";
            string role = "Joueur";

            // Vérifier si tous les champs sont remplis
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(pseudo) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telephone) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            // Valider l'adresse email (vous pouvez utiliser une expression régulière pour une validation plus poussée)
            if (!db.IsValidEmail(email))
            {
                MessageBox.Show("Adresse email invalide.");
                return;
            }
            else
            {
                string output = db.Inscription(nom, prenom, pseudo, email, telephone, motDePasse, status, role);
                MessageBox.Show(output);
            }
        }
    }
}
