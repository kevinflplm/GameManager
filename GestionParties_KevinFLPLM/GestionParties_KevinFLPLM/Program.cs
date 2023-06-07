using GestionParties_KevinFLPLM;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

/// Auteur  : Kevin.flplm   
/// Date    : 03.05.2023
/// Projet  : Game Manager
/// Détails : Program.cs

namespace GestionParties_KevinFLPLM
{
    static class Program
    {

        public static bool IsUserLoggedIn { get; set; } = false;
        public static List<Utilisateur>? UserInformation { get; set; }

        public static List<string>? users { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            users = new List<string>();
            users.Add("aa");

            // Afficher le formulaire de connexion (login)
            FrmLogin loginForm = new FrmLogin();
            Application.Run(loginForm);

            // Vérifier l'état de connexion après la fermeture du formulaire de connexion
            if (IsUserLoggedIn)
            {
                FrmAccueil frmAccueil = new FrmAccueil();
                Application.Run(frmAccueil);
            }
        }
    }
}