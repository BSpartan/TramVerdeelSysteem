using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class LodgeEmployee : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LodgeEmployee" /> class.
        /// </summary>
        /// <param name="userid">Id of the user</param>
        /// <param name="name">Name of the user</param>
        public LodgeEmployee(int userid, string name, int function)
            : base(userid, name, function)
        {
        }

        /// <summary>
        /// Parks a tram on a sector
        /// </summary>
        /// <param name="tram">Tram to park</param>
        /// <param name="sector">Sector to park on</param>
        /// <returns>success if true, failure if false</returns>
        public bool SetTramToSector(Tram tram, Sector sector)
        {
            if (sector.Available && !sector.Blocked)
            {
                tram.SetSector(sector);
                sector.SetTram(tram);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Blocks a sector
        /// </summary>
        /// <param name="sector">Sector to block</param>
        public void BlockSector(Sector sector)
        {
            if (!sector.Blocked)
            {
                sector.ToggleBlocked();
            }
        }

        /// <summary>
        /// Blocks a track.
        /// </summary>
        /// <param name="track">Track to block</param>
        public void BlockTrack(Track track)
        {
            // TODO
        }

        /// <summary>
        /// Sets the status of a tram
        /// </summary>
        /// <param name="tram">Tram to set status of</param>
        /// <param name="status">Status to set</param>
        public void SetStatus(Tram tram, Status status)
        {
            tram.SetStatus(status);
        }

        /// <summary>
        /// Sets a tram to be cleaned.
        /// </summary>
        /// <param name="tram">Tram to be cleaned</param>
        public void SendTramToCleaning(Tram tram)
        {
            tram.AddMaintenace(tram, true, false);
        }

        /// <summary>
        /// Sets a tram to be repaired
        /// </summary>
        /// <param name="tram">Tram to be repaired</param>
        public void SendTramToRepair(Tram tram)
        {
            tram.AddMaintenace(tram, false, true);
        }
    }
}
