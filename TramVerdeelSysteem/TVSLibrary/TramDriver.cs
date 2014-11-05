using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class TramDriver : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TramDriver" /> class.
        /// </summary>
        /// <param name="userid">ID of the user</param>
        /// <param name="name">Name of the user</param>
        public TramDriver(int userid, string name)
            : base(userid, name)
        {
        }

        /// <summary>
        /// Adds a tram to a sector
        /// </summary>
        /// <param name="tramId">ID of the tram to add</param>
        /// <returns>Sector the tram is added to</returns>
        public Sector AddTram(int tramId)
        {
            // TODO
            return null;
        }
    }
}
