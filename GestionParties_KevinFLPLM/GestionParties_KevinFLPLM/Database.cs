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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

/// Auteur  : Kevin.flplm   
/// Date    : 03.05.2023
/// Projet  : Game Manager
/// Détails : Fonctions

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
                    string mdp = reader.GetString(6);
                    string status = reader.GetString(7);
                    string role = reader.GetString(8);
          
                    Utilisateur utilisateur = new Utilisateur(prenom, nom, telephone, email, pseudo, status, role, mdp);     
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

        public string Inscription(string nom, string prenom, string pseudo, string email, string telephone, string motDePasse, string status, string role)
        {

            string str;
            try 
            { 
                // Créer la commande SQL avec des paramètres pour éviter les attaques par injection SQL
                string query = "INSERT INTO users (usr_first_name, usr_last_name, usr_phone, usr_email, usr_pseudo, usr_password, usr_status, usr_role) " +
                        "VALUES (@Prenom, @Nom, @Telephone, @Email, @Pseudo, @MotDePasse, @Status, @Role)";
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
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@Role", role);

                    // Exécuter la commande SQL
                    command.ExecuteNonQuery();
                }

                mySqlConnection?.Close();
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

        public void UpdateInfoGame(string name, string period, string desc, byte[] img, string minPly, string maxPly, string price, int mjId, int evtId, int gmeId)
        {
            try
            {

                mySqlConnection?.Open();
                string updateQuery = "UPDATE games SET gme_name = @newName, gme_period = @newPeriod, gme_description = @newDesc, gme_image = @newImg, gme_min_players = @newMinPly, gme_max_players = @newMaxPly, gme_price = @newPrice" +
                    " WHERE gme_id = @gmeID";
                MySqlCommand command = new MySqlCommand(updateQuery, mySqlConnection);
                command.Parameters.AddWithValue("@newName", name);
                command.Parameters.AddWithValue("@newPeriod", period);
                command.Parameters.AddWithValue("@newDesc", desc);
                command.Parameters.AddWithValue("@newImg", img);
                command.Parameters.AddWithValue("@newMinPly", minPly);
                command.Parameters.AddWithValue("@newMaxPly", maxPly);
                command.Parameters.AddWithValue("@newPrice", price);
                command.Parameters.AddWithValue("@gmeID", gmeId);
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

        public void AddNewGame(string name, string period, string desc, byte[] img, string minPly, string maxPly, string price, int mjId, int evtId)
        {
            try
            {

                mySqlConnection?.Open();
                string insertQuery = "INSERT INTO games (gme_name, gme_period, gme_description, gme_image, gme_min_players, gme_max_players, gme_price, gme_mj_usr_id, gme_evt_id) " +
                    "VALUES (@gmeName, @gmePeriod, @gmeDesc, @gmeImage, @gmeMinPly, @gmeMaxPly, @gmePrice, @gmeMjId, @gmeEvtId)";
                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);
                command.Parameters.AddWithValue("@gmeName", name);
                command.Parameters.AddWithValue("@gmePeriod", period);
                command.Parameters.AddWithValue("@gmeDesc", desc);
                command.Parameters.AddWithValue("@gmeImage", img);
                command.Parameters.AddWithValue("@gmeMinPly", minPly);
                command.Parameters.AddWithValue("@gmeMaxPly", maxPly);
                command.Parameters.AddWithValue("@gmePrice", price);
                command.Parameters.AddWithValue("@gmeMjId", mjId);
                command.Parameters.AddWithValue("@gmeEvtId", evtId);
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

        public void RemoveGame(int gameId)
        {
            try
            {
                mySqlConnection?.Open();
                string deleteQuery = "DELETE FROM games WHERE gme_id = @gameId";
                MySqlCommand command = new MySqlCommand(deleteQuery, mySqlConnection);
                command.Parameters.AddWithValue("@gameId", gameId);
                command.ExecuteNonQuery();
                mySqlConnection?.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoveUser(int userId)
        {
            try
            {
                mySqlConnection?.Open();
                string deleteQuery = "DELETE FROM users WHERE usr_id = @userId";
                MySqlCommand command = new MySqlCommand(deleteQuery, mySqlConnection);
                command.Parameters.AddWithValue("@userId", userId);
                command.ExecuteNonQuery();
                mySqlConnection?.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Vérifie si l'email est valide ou pas
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
