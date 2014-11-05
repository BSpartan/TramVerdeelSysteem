using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSLibrary.Database;

namespace TVSLibrary
{
    public class Reservation
    {
        public string RFID { get; private set; }
        public int trackID { get; private set; }

        public Reservation(int trackID, string RFID)
        {
            this.RFID = RFID;
            this.trackID = trackID;
        }

        public override string ToString()
        {
            return (DatabaseManager.GetNumberFromTrackID(trackID) + " - " + DatabaseManager.GetTramNumberFromRFID(RFID));
        }
    }
}
