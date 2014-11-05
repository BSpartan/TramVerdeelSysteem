using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Oracle.DataAccess.Client;

namespace TVSLibrary.Database
{
    public class DatabaseManager
    {
        private static OracleConnection connection;

        /// <summary>
        /// Initializes static members of the <see cref="DatabaseManager" /> class.
        /// </summary>
        static DatabaseManager()
        {
            // Connects to the database Data source, under the username User Id.
            connection = new OracleConnection("User Id= dbi298273; Password= PeKHcY2bu4; Data Source= //192.168.15.50:1521/fhictora;");
        }

        /// <summary>
        /// Gets all reservations
        /// </summary>
        /// <returns>List of all reservations</returns>
        public static List<Reservation> GetReservations()
        {
            List<Reservation> reservations = new List<Reservation>();

            connection.Open();

            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM RESERVATION");
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string rfid = Convert.ToString(reader["RFID"]);
                    int trackID = Convert.ToInt16(reader["Track_ID"]);

                    reservations.Add(new Reservation(trackID, rfid));
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return reservations;
        }

        /// <summary>
        /// Gets a RFID from a given tram number.
        /// </summary>
        /// <param name="tramNumber">tram number to find RFID for</param>
        /// <returns>RFID of the tram</returns>
        public static string GetRFIDFromTramNumber(int tramNumber)
        {
            connection.Open();

            string rfid = string.Empty;
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TRAM WHERE TNumber = :pTramNumber");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pTramNumber", tramNumber);

                OracleDataReader reader = command.ExecuteReader();

                reader.Read();

                rfid = Convert.ToString(reader["RFID"]);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return rfid;
        }

        /// <summary>
        /// Gets a tram number from a given RFID.
        /// </summary>
        /// <param name="rfid">RFID to find tram number for</param>
        /// <returns>tram number</returns>
        public static int GetTramNumberFromRFID(string rfid)
        {
            connection.Open();

            int tramNumber = 0;
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TRAM WHERE RFID = :pRFID");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pRFID", rfid);

                OracleDataReader reader = command.ExecuteReader();

                reader.Read();

                tramNumber = Convert.ToInt16(reader["TNumber"]);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return tramNumber;
        }

        /// <summary>
        /// Gets a trackID from a given track number.
        /// </summary>
        /// <param name="trackNumber">track number to find trackID for</param>
        /// <returns>track ID</returns>
        public static int GetTrackIDFromNumber(int trackNumber)
        {
            connection.Open();

            int trackID = 0;
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TRACK WHERE Number = :pTrackNumber");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pTrackNumber", trackNumber);

                OracleDataReader reader = command.ExecuteReader();

                reader.Read();

                trackID = Convert.ToInt32(reader["ID"]);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return trackID;
        }

        /// <summary>
        /// Gets a track number from a given trackID
        /// </summary>
        /// <param name="trackID">TrackID to get track number for</param>
        /// <returns>Track number</returns>
        public static int GetNumberFromTrackID(int trackID)
        {
            connection.Open();

            int trackNumber = 0;
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TRACK WHERE ID = :pTrackID");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pTrackID", trackID);

                OracleDataReader reader = command.ExecuteReader();

                reader.Read();

                trackNumber = Convert.ToInt32(reader["Number"]);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return trackNumber;
        }
        
        /// <summary>
        /// Reserves a track for a tram
        /// </summary>
        /// <param name="rfid">RFID of Tram to reserve for</param>
        /// <param name="trackID">ID of track to reserve</param>
        public static void ReserveTrack(string rfid, int trackID)
        {
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("INSERT INTO RESERVATION (RFID, Track_ID) VALUES (:pRFID, :pTrack_ID)");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pRFID", rfid);
                command.Parameters.Add(":pTrack_ID", trackID);

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
        /// Removes a reservation.
        /// </summary>
        /// <param name="rfid">RFID of reservation to remove</param>
        public static void RemoveReservation(string rfid)
        {
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("DELETE FROM RESERVATION WHERE RFID = :pRFID");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pRFID", rfid);

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
