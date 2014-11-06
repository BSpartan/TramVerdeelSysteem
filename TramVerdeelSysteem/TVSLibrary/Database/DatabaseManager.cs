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
            //connection = new OracleConnection("User Id= dbi298273; Password= PeKHcY2bu4; Data Source= //192.168.15.50:1521/fhictora;");
            connection = new OracleConnection("User Id= PTS2; Password= PTS2; Data Source= //localhost:1521/xe;");
        }

        public static string GetRFIDFromTramNumber(int tramNumber)
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

        public List<RepairCleanList> GetCleaningList(bool isCleaner)
        {
            List<RepairCleanList> cleaningList = new List<RepairCleanList>();
            connection.Open();
            try
            {
                OracleCommand command;

                if(isCleaner)
                   command  = new OracleCommand("SELECT * FROM TRAM_MAINTENANCE WHERE maintenanceType = 'Cleaning'");
                else
                   command = new OracleCommand("SELECT * FROM TRAM_MAINTENANCE WHERE maintenanceType = 'Defect'");

                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    if (isCleaner)
                        cleaningList.Add(new RepairCleanList(Convert.ToInt32(reader["ID"]), Convert.ToString(reader["RFID"]), Convert.ToDateTime(reader["DateTime"]), Status.Cleaning));
                    else
                        cleaningList.Add(new RepairCleanList(Convert.ToInt32(reader["ID"]), Convert.ToString(reader["RFID"]), Convert.ToDateTime(reader["DateTime"]), Status.Defect));
                    
                }

                return cleaningList;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
                
            }

            return null;
        }

        public void SetService(int id, bool Cleaning)
        {
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("UPDATE tram_maintenance SET maintenanceType = 'Service' WHERE ID = :id");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":id", id);

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

        public List<Track> GetAllTracks()
        {
            List<Track> allTracks = new List<Track>();
            connection.Open();
            try
            {
                 OracleCommand command = new OracleCommand("SELECT * FROM Track");

                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   allTracks.Add(new Track(Convert.ToInt32(reader["Length"]), Convert.ToInt32(reader["Number"])));
                }

                return allTracks;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();

            }

            return null;
        }

        public List<Sector> GetAllSectors()
        {
            List<Sector> AllSectors = new List<Sector>();
            Track track = null;
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM Sector");

                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                        OracleCommand commando = new OracleCommand("SELECT * FROM Track WHERE ID = :id");
                        commando.Parameters.Add("id", Convert.ToInt32(reader["TRACK_ID"]));

                        commando.CommandType = CommandType.Text;
                        commando.Connection = connection;

                        OracleDataReader read = commando.ExecuteReader();

                        read.Read();

                        if (read.HasRows)
                        {
                            track = new Track(Convert.ToInt32(read["Length"]), Convert.ToInt32(read["Number"]));
                        }

                        AllSectors.Add(new Sector(Convert.ToInt32(reader["Number"]), track));
                }

                return AllSectors;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();

            }

            return null;
        }

        public List<Tram> GetAllTrams()
        {
            List<Tram> AllTrams = new List<Tram>();
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM Tram");

                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    AllTrams.Add(new Tram(Convert.ToString(reader["TramType_Id"]), Convert.ToString(reader["RFID"]), Convert.ToInt32(reader["Number"])));
                }

                return AllTrams;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();

            }

            return null;
        }
    }
}
