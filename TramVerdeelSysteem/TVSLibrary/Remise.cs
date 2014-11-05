using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Remise
    {
        public string Name { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Remise" /> class.
        /// </summary>
        /// <param name="name">Name of the remise</param>
        public Remise(string name)
        {
            this.Name = name;
        }
    }
}