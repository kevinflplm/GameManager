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
            this.Hide();
        }
    }
}
