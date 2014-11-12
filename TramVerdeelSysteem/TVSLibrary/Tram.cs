using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSLibrary.Database;

namespace TVSLibrary
{
    public class Tram
    {

        private DatabaseManager db;

        public Sector Sector { get; private set; }

        public Status Status { get; private set; }

        public TramDriver Tramdriver { get; private set; }

        public int TramNr { get; private set; }

        public string RFID { get; private set; }

        public string TramType { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tram"
        /// </summary>
        /// <param name="tramType">Type of the tram</param>
        /// <param name="RFID">RFID of the tram</param>
        /// <param name="tramNr">Number of the tram</param>
        public Tram(string tramType, string RFID, int tramNr)
        {
            this.TramType = tramType;
            this.RFID = RFID;
            this.TramNr = tramNr;
            Status = Status.Service;
            this.db = new DatabaseManager();
        }

        public Tram(string RFID)
        {
            this.RFID = RFID;
            this.db = new DatabaseManager();
            this.TramType = db.GetTramByRfid(RFID);
        }

        /// <summary>
        /// Sets the sector of the tram
        /// </summary>
        /// <param name="sector">Sector to set</param>
        public void SetSector(Sector sector)
        {
            this.Sector = sector;
        }

        /// <summary>
        /// Sets the status of the tram
        /// </summary>
        /// <param name="status">Status to set</param>
        public void SetStatus(Status status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Sets the tram driver
        /// </summary>
        /// <param name="tramdriver">Tram driver to set to tram</param>
        public void SetTramDriver(TramDriver tramdriver)
        {
            this.Tramdriver = tramdriver;
        }

        /// <summary>
        /// adds the tram to the maintenance table if needed.
        /// </summary>
        /// <param name="tram">what tram</param>
        /// <param name="schoonmaak">in need of cleaning</param>
        /// <param name="reparatie">in need of repair</param>
        public void AddMaintenace(Tram tram, bool schoonmaak, bool reparatie)
        {
            if (schoonmaak)
                this.db.AddMaintenace(tram.RFID, Status.Cleaning);
            if (reparatie)
                this.db.AddMaintenace(tram.RFID, Status.Defect);
        }
        /// <summary>
        /// gets the track for the Tram
        /// </summary>
        /// <returns>track</returns>
        public string GetTrack()
        {
            string track = string.Empty;
            string reservation = string.Empty;
            if (db.CheckTramOnTrack(this.RFID))
                return "Tram al ingedeeld.";

            reservation = db.GetReservationByRFID(this.RFID);
            if (reservation != null)
            {
                db.InsertSector(this.RFID, reservation);
                db.RemoveReservation(this.RFID);
                return reservation;
            }
            else
            {
                track = db.GetEmptyTrack();
                db.InsertSector(this.RFID, track);
                return track;
            }
        }

        public string GetTrack(int tracknummer)
        {
            string track = string.Empty;
            string reservation = string.Empty;
            if (db.CheckTramOnTrack(this.RFID))
                return "Tram al ingedeeld.";

            reservation = db.GetReservationByRFID(this.RFID);
            if (reservation != null)
            {
                reservation = db.GetEmptyTrack(Convert.ToInt32(reservation));
                db.InsertSector(this.RFID, reservation);
                db.RemoveReservation(this.RFID);
                return reservation;
            }
            else
            {
                int trackId = db.GetTrackIDFromNumber(tracknummer);
                    track = db.GetEmptyTrack(trackId);
                db.InsertSector(this.RFID, track);
                return track;
            }
        }

        public Sector SortTram(List<Sector> AllSectors)
        {
            bool trackset = false;
            Sector current = null;
                if (this.Status == Status.Cleaning)
                {
                }
                else if (this.Status == Status.Defect)
                {
                }
                else if (this.TramNr <= 841 && this.TramNr >= 817)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 30)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 33)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 35)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 57)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                else if ((this.TramNr <= 901 && this.TramNr >= 920) || (this.TramNr <= 2201 && this.TramNr >= 2204))
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 37)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 54)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 56)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                else if (this.TramNr == 2001 || this.TramNr == 2004 || this.TramNr == 2014 || this.TramNr == 2032 || this.TramNr == 2037 || this.TramNr == 2039 || this.TramNr == 2043 || this.TramNr == 2050 || this.TramNr == 2058 || this.TramNr == 2072)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 32)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 41)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                else if (this.TramNr == 2002 || this.TramNr == 2008 || this.TramNr == 2017 || this.TramNr == 2018 || this.TramNr == 2019 || this.TramNr == 2025 || this.TramNr == 2031 || this.TramNr == 2036 || this.TramNr == 2042 || this.TramNr == 2049 || this.TramNr == 2051 || this.TramNr == 2054 || this.TramNr == 2055)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 34)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 38)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 55)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 63)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                else if (this.TramNr == 2003 || this.TramNr == 2005 || this.TramNr == 2011 || this.TramNr == 2012 || this.TramNr == 2013 || this.TramNr == 2016 || this.TramNr == 2020 || this.TramNr == 2022 || this.TramNr == 2026 || this.TramNr == 2027 || this.TramNr == 2028 || this.TramNr == 2038 || this.TramNr == 2044 || this.TramNr == 2047 || this.TramNr == 2060 || this.TramNr == 2071)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 45)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 52)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                else if (this.TramNr == 2006 || this.TramNr == 2010 || this.TramNr == 2015 || this.TramNr == 2021 || this.TramNr == 2030 || this.TramNr == 2040 || this.TramNr == 2045 || this.TramNr == 2046 || this.TramNr == 2048 || this.TramNr == 2056 || this.TramNr == 2067 || this.TramNr == 2070)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 44)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 53)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                else if (this.TramNr == 2007 || this.TramNr == 2009 || this.TramNr == 2023 || this.TramNr == 2024 || this.TramNr == 2029 || this.TramNr == 2033 || this.TramNr == 2034 || this.TramNr == 2035 || this.TramNr == 2041 || this.TramNr == 2052 || this.TramNr == 2053 || this.TramNr == 2059 || this.TramNr == 2061 || this.TramNr == 2064 || this.TramNr == 2066 || this.TramNr == 2068)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 36)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        else if (s.Track.Number == 43)
                        {
                            if (s.Blocked == false && s.Tram == null)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Blocked == false && s.Tram == null)
                        {
                            current = s;
                            trackset = true;
                            break;
                        }
                    }
                }
            this.Sector = current;
            return current;
        }
    }
}
