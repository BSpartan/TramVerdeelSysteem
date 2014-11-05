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
                    string RFID = Convert.ToString(reader["RFID"]);
                    int trackID = Convert.ToInt16(reader["Track_ID"]);

                    reservations.Add(new Reservation(trackID, RFID));
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

        public static string GetRFIDFromTramNumber(int tramNumber)
        {
            connection.Open();

            string RFID = "";
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TRAM WHERE TNumber = :pTramNumber");
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

        public static int GetTramNumberFromRFID(string RFID)
        {
            connection.Open();

            int tramNumber = 0;
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TRAM WHERE RFID = :pRFID");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pRFID", RFID);

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

        public static int GetNumberFromTrackID(int TrackID)
        {
            connection.Open();

            int trackNumber = 0;
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TRACK WHERE ID = :pTrackID");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pTrackID", TrackID);

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

        public static void ReserveSector(string RFID, int trackID)
        {
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("INSERT INTO RESERVATION (RFID, Track_ID) VALUES (:pRFID, :pTrack_ID)");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pRFID", RFID);
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

        public static void RemoveReservation(string RFID)
        {

        }
    }
}
