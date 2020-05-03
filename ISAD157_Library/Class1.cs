using System;
using System.Data;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient;

namespace ISAD157_Library
{
    public class SQL_Connection_Functions
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
        public static void searchUsers(int inUserID)
        {
            using (MySqlConnection connection =
            new MySqlConnection(connectionString))
            {

                string query = "SELECT * FROM isad157_dwood.users WHERE user_id = " + Convert.ToString(inUserID);

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                sqlDA = new MySqlDataAdapter(cmd);
            }
        }
        public static void searchUserFName(string inUserFName)
        {
            using (MySqlConnection connection =
            new MySqlConnection(connectionString))
            {

                string query = "SELECT * FROM isad157_dwood.users WHERE f_name = '" + inUserFName + "'";

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                sqlDA = new MySqlDataAdapter(cmd);
            }
        }

        public static void searchUserLName(string inUserLName)
        {
            using (MySqlConnection connection =
            new MySqlConnection(connectionString))
            {

                string query = "SELECT * FROM isad157_dwood.users WHERE l_name = '" + inUserLName + "'";

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
        public static void retrieveFriends(int inUserID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM isad157_dwood.friends WHERE user_id = " + Convert.ToString(inUserID);

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                sqlDA = new MySqlDataAdapter(cmd);
            }
        }
        public static void retrieveSentMsgs(int inUserID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM isad157_dwood.messages WHERE sender_id = " + Convert.ToString(inUserID);

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                sqlDA = new MySqlDataAdapter(cmd);
            }
        }
        public static void retrieveRecMsgs(int inUserID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM isad157_dwood.messages WHERE receiver_id = " + Convert.ToString(inUserID);

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                sqlDA = new MySqlDataAdapter(cmd);
            }
        }
        public static bool userExists(int inUserID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM isad157_dwood.users WHERE user_id = " + Convert.ToString(inUserID);

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                sqlDA = new MySqlDataAdapter(cmd);
            }
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            if (dt != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string returnFName(int inUserID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT f_name FROM isad157_dwood.users WHERE user_id = " + Convert.ToString(inUserID);

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                sqlDA = new MySqlDataAdapter(cmd);
            }
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);

            return Convert.ToString(dt.Rows[0]["f_name"]);
        }
        public static string returnLName(int inUserID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT l_name FROM isad157_dwood.users WHERE user_id = " + Convert.ToString(inUserID);

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                sqlDA = new MySqlDataAdapter(cmd);
            }
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            
            return Convert.ToString(dt.Rows[0]["l_name"]);
        }
    }
}