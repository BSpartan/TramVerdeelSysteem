using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Mechanic : User
    {
        public Mechanic(int userid, string name)
            : base(userid, name)
        {
        }
        public string[] GetRepairList()
        {
            //TODO
            return null;
        }
        public void SetService(Tram tram)
        {
            tram.SetStatus(Status.Service);
        }
    }
}
