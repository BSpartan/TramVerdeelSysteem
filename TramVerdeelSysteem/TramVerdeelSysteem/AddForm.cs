using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVSLibrary;

namespace TramVerdeelSysteem
{
    public partial class AddTram: Form
    {
        int TrackNr;
        TVSLibrary.Database.DatabaseManager dbm = new TVSLibrary.Database.DatabaseManager();

        public AddTram()
        {
            InitializeComponent();
        }

        public AddTram(int trackNr)
        {
            InitializeComponent();
            TrackNr = trackNr;
            tbTrackNr.Text = TrackNr.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteTram_Click(object sender, EventArgs e)
        {
            
            if(TbTramNumber.Text != string.Empty)
            {
                string RFID = dbm.GetRFIDFromTramNumber(Convert.ToInt32(TbTramNumber.Text));
                Tram tram = new Tram(RFID);
                tram.GetTrack(Convert.ToInt32(tbTrackNr.Text));
                this.Close();
            }
        }

    }
}
