using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    class Track
    {
        public int Length { get; private set; }
        public int Number { get; private set; }
        public Remise Remise { get; private set; }

        public Track(int length, int number, Remise remise)
        {
            this.Length = length;
            this.Number = number;
            this.Remise = remise;
        }
    }
}
