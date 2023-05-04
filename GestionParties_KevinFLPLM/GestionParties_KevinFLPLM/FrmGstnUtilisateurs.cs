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
    public partial class FrmGstnUtilisateurs : Form
    {
        public FrmGstnUtilisateurs()
        {
            InitializeComponent();
        }

        private void FrmGstnUtilisateurs_Load(object sender, EventArgs e)
        {
            dgvListeUsers.DataSource = GetUsersList();
        }

        private DataTable GetUsersList()
        {
            DataTable dtUsers = new DataTable();

            MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;database=gestion_parties;username=root;pwd=Super");
            mySqlConnection.Open();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM users", mySqlConnection);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            dtUsers.Load(reader);

            return dtUsers; 
        }
    }
}
