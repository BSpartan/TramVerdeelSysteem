using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Track
    {
        public int Length { get; private set; }

        public int Number { get; private set; }

        public Remise Remise { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Track" /> class.
        /// </summary>
        /// <param name="length">Length of the track</param>
        /// <param name="number">Number of the track</param>
        /// <param name="remise">Remise of the track</param>
        public Track(int length, int number, Remise remise)
        {
            this.Length = length;
            this.Number = number;
            this.Remise = remise;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Track" /> class.
        /// </summary>
        /// <param name="length">Length of the track</param>
        /// <param name="number">Number of the track</param>
        public Track(int length, int number)
        {
            this.Length = length;
            this.Number = number;
        }
    }
}
