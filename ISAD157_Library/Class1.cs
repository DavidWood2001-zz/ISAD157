using System;
using System.Data;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient;

namespace ISAD157_Library
{
    public class ISAD157_functions
    {
        internal const string USER_NAME = "ISAD157_DWood";
        internal const string SERVER = "proj-mysql.uopnet.plymouth.ac.uk";
        internal const string DATABASE_NAME = "isad157_dwood";
        internal const string PASSWORD = "ISAD157_22224652";
        internal const string SslMode = "none";
        public static MySqlDataAdapter sqlDA;
        internal const string connectionString = "SERVER=" + SERVER + ";" +
                    "DATABASE=" + DATABASE_NAME + ";" + "UID=" +
                    USER_NAME + ";" + "PASSWORD=" +
                    PASSWORD + ";" + "SslMode=" +
                    SslMode + ";";

        public static void retrieveUsers()
        {
            using (MySqlConnection connection =
            new MySqlConnection(connectionString))
            {

                string query = "SELECT * FROM isad157_dwood.users";

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                sqlDA = new MySqlDataAdapter(cmd);
            }
        }

        public static void retrieveWorkplaces(int inUserID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM isad157_dwood.workplaces WHERE user_id = " + Convert.ToString(inUserID);

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                sqlDA = new MySqlDataAdapter(cmd);
            }
        }

        public static void retrieveSchools(int inUserID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM isad157_dwood.schools WHERE user_id = " + Convert.ToString(inUserID);

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                sqlDA = new MySqlDataAdapter(cmd);
            }
        }
    }
}