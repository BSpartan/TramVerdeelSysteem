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
using TVSLibrary;

namespace TramVerdeelSysteem
{
    public partial class MainForm : Form
    {
        public List<Sector> AllSectors = new List<Sector>();
        public List<Track> AllTracks = new List<Track>();
        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdatelbReservations()
        {

        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            Reservation Reservation = new Reservation();
            Reservation.FormClosed += (Sender, args) => this.UpdatelbReservations();
            Reservation.Show();
        }

        private void schoonmaakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cleaner cleaner = new Cleaner(1,"Henk");
            CleaningForm clean = new CleaningForm(cleaner);
            clean.Show();
        }

        private void reparatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mechanic mechanic = new Mechanic(1, "Henk");
            RepairForm repair = new RepairForm(mechanic);
            repair.Show();
        }

        private void GetAllInformation()
        {

        }

        private void GenerateGUI()
        {
            foreach(Track tk in AllSectors)
            {

            }
        }
    }
}
