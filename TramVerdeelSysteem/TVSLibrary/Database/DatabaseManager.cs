using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace TVSLibrary.Database
{
    class DatabaseManager
    {
        private static OracleConnection connection;

        static DatabaseManager()
        {
            //Connects to the database Data source, under the username User Id.
            connection = new OracleConnection("User Id= ; Password= ; Data Source= //192.168.15.50:1521/fhictora;");
        }

        static DatabaseManager(string connectionString)
        {
            //Connects to the database with the given connectionString.
            connection = new OracleConnection(connectionString);
        }
    }
}
