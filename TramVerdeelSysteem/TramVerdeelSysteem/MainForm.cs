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

        private int SelectedSector = 0;
        private int SelectedTrack = 0;
        private DataGridView SelectedDataGrid;

        public MainForm()
        {
            InitializeComponent();
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

        private void ToggleBlock(object sender, EventArgs e)
        {

            if (SelectedDataGrid[0, (SelectedSector - 1)].Style.BackColor == Color.DarkGray)
                SelectedDataGrid[0, (SelectedSector - 1)].Style.BackColor = Color.White;
            else
                SelectedDataGrid[0, (SelectedSector - 1)].Style.BackColor = Color.DarkGray;
 
            for (int i = 0; i < AllSectors.Count; i++)
            {
                if(AllSectors[i].Track.Number == SelectedTrack && AllSectors[i].Number == SelectedSector)
                {
                    AllSectors[i].ToggleBlocked();
                }
            }
        }

        private void AddTram(object sender, EventArgs e)
        {
            SelectedDataGrid[0, (SelectedSector - 1)].Style.BackColor = Color.DarkGray;
        }
        
        private void GetAllInformation()
        {
            TVSLibrary.Database.DatabaseManager dbm = new TVSLibrary.Database.DatabaseManager();

            AllTracks = dbm.GetAllTracks();
            AllSectors = dbm.GetAllSectors();
            AllTrams = dbm.GetAllTrams();

            //GenerateSectorInDatabase();
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
                DGV.Columns.Add(tk.Number.ToString(), tk.Number.ToString());

                foreach (Sector sr in AllSectors)
                {
                    if (sr.Track.Number == tk.Number)
                    {
                        string rowString = "";
                        if(sr.Tram != null)
                        {
                            rowString = sr.Tram.TramNr.ToString();
                        }
                        DGV.Rows.Add(rowString);
                    }
                }
                if (DGV.Rows.Count != 1)
                {
                    DGV.AllowUserToAddRows = false;
                    DGV.ReadOnly = true;
                    DGV.AllowUserToResizeRows = false;
                    DGV.CellClick += DGV_CellClick;
                    DGV.Width = 50;
                    DGV.RowHeadersVisible = false;
                    DGV.Location = new Point(locationX * 55 + 20 ,locationY);
                    locationX++;
                    DGV.ScrollBars = ScrollBars.None;                
                    DGV.Height = (DGV.Rows.Count * 22 + 25);
                    if(DGV.Height > maxHeight)
                    {
                        maxHeight = DGV.Height;
                    }

                    if (locationX == 13)
                    {
                        locationX = 0;
                        locationY += (maxHeight + 20);
                        maxHeight = 0;
                    }

                    DGV.MouseClick += DGV_MouseClick;

                    panel1.Controls.Add(DGV);
                    DGV.ClearSelection();
                    DGV.Rows[0].Cells[0].Selected = false;
                }
            }
        }

        void DGV_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                DataGridView DGV = (DataGridView)sender;

                int currentMouseOverRow = DGV.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    SelectedSector = (currentMouseOverRow + 1);
                    SelectedTrack = Convert.ToInt32(DGV.Columns[0].Name);
                    SelectedDataGrid = DGV;
                }

                ContextMenu.Show(DGV, new Point(e.X, e.Y));

            }
        }

        private void GenerateSectorInDatabase()
        {
            foreach (Track tk in AllTracks)
            {
                //WARNING!
                //dbm.GenerateSector(tk);
            }
        }

        void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DGV = (DataGridView) sender;
            DGV.ClearSelection();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdatelbReservations();
            GetAllInformation();
        }
    }
}
