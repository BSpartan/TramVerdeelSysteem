using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Database
using Oracle.DataAccess.Client;
using System.Data;

namespace TVSLibrary
{
    public class Database
    {
		private string dbLogin = "SE22";
        private string dbPassword = "SE22";
		//DB-bjork
        //private string dbLogin = "dbi314086";
        //private string dbPassword = "qsdmj2v6RT";
        private string dbServer = "localhost:1521";
        private string dbName = "xe";

        private OracleConnection conn;
        private OracleCommand cmd;
        private OracleDataReader dataReader;

        public Database()
        {
            conn = new OracleConnection("User Id=" + dbLogin + ";Password=" + dbPassword + ";Data Source=" + "//" + dbServer + "/" + dbName + ";");
        }

        public OracleCommand Command { get { return cmd; } }
        public OracleConnection Connection { get { return conn; } }
        public OracleDataReader DataReader { get { return dataReader; } }

         public OracleParameter lastId = new OracleParameter();
        

        public void OpenConnection()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw new Exception("Verbinding met de database server mislukt.");
            }
        }

        public void CloseConnection()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public void CreateCommand(string commandText)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = commandText;
        }

        public void AddParameter(string parameterName, object value)
        {
            OracleParameter parameter = new OracleParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = value;

            cmd.Parameters.Add(parameter);
        }

        public void GetParameter(string parameterName)
        {
            lastId = new OracleParameter("NULL", OracleDbType.Int32); 
            lastId.ParameterName = parameterName;
            lastId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(lastId);
        }

        public bool ExecuteCommand()
        {            
            dataReader = cmd.ExecuteReader();
            if (dataReader != null)
            {
                return true;
            }
            return false;
        }

    }
}
