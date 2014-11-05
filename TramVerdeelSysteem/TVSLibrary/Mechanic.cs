﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Mechanic : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mechanic" /> class.
        /// </summary>
        /// <param name="userid">ID of the user</param>
        /// <param name="name">Name of the user</param>
        public Mechanic(int userid, string name)
            : base(userid, name)
        {
        }

        /// <summary>
        /// Gets a list of repairs
        /// </summary>
        /// <returns>List of repairs</returns>
        public string[] GetRepairList()
        {
            // TODO
            return null;
        }

        /// <summary>
        /// Sets a tram to service
        /// </summary>
        /// <param name="tram">Tram to set</param>
        public void SetService(Tram tram)
        {
            tram.SetStatus(Status.Service);
        }
    }
}
