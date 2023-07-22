using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_win_app
{
    internal class DBUtilities
    {
        private string SERVER;
        private string DB;
        private string USERNAME;
        private string PASSWORD;

        private SqlConnection connection;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public DBUtilities()
        {
            this.SERVER = "localhost;";
            this.DB = "dbHrmsProj;";
            this.USERNAME = "sa;";
            this.PASSWORD = ".Demoproj";

            connection = new SqlConnection(constructConnectionString());
        }

        public bool isConnected()
        {
            try
            {
                if ((connection != null) && (connection.State == System.Data.ConnectionState.Closed))
                {
                    connection.Open();
                    connection.Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void openConnection()
        {
            try
            {
                if ((connection != null) && (connection.State == System.Data.ConnectionState.Closed))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show("Failed to connect to database.", "HRMS",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeConnection()
        {
            try
            {
                if ((connection != null) && (connection.State == System.Data.ConnectionState.Closed))
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private string constructConnectionString()
        {
            string returnVal = "Data Source=" + this.SERVER +
                               "Initial Catalog=" + this.DB +
                               "User Id=" + this.USERNAME +
                               "Password=" + this.PASSWORD;
            return returnVal;
        }

        public DataTable queryTable(string query)
        {
            DataTable table = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    openConnection();
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    closeConnection();
                }
                return table;
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return table;
            }
        }

        public int runSqlCommand(string query)
        {
            try 
            {
                openConnection();
                int recordAffected;
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    recordAffected = cmd.ExecuteNonQuery();  // Insert, Update, Delete
                }
                return recordAffected;
                 
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return -1;
            }
        }

        public string dataLookUp(string col, string tbl, string criteria)
        {
            try
            {
                string? returnVal = "";
                string query = "SELECT " + col + " FROM " + tbl +
                                    (criteria.Length > 0 ? " WHERE " + criteria : "");
                DataTable? dt = queryTable(query);

                if (dt == null)
                {
                    return "";
                }

                foreach (DataRow? dr in dt.Rows)
                {
                    returnVal = dr[col].ToString();
                }
                return returnVal;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return "";
            }
        }
    }
}
