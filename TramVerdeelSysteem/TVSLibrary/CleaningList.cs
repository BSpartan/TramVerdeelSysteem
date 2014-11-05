using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class CleaningList
    {
        private int tramId;
        private DateTime datum;
        private Status status;

        public int TramId { get { return tramId; } }
        public DateTime Datum { get { return datum; } }
        public Status Status { get { return status; } }

        public CleaningList(int tramId, DateTime dateTime, Status Status)
        {
            this.tramId = tramId;
            this.datum = dateTime;
            this.status = Status;
        }
    }
}
