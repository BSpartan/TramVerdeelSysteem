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
        public int TramId { get; private set; }
        public string TramType { get; private set; }

        public Tram(string tramType, int tramId)
        {
            this.TramType = tramType;
            this.TramId = tramId;
            Status = Status.Service;
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
    }
}
