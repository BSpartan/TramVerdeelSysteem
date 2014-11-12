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

        /// <summary>
        /// Initializes a new instance of the <see cref="Sector" /> class.
        /// </summary>
        /// <param name="number">Number of the sector</param>
        /// <param name="track">Track of the sector</param>
        public Sector(int number, Track track)
        {
            this.Number = number;
            this.Track = track;
            this.Available = true;
            this.Blocked = false;
        }

        /// <summary>
        /// Sets a tram to this sector.
        /// </summary>
        /// <param name="tram">tram to set to this sector</param>
        public void SetTram(Tram tram)
        {
            this.Tram = tram;
        }

        /// <summary>
        /// Toggles the available variable
        /// </summary>
        public void ToggleAvailable()
        {
            if (this.Available == true)
            {
                this.Available = false;
            }
            else
            {
                this.Available = true;
            }
        }

        /// <summary>
        /// Toggles the blocked variable
        /// </summary>
        public void ToggleBlocked()
        {
            this.Blocked = !this.Blocked;

        }
    }
}
