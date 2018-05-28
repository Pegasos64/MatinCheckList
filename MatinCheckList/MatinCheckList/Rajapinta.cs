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

        /// <summary>
        /// Base method for executing simple sql-querys (insert/update/delete)
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private int BasicQuery(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                int rows = 0;
                try
                {
                    rows = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    if (ex.Number == 1451)
                    {
                        return 1451;
                    }
                }
                this.CloseConnection();
                return rows;
            }
            return 0;
        }

        private List<string> GetColumnNames(string table)
        {
            List<string> column_names = new List<string>();
            string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS C WHERE TABLE_NAME = '" + table + "'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    column_names.Add(dataReader[0] + "");
                }

                dataReader.Close();
                this.CloseConnection();
            }
            return column_names;
        }

        public int InsertTask(string name, taskState state, int importance, string assignee, string information, DateTime due)
        {
            List<string> columns = GetColumnNames("tehtavat");
            string query = "INSERT INTO tehtavat ";
            query += "(task_State, task_Name, task_Importance, task_Assignee,";
            query += "task_Information, task_DueDate) VALUES (";
            query += state.ToString() + "," + name + "," + importance + "," + assignee + ",";
            query += information + "," + due + ")";
            MessageBox.Show("SQL query : " + query);
            return BasicQuery(query);
        }
        public int InsertTask(Tehtava t)
        {
            List<string> columns = GetColumnNames("tehtavat");
            string query = "INSERT INTO tehtavat ";
            query += "(task_State, task_Name, task_Importance, task_Assignee,";
            query += "task_Information, task_DueDate) VALUES (";
            query += (int)t.state + "," + t.topic+ "," + (int)t.importance + "," + t.assignee + ",";
            query += t.information + "," + t.due + ")";
            MessageBox.Show("SQL query : " + query);
            return BasicQuery(query);
        }

        #endregion


    }
}
