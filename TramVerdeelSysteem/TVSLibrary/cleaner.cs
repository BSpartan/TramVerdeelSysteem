using Oracle.DataAccess.Client;
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
        public static List<CleaningList> GetCleaningList()
        {
            List<CleaningList> cleaningList = new List<CleaningList>();
            try
            {
                Database db = new Database();
                db.CreateCommand("SELECT * FROM TRAM_MAINTENANCE WHERE MaintenanceType = 'Defect'");

                db.OpenConnection();
                db.ExecuteCommand();

                OracleDataReader dr = db.DataReader;

                while(dr.Read())
                {
                    //dr.Read();
                    int RFID = dr.GetValueByColumn<int>("RFID");
                    DateTime dateTime = dr.GetValueByColumn<DateTime>("DateTime");
                    Status status = Status.Defect;

                    cleaningList.Add(new CleaningList(RFID, dateTime, status));
                }

                db.CloseConnection();
                return cleaningList;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            return null;
        }
        public void SetService(Tram tram)
        {
            tram.SetStatus(Status.Service);
        }
    }
}
