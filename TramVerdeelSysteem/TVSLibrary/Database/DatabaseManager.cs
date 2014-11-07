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
        /// <summary>
        /// Gets the track by rfid
        /// </summary>
        /// <param name="rfid"> gets a track by rfid</param>
        /// <returns>null or track id.</returns>
        internal string GetReservationByRFID(string rfid)
        {
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("select * from reservation where RFID = :rfid");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add("rfid", rfid);

                OracleDataReader reader = command.ExecuteReader();

                reader.Read();

                return Convert.ToString(reader["Track_ID"]);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }

        }
        /// <summary>
        /// checks if tram already exist on the track
        /// </summary>
        /// <param name="rfid">rfid</param>
        /// <returns>if the tram is found on a sector</returns>
        internal bool CheckTramOnTrack(string rfid)
        {

            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("select * from sector where RFID  = :rfid");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add("rfid", rfid);

                OracleDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(reader);

                if (dt.Rows.Count != 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// inserts a tram on a sector
        /// </summary>
        /// <param name="rfid">tram</param>
        /// <param name="track">setor</param>
        internal void InsertSector(string rfid,string track)
        {
            OracleCommand command = new OracleCommand("Update sector set Rfid = :rfid where id = :id)");
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add("rfid", rfid);
            command.Parameters.Add("id", Convert.ToInt32(track));
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
        /// gets an empty sectorid
        /// </summary>
        /// <returns>empty sector</returns>
        internal string GetEmptyTrack()
        {
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("select * from sector where RFID  is null and rownum =1");
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                reader.Read();

                return Convert.ToString(reader["id"]);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return "Error with SQL";
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
