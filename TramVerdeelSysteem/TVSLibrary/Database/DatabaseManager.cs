﻿using System;
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
            //connection = new OracleConnection("User Id= dbi298273; Password= PeKHcY2bu4; Data Source= //192.168.15.50:1521/fhictora;");
            connection = new OracleConnection("User Id= PTS2; Password= PTS2; Data Source= //localhost:1521/xe;");
        }

        /// <summary>
        /// Gets all reservations
        /// </summary>
        /// <returns>List of all reservations</returns>
        public List<Reservation> GetReservations()
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
        public string GetRFIDFromTramNumber(int tramNumber)
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
        public int GetTramNumberFromRFID(string rfid)
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
        public int GetTrackIDFromNumber(int trackNumber)
        {
            connection.Open();

            int trackID = 0;
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM TRACK WHERE TNumber = :pTrackNumber");
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
        public int GetNumberFromTrackID(int trackID)
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

                trackNumber = Convert.ToInt32(reader["TNumber"]);
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
        public void ReserveTrack(string rfid, int trackID)
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
        public void RemoveReservation(string rfid)
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

        public List<RepairCleanList> GetCleaningList(bool isCleaner)
        {
            List<RepairCleanList> cleaningList = new List<RepairCleanList>();
            connection.Open();
            try
            {
                OracleCommand command;

                if (isCleaner)
                    command = new OracleCommand("SELECT * FROM TRAM_MAINTENANCE WHERE maintenanceType = 'Cleaning'");
                else
                    command = new OracleCommand("SELECT * FROM TRAM_MAINTENANCE WHERE maintenanceType = 'Defect'");

                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
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

        public void SetService(int id)
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
                    allTracks.Add(new Track(Convert.ToInt32(reader["Length"]), Convert.ToInt32(reader["TNumber"]), Convert.ToInt32(reader["ID"])));
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
            Tram tram = null;
            Sector sector = null;
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
                        track = new Track(Convert.ToInt32(read["Length"]), Convert.ToInt32(read["TNumber"]), Convert.ToInt32(read["ID"]));
                    }

                    sector = new Sector(Convert.ToInt32(reader["SNumber"]), track);

                    if (reader["RFID"] != DBNull.Value)
                    {
                        OracleCommand commando2 = new OracleCommand("SELECT * FROM Tram WHERE RFID = :id");
                        commando2.Parameters.Add("id", Convert.ToString(reader["RFID"]));

                        commando2.CommandType = CommandType.Text;
                        commando2.Connection = connection;

                        OracleDataReader read2 = commando2.ExecuteReader();

                        read2.Read();

                        if (read2.HasRows)
                        {
                            tram = new Tram(Convert.ToString(read2["TRAMTYPE_ID"]), Convert.ToString(read2["RFID"]), Convert.ToInt32(read2["TNUMBER"]));
                        }

                        sector.SetTram(tram);
                    }
                    AllSectors.Add(sector);
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
                    AllTrams.Add(new Tram(Convert.ToString(reader["TramType_Id"]), Convert.ToString(reader["RFID"]), Convert.ToInt32(reader["TNumber"])));
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

        public void GenerateSector(Track tk)
        {
            connection.Open();
            try
            {
                for (int i = 0; i < tk.Length; i++)
                {
                    OracleCommand command = new OracleCommand("INSERT INTO SECTOR (ID, TRACK_ID, RFID, SNUMBER) VALUES (SECTORSEQ.NEXTVAL, :trackId, null, :snumber)");
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    command.Parameters.Add(":trackId", tk.id);
                    command.Parameters.Add(":snumber", (i + 1));

                    command.ExecuteNonQuery();
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
        }

        public bool CheckPassword(int id, string password)
        {
            bool succes = false;
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM EMPLOYEE WHERE ID = :pID and Password = :pPassword");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pID", id);
                command.Parameters.Add(":pPassword", password);

                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    succes = true;
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
            return succes;
        }

        public User GetUserData(int id)
        {
            object user = null;
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("SELECT * FROM Employee WHERE ID = :pID");

                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pID", id);

                OracleDataReader reader = command.ExecuteReader();

                reader.Read();
                int function = Convert.ToInt16(reader["Function"]);
                switch (function)
                {
                    case 1:
                        user = new Manager(Convert.ToInt16(reader["ID"]), Convert.ToString(reader["Name"]), function);
                        break;
                    case 2:
                        user = new LodgeEmployee(Convert.ToInt16(reader["ID"]), Convert.ToString(reader["Name"]), function);
                        break;
                    case 3:
                        user = new TramDriver(Convert.ToInt16(reader["ID"]), Convert.ToString(reader["Name"]), function);
                        break;
                    case 4:
                        user = new Mechanic(Convert.ToInt16(reader["ID"]), Convert.ToString(reader["Name"]), function);
                        break;
                    case 5:
                        user = new Cleaner(Convert.ToInt16(reader["ID"]), Convert.ToString(reader["Name"]), function);
                        break;
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

            return (User)user;
        }

        public void VeranderTramStatus(string number, string status)
        {
            connection.Open();
            string sql = "UPDATE TRAM SET STATUS = :status WHERE TNUMBER = :number";
            OracleCommand com = new OracleCommand(sql, connection);
            com.Parameters.Add(new OracleParameter("status", status));
            com.Parameters.Add(new OracleParameter("number", number));
            try
            {
                
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                connection.Close(); 
            }
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
        public string GetTramByRfid(string rfid)
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
            OracleCommand command = new OracleCommand("Update sector set Rfid = :rfid where id = :id");
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add(":rfid", rfid);
            command.Parameters.Add(":id", Convert.ToInt32(track));
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

        public void RemoveTramFromSector(string RFID)
        {
            OracleCommand command = new OracleCommand("Update sector set Rfid = NULL where RFID = :rfid");
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add(":rfid", Convert.ToString(RFID));
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

        internal string GetEmptyTrack(int trackId)
        {
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("select * from sector where TRACK_ID = :tid AND RFID  is null and rownum =1");
                command.Parameters.Add("tid", trackId);
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
