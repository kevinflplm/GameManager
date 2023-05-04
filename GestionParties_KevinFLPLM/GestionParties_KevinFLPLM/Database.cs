using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestionParties_KevinFLPLM
{
    internal class Database
    {
        MySqlConnection? mySqlConnection;

        public Database()
        {
            mySqlConnection = new MySqlConnection("server=localhost;port=3306;database=gestion_parties;username=root;pwd=Super");
        }

        public string Login(string query)
        {
            string str;
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlConnection?.Open();
            try
            {
                try
                {
                    str = mySqlCommand.ExecuteScalar().ToString();
                }
                finally
                {
                    mySqlCommand.Dispose();
                    mySqlConnection?.Close();
                    mySqlConnection?.Dispose();
                }
            }
            catch (Exception? ex)
            {
                throw ex;
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
