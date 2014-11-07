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
using TVSLibrary;

namespace TramVerdeelSysteem
{
    public partial class MainForm : Form
    {
        TVSLibrary.Database.DatabaseManager dbm = new TVSLibrary.Database.DatabaseManager();
        public List<Sector> AllSectors = new List<Sector>();
        public List<Track> AllTracks = new List<Track>();
        public List<Tram> AllTrams = new List<Tram>();

        public MainForm(User user)
        {5
            InitializeComponent();
            UpdatelbReservations();
        }

        public void UpdatelbReservations()
        {
            List<TVSLibrary.Reservation> reservations = dbm.GetReservations();

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
            dbm.RemoveReservation(dbm.GetRFIDFromTramNumber(tramNumber));
            UpdatelbReservations();
        }

        private void schoonmaakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cleaner cleaner = new Cleaner(1, "Henk");
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
            TVSLibrary.Database.DatabaseManager dbm = new TVSLibrary.Database.DatabaseManager();

            AllTracks = dbm.GetAllTracks();
            AllSectors = dbm.GetAllSectors();
            AllTrams = dbm.GetAllTrams();

            GenerateGUI();
        }

        private void GenerateGUI()
        {
            int locationX = 0;
            int locationY = 20;
            int maxHeight = 0;

            foreach(Track tk in AllTracks)
            {
                DataGridView DGV = new DataGridView();
                DGV.AllowUserToAddRows = false;
                DGV.ReadOnly = true;
                DGV.AllowUserToResizeRows = false;
                DGV.CellClick += DGV_CellClick;
                DGV.Width = 50;
                DGV.RowHeadersVisible = false;
                DGV.Location = new Point(locationX * 55 + 20 ,locationY);
                locationX++;
                if(locationX == 13)
                {
                    locationX = 0;
                    locationY += (maxHeight + 20);
                    maxHeight = 0;
                }
                DGV.ScrollBars = ScrollBars.None;
                DGV.Columns.Add(tk.Number.ToString(), tk.Number.ToString());
                //TODO CHECK SECTOR PER TRACK
                foreach(Sector sr in AllSectors)
                {
                    if(sr.Track.Number == tk.Number)
                    {
                        //if(sr.)
                        DGV.Rows.Add();
                    }
                }
                DGV.Height = (DGV.Rows.Count * 22 + 25);
                if(DGV.Height > maxHeight)
                {
                    maxHeight = DGV.Height;
                }

                DGV.ClearSelection();
                panel1.Controls.Add(DGV);
            }
        }

        void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DGV = (DataGridView) sender;
            DGV.ClearSelection();
        }
    }
}
