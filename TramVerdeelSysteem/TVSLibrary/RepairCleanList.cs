using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class RepairCleanList
    {
        public int id { get; private set; }
        public string RFID { get; private set;}
        public DateTime dateTime { get; private set; }
        public Status status { get; private set; }

        public RepairCleanList(int id, string RFID, DateTime dateTime, Status status)
        {
            this.id = id;
            this.RFID = RFID;
            this.dateTime = dateTime;
            this.status = status;
        }
    }
}
