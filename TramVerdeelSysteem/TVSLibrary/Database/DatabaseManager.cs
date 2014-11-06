using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Diagnostics;
using Oracle;

namespace TVSLibrary.Database
{
    public class DatabaseManager
    {
        private OracleConnection connection;

        public DatabaseManager()
        {
            //Connects to the database Data source, under the username User Id.
            connection = new OracleConnection("User Id= system; Password= 49917061; Data Source= //localhost:1521/XE;");
        }

        public string GetRFIDFromTramNumber(int tramNumber)
        {
            connection.Open();

            string RFID = "";
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

        public void ReserveSector(string RFID, int sectorNumber)
        {
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("INSERT INTO RESERVATION (RFID, Sector_ID) VALUES (:pRFID, :pSectorID)");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add("pRFID", RFID);
                command.Parameters.Add("pSectorID", sectorNumber);

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

        /// <summary>
        /// Adds a maintance to the database
        /// </summary>
        /// <param name="rfid">RFID of the Tram</param>
        /// <param name="status">Status that needs to be added to the Tram</param>
        internal void AddMaintenace(string rfid, Status status)
        {
            OracleCommand command = new OracleCommand("INSERT INTO TRAM_MAINTENANCE (ID,RFID, \"DateTime\" ,MaintenanceType) VALUES (MAINTENANCESEQ.NEXTVAL,:pRFID, SYSDATE,:Type)");
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add("pRFID", rfid);
            command.Parameters.Add("Type", status.ToString());
            string a = command.CommandText;
            a.ToUpper();
            connection.Open();
            try
            {
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
        /// <summary>
        /// returns tramtype
        /// </summary>
        /// <param name="rfid">determines the tram</param>
        /// <returns>tram type</returns>
        internal string GetTramByRfid(string rfid)
        {
            connection.Open();

            string type = "";
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TRAM left join TRAMTYPE on tramtype.id = tram.tramtype_id WHERE rfid = :rfid");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add("rfid", rfid);

                OracleDataReader reader = command.ExecuteReader();

                reader.Read();

                type = Convert.ToString(reader["DESCRIPTION"]);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return type;
        }
    }
}
