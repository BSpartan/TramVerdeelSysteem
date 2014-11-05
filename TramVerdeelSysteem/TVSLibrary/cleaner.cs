using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    class Cleaner : User
    {
        public Cleaner(int userid, string name)
            : base(userid, name)
        {
        }
        public static string[] GetCleaningList()
        {
            string[] cleaningList;
            try
            {
                Database db = new Database();
                db.CreateCommand("SELECT * FROM werknemer");

                db.OpenConnection();
                db.ExecuteCommand();

                OracleDataReader dr = db.DataReader;

                while(dr.Read())
                {
                    //dr.Read();
                    int userId = dr.GetValueByColumn<int>("id");
                    int workernumber = dr.GetValueByColumn<int>("workernumber");
                    string firstname = dr.GetValueByColumn<string>("firstname");
                    string lastname = dr.GetValueByColumn<string>("lastname");
                    string phonenumber = dr.GetValueByColumn<string>("phonenumber");

                    cleaningList
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
