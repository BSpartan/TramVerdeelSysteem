using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Diagnostics;

namespace TVSLibrary.Database
{
    public class DatabaseManager
    {
        private static OracleConnection connection;

        static DatabaseManager()
        {
            //Connects to the database Data source, under the username User Id.
            connection = new OracleConnection("User Id= dbi298273; Password= PeKHcY2bu4; Data Source= //192.168.15.50:1521/fhictora;");
        }

        public static string GetRFIDFromTramNumber(int tramNumber)
        {
            connection.Open();

            string RFID;
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TRAM WHERE number = :pTramNumber");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pTramNumber", tramNumber);

                OracleDataReader reader = command.ExecuteReader();

                reader.Read();

                RFID = Convert.ToString(reader["RFID"]);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return RFID;
        }

        public static void ReserveSector(string RFID, int sectorNumber)
        {
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("INSERT INTO RESERVATION (RFID, Sector_ID) VALUES (:pRFID, :pSectorID)");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pRFID", RFID);
                command.Parameters.Add(":pSectorID", sectorNumber);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
