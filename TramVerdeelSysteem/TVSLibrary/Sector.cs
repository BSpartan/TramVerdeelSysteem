using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    class Sector
    {
        public bool Available { get; private set; }
        public bool Blocked { get; private set; }
        public int Number { get; private set; }
        public Track Track { get; private set; }
        public Tram Tram { get; private set; }

        public Sector(int Number, Track track)
        {
            this.Number = Number;
            this.Track = track;
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
