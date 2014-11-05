using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Sector
    {
        public bool Available { get; private set; }
        public bool Blocked { get; private set; }
        public int Number { get; private set; }
        public Track Track { get; private set; }
        public Tram Tram { get; private set; }
        public int ID { get; private set; }

        public Sector(int ID, int Number, Track track)
        {
            this.ID = ID;
            this.Number = Number;
            this.Track = track;
            this.Available = true;
            this.Blocked = false;
        }
        public void SetTram(Tram tram)
        {
            this.Tram = tram;
        }

        public void ToggleAvailable()
        {
            if (Available == true)
                Available = false;
            else
                Available = true;
        }

        public void ToggleBlocked()
        {
            if (Blocked == true)
                Blocked = false;
            else
                Blocked = true;
        }

    }
}
