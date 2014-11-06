using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Manager : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Manager" /> class.
        /// </summary>
        /// <param name="userid">ID of the user</param>
        /// <param name="name">Name of the user</param>
        public Manager(int userid, string name)
            : base(userid, name)
        {
        }
    }
}
