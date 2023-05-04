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
    }
}
