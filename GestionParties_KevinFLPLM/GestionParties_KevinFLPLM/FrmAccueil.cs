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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;


/// Auteur  : Kevin.flplm   
/// Date    : 03.05.2023
/// Projet  : Game Manager
/// Détails : Page d'accueil

namespace GestionParties_KevinFLPLM
{
    public partial class FrmAccueil : Form
    {
        List<Utilisateur> listUtilisateurs = new List<Utilisateur>();
        Database db = new Database();

        public FrmAccueil()
        {
            InitializeComponent();

            if (Program.IsUserLoggedIn)
            {
                // Accéder aux informations de l'utilisateur connecté
                listUtilisateurs = Program.UserInformation;
            }
        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {

            foreach (Utilisateur utilisateur in listUtilisateurs)
            {
                   if (utilisateur.Role == "admin")
                {

                    btnAdmin.Visible = true;

                }
            }

            MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;database=gestion_parties;username=root;pwd=Super");
            mySqlConnection.Open();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT gme_image FROM games", mySqlConnection);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            int posx = 77;
            int posy = 124;

            while (reader.Read())
            {
                byte[] imageBytes = (byte[])reader["gme_image"];
                // Conversion des données en un objet Image
                MemoryStream ms = new MemoryStream(imageBytes);
                Image image = Image.FromStream(ms);

                // Affichage de l'image dans un contrôle PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = image;
                pictureBox.Size = new Size(130, 150);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(posx, posy);
                this.Controls.Add(pictureBox);

                posx = posx + 150;
            }

            // Fermeture de la connexion à la base de données
            reader.Close();
            mySqlConnection.Close();


        }
    }
}
            