using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public DataTable GetInfoAdmin(string query)
        {
            DataTable dtOut = new DataTable();
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlConnection?.Open();
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                dtOut.Load(reader);
                mySqlConnection?.Close();
            }
            catch (Exception? ex)
            {
                throw ex;
            }
            return dtOut;
        }

        public List<string> GetEnumValue()
        {
            List<string> listEnum = new List<string>();
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT DISTINCT evt_status FROM events", mySqlConnection);
                mySqlConnection?.Open();
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string valueEnum = (string)reader["evt_status"];
                    listEnum.Add(valueEnum);
                }

                mySqlConnection?.Close();
            }
            catch (Exception? ex)
            {
                throw ex;
            }
            return listEnum;
        }

        public void UpdateInfoEvent(int evtId, DateTime dt, string name, string location, string status, string maxMor, string maxAft, string maxEvn)
        {
            try
            {
                
                mySqlConnection?.Open();
                string updateQuery = "UPDATE events SET evt_date = @newDate, evt_name = @newName, evt_location = @newLoc, evt_status = @newStatus, evt_max_morning_games = @newMaxMor, " +
                    "evt_max_afternoon_games = @newMaxAft, evt_max_evening_games = @newMaxEvn WHERE evt_id = @evtID";
                MySqlCommand command = new MySqlCommand(updateQuery, mySqlConnection);
                command.Parameters.AddWithValue("@newDate", dt);
                command.Parameters.AddWithValue("@newName", name);
                command.Parameters.AddWithValue("@newLoc", location);
                command.Parameters.AddWithValue("@newStatus", status);
                command.Parameters.AddWithValue("@newMaxMor", maxMor);
                command.Parameters.AddWithValue("@newMaxAft", maxAft);
                command.Parameters.AddWithValue("@newMaxEvn", maxEvn);
                command.Parameters.AddWithValue("@evtID", evtId);
                command.ExecuteNonQuery();
                mySqlConnection?.Close();
            }
            catch (Exception? ex)
            {
                throw ex;
            }
        }

        public void AddNewEvent(DateTime dt, string name, string location, string status, string maxMor, string maxAft, string maxEvn) 
        {
            try
            {

                mySqlConnection?.Open();
                string insertQuery = "INSERT INTO events (evt_date, evt_name, evt_location, evt_status, evt_max_morning_games, evt_max_afternoon_games, evt_max_evening_games) " +
                    "VALUES (@evtDate, @evtName, @evtLocation, @evtStatus, @evtMaxMor, @evtMaxAft, @evtMaxEvn)";
                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);
                command.Parameters.AddWithValue("@evtDate", dt);
                command.Parameters.AddWithValue("@evtName", name);
                command.Parameters.AddWithValue("@evtLocation", location);
                command.Parameters.AddWithValue("@evtStatus", status);
                command.Parameters.AddWithValue("@evtMaxMor", maxMor);
                command.Parameters.AddWithValue("@evtMaxAft", maxAft);
                command.Parameters.AddWithValue("@evtMaxEvn", maxEvn);
                command.ExecuteNonQuery();
                mySqlConnection?.Close();
            }
            catch (Exception? ex)
            {
                throw ex;
            }
        }

        public void RemoveEvent(int eventId)
        {
            try
            {
                mySqlConnection?.Open();
                string deleteQuery = "DELETE FROM events WHERE evt_id = @eventId";
                MySqlCommand command = new MySqlCommand(deleteQuery, mySqlConnection);
                command.Parameters.AddWithValue("@eventId", eventId);
                command.ExecuteNonQuery();
                mySqlConnection?.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
