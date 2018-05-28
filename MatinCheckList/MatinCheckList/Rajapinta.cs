using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MatinCheckList
{
    class Rajapinta
    {
        private string _server = "88.195.42.239";
        private string _database = "matinchecklist";


        private string connectionString;
        private MySqlConnection connection;


        /// <summary>
        /// Attempts to login to the database, 
        /// returns -1 if succesfull, errornumber otherwise
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int Login(string user, string password)
        {
            connectionString = 
                "SERVER=" + _server + 
                ";DATABASE=" + _database + 
                ";UID=" + user + 
                ";PASSWORD=" + password + 
                ";";
            connection = new MySqlConnection(connectionString + "SSLMode=none");
            return DiagnoseConnection();
        }

        public Rajapinta()
        {
            
        }



        #region utilities
        /// <summary>
        /// Diagnoses the connection to server
        /// </summary>
        /// <returns>errorCode, -1 if succesfull</returns>
        private int DiagnoseConnection()
        {
            try
            {
                connection.Open();
                connection.Close();
                return -1;
            }
            catch (MySqlException ex)
            {
                return ex.Number;
            }
        }

        /// <summary>
        /// Opens the connection for entering commands to the server
        /// </summary>
        /// <returns>boolean true if succesfull, false if not</returns>
        private bool OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open) return true;
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message);
                return false;
            }

        }

        /// <summary>
        /// Closes the connection to the server
        /// </summary>
        /// <returns></returns>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        #endregion


    }
}
