using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    class LodgeEmployee : User
    {
        public LodgeEmployee(int userid, string name)
            : base(userid, name)
        {
        }
        public bool SetTramToSector(Tram tram, Sector sector)
        {
            if (sector.Available && !sector.Blocked)
            {
                tram.SetSector(sector);
                sector.SetTram(tram);
                return true;
            }
            else
                return false;
        }
        public void BlockSector(Sector sector)
        {
            if (!sector.Blocked)
                sector.ToggleBlocked();
        }
        public void BlockTrack(Track track)
        {
            //TODO
        }
        public void SetStatus(Tram tram, Status status)
        {
            tram.SetStatus(status);
        }
        public void SendTramToCleaning(Tram tram)
        {
            tram.SendToCleaning();
        }
        public void SendTramToRepair(Tram tram)
        {
            tram.SendToRepair();
        }

    }
}
