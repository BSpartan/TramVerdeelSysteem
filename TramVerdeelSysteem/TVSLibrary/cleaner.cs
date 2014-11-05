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
        public Cleaner(int userid, string name)
            : base(userid, name)
        {
        }
        public List<RepairCleanList> GetCleaningList()
        {
            return dbm.GetCleaningList(true);
        }
        public void SetService(int RFID, int id)
        {
            dbm.SetService(id, true);
            //tram.SetStatus(Status.Service);
        }
    }
}
