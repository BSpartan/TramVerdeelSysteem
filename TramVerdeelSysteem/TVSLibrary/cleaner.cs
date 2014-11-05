using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Cleaner : User
    {
        public Cleaner(int userid, string name)
            : base(userid, name)
        {
        }
        public string[] GetCleaningList()
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
