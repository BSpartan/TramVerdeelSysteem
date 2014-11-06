// class for the use of trams
namespace TVSLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TVSLibrary;
    using TVSLibrary.Database;

    /// <summary>
    /// class for the use of trams
    /// </summary>
    public class Tram
    {

        private DatabaseManager db;


        /// <summary>
        /// Sets the values of a tram
        /// </summary>
        /// <param name="tramType">type of the tram</param>
        /// <param name="rfid">RFID of the tram</param>
        public Tram(string tramType, string rfid)
        {
            this.TramType = tramType;
            this.Rfid = rfid;

            Status = Status.Service;
        }

        /// <summary>
        /// sets a tram by rfid
        /// </summary>
        /// <param name="rfid">rfid of the tram</param>
        public Tram(string rfid)
        {
            this.db = new DatabaseManager();
            this.Rfid = rfid;
            this.TramType = this.db.GetTramByRfid(this.Rfid);
        }

        /// <summary>
        /// initialization of the tram for database queries
        /// </summary>
        public Tram()
        {
            this.db = new DatabaseManager();
        }

        public Sector Sector { get; private set; }
        public Status Status { get; private set; }
        public TramDriver Tramdriver { get; private set; }
        public string Rfid { get; private set; }
        public string TramType { get; private set; }


        /// <summary>
        /// Gives the tram a sector
        /// </summary>
        /// <param name="sector">Given sector</param>
        public void SetSector(Sector sector)
        {
            this.Sector = sector;
        }

        /// <summary>
        /// sets a tram status
        /// </summary>
        /// <param name="status">status of the tram</param>
        public void SetStatus(Status status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Sets the status to Cleaning.
        /// </summary>
        public void SendToCleaning()
        {
            this.Status = Status.Cleaning;
        }

        /// <summary>
        /// Sets the status to Defect
        /// </summary>
        public void SendToRepair()
        {
            this.Status = Status.Defect;
        }

        /// <summary>
        /// Sets the tramdriver
        /// </summary>
        /// <param name="tramdriver">Tramdriver that needs to be set</param>
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
                this.db.AddMaintenace(tram.Rfid, Status.Cleaning);
            if (reparatie)
                this.db.AddMaintenace(tram.Rfid, Status.Defect);
            
        }
    }
}
