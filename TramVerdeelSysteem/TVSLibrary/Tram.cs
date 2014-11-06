using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSLibrary.Database;
using TVSLibrary;

namespace TVSLibrary
{
    public class Tram
    {
        private DatabaseManager db;
        public Sector Sector { get; private set; }
        public Status Status { get; private set; }
        public TramDriver Tramdriver { get; private set; }
        public string Rfid { get; private set; }
        public string TramType { get; private set; }

        public Tram(string tramType, string rfid)
        {
            this.TramType = tramType;
            this.Rfid = rfid;
            Status = Status.Service;
        }

        public Tram(string rfid)
        {
            this.db = new DatabaseManager();
            this.Rfid = rfid;
            this.TramType = db.GetTramByRfid(this.Rfid);
        }
        public Tram()
        {
            this.db = new DatabaseManager();
        }

        public void SetSector(Sector sector)
        {
            this.Sector = sector;
        }
        public void SetStatus(Status status)
        {
            this.Status = status;
        }
        public void SendToCleaning()
        {
            this.Status = Status.Cleaning;
        }
        public void SendToRepair()
        {
            this.Status = Status.Defect;
        }
        public void SetTramDriver(TramDriver tramdriver)
        {
            this.Tramdriver = tramdriver;
        }

        public void AddMaintenace(Tram tram, bool schoonmaak, bool reparatie)
        {
            if(schoonmaak)
                this.db.AddMaintenace(tram.Rfid, Status.Cleaning);
            if (reparatie)
                this.db.AddMaintenace(tram.Rfid, Status.Defect);
            
        }
    }
}
