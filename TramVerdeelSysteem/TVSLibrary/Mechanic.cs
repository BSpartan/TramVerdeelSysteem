using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Mechanic : User
    {
        Database.DatabaseManager dbm = new Database.DatabaseManager();

        public Mechanic(int userid, string name)
            : base(userid, name)
        {
        }
        public List<RepairCleanList> GetRepairList()
        {
            return dbm.GetCleaningList(false);
        }
        public void SetService(int RFID, int id)
        {
            dbm.SetService(id, false);
            //tram.SetStatus(Status.Service);
        }
    }
}
