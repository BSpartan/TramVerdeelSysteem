using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Tram
    {
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
        /// <param name="rfid">RFID of the tram</param>
        /// <param name="tramNr">Number of the tram</param>
        public Tram(string tramType, string rfid, int tramNr)
        {
            this.TramType = tramType;
            this.RFID = rfid;
            this.TramNr = tramNr;
            Status = Status.Service;
        }

        /// <summary>
        /// Sets the sector of the tram
        /// </summary>
        /// <param name="sector">Sector to set</param>
        public void SetSector(Sector sector)
        {
            this.Sector = sector;
            sector.SetTram(this);
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
        /// Sets the status of the tram to cleaning
        /// </summary>
        public void SendToCleaning()
        {
            this.Status = Status.Cleaning;
        }

        /// <summary>
        /// Sets the status of the tram to repair
        /// </summary>
        public void SendToRepair()
        {
            this.Status = Status.Defect;
        }

        /// <summary>
        /// Sets the tram driver
        /// </summary>
        /// <param name="tramdriver">Tram driver to set to tram</param>
        public void SetTramDriver(TramDriver tramdriver)
        {
            this.Tramdriver = tramdriver;
        }
    }
}
