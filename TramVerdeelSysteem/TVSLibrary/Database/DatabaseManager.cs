using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Diagnostics;

namespace TVSLibrary.Database
{
    public class DatabaseManager
    {
        private OracleConnection connection;

        public DatabaseManager()
        {
            //Connects to the database Data source, under the username User Id.
            this.connection = new OracleConnection("User Id= dbi298273; Password= PeKHcY2bu4; Data Source= //192.168.15.50:1521/fhictora;");
        }

        public bool OpenConnection()
        {
            bool succes = false;
            try
            {
                this.connection.Open();
                succes = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return succes;
        }

        public bool CloseConnection()
        {
            bool succes = false;
            try
            {
                this.connection.Close();
                succes = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return succes;
        }

        public string GetRFIDFromTramNumber(int tramNumber)
        {
            string sql = "SELECT RFID FROM TRAM WHERE number = :pTramNumber";
            OracleCommand com = new OracleCommand(sql, this.connection);
            com.Parameters.Add(new OracleParameter("pTramNumber", tramNumber));
            string rfid = "";
            try
            {
                this.OpenConnection();
                OracleDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    rfid = (reader["RFID"]).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.CloseConnection();
            }

            return rfid;
            
            //connection.Open();

            //string RFID = "";
            //try
            //{
            //    OracleCommand command = new OracleCommand("SELECT * FROM TRAM WHERE number = :pTramNumber");
            //    command.CommandType = CommandType.Text;
            //    command.Connection = connection;
            //    command.Parameters.Add(":pTramNumber", tramNumber);

            //    OracleDataReader reader = command.ExecuteReader();

            //    reader.Read();

            //    RFID = Convert.ToString(reader["RFID"]);
            //}
            //catch (Exception e)
            //{
            //    Debug.WriteLine(e.Message);
            //}
            //finally
            //{
            //    connection.Close();
            //}
            //return RFID;
        }

        public void ReserveSector(string RFID, int sectorNumber)
        {
            connection.Open();
            try
            {
                OracleCommand command = new OracleCommand("INSERT INTO RESERVATION (RFID, Sector_ID) VALUES (:pRFID, :pSectorID)");
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.Parameters.Add(":pRFID", RFID);
                command.Parameters.Add(":pSectorID", sectorNumber);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void VeranderTramStatus(string number, string status)
        {
            string sql = "UPDATE TRAM SET STATUS = :status WHERE TNUMBER = :number";
            OracleCommand com = new OracleCommand(sql, connection);
            com.Parameters.Add(new OracleParameter("status", status));
            com.Parameters.Add(new OracleParameter("number", number));
            try
            {
                this.OpenConnection();
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
