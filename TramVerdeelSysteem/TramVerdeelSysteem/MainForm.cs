using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using TVSLibrary.Database;

namespace TramVerdeelSysteem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdatelbReservations();
        }

        public void UpdatelbReservations()
        {
            List<TVSLibrary.Reservation> reservations = DatabaseManager.GetReservations();

            foreach (TVSLibrary.Reservation reservation in reservations)
            {
                lbReservations.Items.Add(reservation.ToString());
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            Reservation Reservation = new Reservation();
            Reservation.FormClosed += (Sender, args) => this.UpdatelbReservations();
            Reservation.Show();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            int tramNumber = Convert.ToInt16(lbReservations.SelectedItem.ToString().Remove(lbReservations.SelectedItem.ToString().IndexOf("-")).Trim());
            DatabaseManager.RemoveReservation(DatabaseManager.GetRFIDFromTramNumber(tramNumber));
            UpdatelbReservations();
        }
    }
}
