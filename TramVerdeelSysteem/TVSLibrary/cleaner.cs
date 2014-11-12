using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Cleaner : User
    {
        Database.DatabaseManager dbm = new Database.DatabaseManager();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cleaner" /> class.
        /// </summary>
        /// <param name="userid">ID of the user</param>
        /// <param name="name">Name of the User</param>
        public Cleaner(int userid, string name, int function)
            : base(userid, name, function)
        {
        }

        /// <summary>
        /// Returns a list of cleanings the cleaner has to do.
        /// </summary>
        /// <returns>List of cleanings</returns>
        public List<RepairCleanList> GetCleaningList()
        {
            return dbm.GetCleaningList(true);
        }

        /// <summary>
        /// Sets the tram to 'Service'.
        /// </summary>
        /// <param name="tram">The tram to set the status of.</param>
        public void SetService(int ID)
        {
            dbm.SetService(ID);
        }
    }
}
