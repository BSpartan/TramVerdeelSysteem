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

        public int TrackID { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reservation" /> class.
        /// </summary>
        /// <param name="trackID">trackID of the reservation</param>
        /// <param name="rfid">RFID of the reservation</param>
        public Reservation(int trackID, string rfid)
        {
            this.RFID = rfid;
            this.TrackID = trackID;
        }

        /// <summary>
        /// Returns a string for Reservation
        /// </summary>
        /// <returns>String of the reservation</returns>
        public override string ToString()
        {
            return (DatabaseManager.GetNumberFromTrackID(this.TrackID) + " - " + DatabaseManager.GetTramNumberFromRFID(this.RFID));
        }
    }
}
