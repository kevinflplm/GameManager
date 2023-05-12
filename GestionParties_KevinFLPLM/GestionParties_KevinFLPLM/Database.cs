using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionParties_KevinFLPLM
{
    internal class Database
    {
        MySqlConnection? mySqlConnection;

        public Database()
        {
            mySqlConnection = new MySqlConnection("server=localhost;port=3306;database=gestion_parties;username=root;pwd=Super");
        }

        public List<Utilisateur>? Login(string query)
        {
            string str;
            List<Utilisateur>? userTab = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlConnection?.Open();
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                userTab = new List<Utilisateur>();

                while (reader.Read())
                {
                    string nom = reader.GetString(1);
                    string prenom = reader.GetString(2);
                    string telephone = reader.GetString(3);
                    string email = reader.GetString(4);
                    string pseudo = reader.GetString(5);
                    string status = reader.GetString(7);
                    string role = reader.GetString(8);
          
                    Utilisateur utilisateur = new Utilisateur(prenom, nom, telephone, email, pseudo, status, role);     
                    userTab?.Add(utilisateur);
                }
                mySqlConnection?.Close();
            }
            catch (Exception? ex)
            {
                throw ex;
            }
            return userTab;
                    }

        public string Inscription(string nom, string prenom, string pseudo, string email, string telephone, string motDePasse)
        {

            string str;
            try 
            { 
                // Créer la commande SQL avec des paramètres pour éviter les attaques par injection SQL
                string query = "INSERT INTO users (usr_first_name, usr_last_name, usr_phone, usr_email, usr_pseudo, usr_password) " +
                        "VALUES (@Prenom, @Nom, @Telephone, @Email, @Pseudo, @MotDePasse)";
                mySqlConnection?.Open();

                using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                {
                        // Ajouter les valeurs des paramètres
                        command.Parameters.AddWithValue("@Prenom", prenom);
                        command.Parameters.AddWithValue("@Nom", nom);
                        command.Parameters.AddWithValue("@Pseudo", pseudo);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Telephone", telephone);
                        command.Parameters.AddWithValue("@MotDePasse", motDePasse);

                        // Exécuter la commande SQL
                        command.ExecuteNonQuery();
                }

                // Afficher un message de succès
                str = "Inscription réussie !";
            }
            catch (Exception? ex)
            {
                throw ex;
                str = "Inscription échoué !";
            }
            return str;
        }

        //public string GetInfoParties(string query)
        //{
        //    MySqlCommand mysqlCmd = new MySqlCommand(query, mySqlConnection);
        //    mySqlConnection?.Open();
        //    try
        //    {

        //        MySqlDataReader reader = mysqlCmd.ExecuteReader();
        //        byte[] imageBytes = (byte[])reader["image"];

        //        MemoryStream ms = new MemoryStream(imageBytes);
        //        Image image = Image.FromStream(ms);

        //        reader.Close();
        //        mySqlConnection?.Close();

        //        return image;
        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //}
    }
}
