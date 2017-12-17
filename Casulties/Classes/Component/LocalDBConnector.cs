using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casulties.Classes.Component
{
    /// <summary>
    /// LocalDBConnector class
    /// </summary>
    internal sealed class LocalDBConnector
    {
        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;"
            + @"AttachDbFilename=|DataDirectory|\GameDatabase\Database.mdf;"
            + @"Integrated Security=True";
        private SqlConnection sqlConnection;

        /// <summary>
        /// Creates an object that connects to the database file
        /// </summary>
        internal LocalDBConnector()
        {
            #region LocalDBConnector constructor code
            try
            {
                sqlConnection = new SqlConnection(connectionString);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(Environment.NewLine);
                Debug.WriteLine("[Throwing exception error for LocalDBConnector constructor]");
                Debug.WriteLine("Could not connect to the database, please check your connection string");
                Debug.WriteLine(Environment.NewLine);
            }
            
            #endregion
        }

        /// <summary>
        /// Return the DataSet result from the SqlCommand and return a blank DataSet
        /// if an error occurs
        /// </summary>
        /// <param name="SqlCommand">SqlCommand object</param>
        internal DataSet GetDataSet(SqlCommand SqlCommand)
        {
            #region LocalDBConnector GetDataSet method code
            try
            {
                SqlCommand.Connection = sqlConnection;
                SqlDataAdapter DataAdapter = new SqlDataAdapter(SqlCommand);
                DataSet DataSet = new DataSet();
                DataAdapter.Fill(DataSet);
                return  DataSet;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(Environment.NewLine);
                Debug.WriteLine("[Throwing SqlException error for GetDataSet method from LocalDBConnector]");
                Debug.WriteLine(ex + Environment.NewLine);
                return new DataSet();
            }
            #endregion
        }

        /// <summary>
        /// Updates SqlCommdn query to local database file and will throw an SqlException
        /// if an error occurs
        /// </summary>
        /// <param name="SqlCommand">SqlCommand object</param>
        internal void DoUpdate(SqlCommand SqlCommand)
        {
            #region LocalDBConnector DoUpdate method code
            try
            {
                SqlCommand.Connection = sqlConnection;
                SqlCommand.Connection.Open();
                int ret = SqlCommand.ExecuteNonQuery();
                SqlCommand.Connection.Close();
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(Environment.NewLine);
                Debug.WriteLine("[Throwing SqlException error for DoUpdate method from LocalDBConnector]");
                Debug.WriteLine(ex + Environment.NewLine);
            }
            #endregion
        }

        /// <summary>
        /// Closes connection in the deconstructor for LocalDBConnector object
        /// </summary>
        ~LocalDBConnector()
        {
            #region LocalDBConnector deconstructor code
            try
            {
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                // Catch exception created when trying to close a closed connection
            }
            #endregion
        }
    }
}