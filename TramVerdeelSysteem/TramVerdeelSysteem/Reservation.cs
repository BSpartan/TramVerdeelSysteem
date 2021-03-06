﻿using System;
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
    public partial class Reservation : Form
    {
        TVSLibrary.Database.DatabaseManager dbm = new TVSLibrary.Database.DatabaseManager();
        public Reservation()
        {
            InitializeComponent();
        }

        private void btnReserveSector_Click(object sender, EventArgs e)
        {

            string RFID = "";
            int trackID = 0;
            bool succes = true;

            try
            {
                trackID = dbm.GetTrackIDFromNumber(Convert.ToInt16(tbReservationTrackNumber.Text));
            }
            catch
            {
                MessageBox.Show("Voer AUB een geldig spoornummer in.");
                succes = false;
            }

            try
            {
                RFID = dbm.GetRFIDFromTramNumber(Convert.ToInt16(tbReservationTramNumber.Text));
            }
            catch
            {
                MessageBox.Show("Voer AUB een geldig tramnummer in.");
                succes = false;
            }

            if (succes)
            {
                dbm.ReserveTrack(RFID, trackID);
                this.Close();
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
