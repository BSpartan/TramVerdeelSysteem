using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class TramDriver : User
    {
        public TramDriver(int userid, string name)
            : base(userid, name)
        {
        }
        public Sector AddTram(int tramId)
        {
            //TODO
            return null;
        }
    }
}
