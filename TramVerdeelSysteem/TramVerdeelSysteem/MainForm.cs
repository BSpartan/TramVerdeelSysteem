using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        public List<DataGridView> AllDGV = new List<DataGridView>();
        private List<Tram> SimulationList;

        private int SelectedSector = 0;
        private int SelectedTrack = 0;
        private DataGridView SelectedDataGrid;


        public MainForm(User user)
        {
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

        private void ToggleBlock(object sender, EventArgs e)
        {
            for (int i = 0; i < AllSectors.Count; i++)
            {
                if (AllSectors[i].Track.Number == SelectedTrack && AllSectors[i].Number <= SelectedSector)
                {
                    if (AllSectors[i].Track.Length > SelectedSector - 1)
                    {
                            if (SelectedDataGrid[0, (AllSectors[i].Number - 1)].Style.BackColor == Color.DarkGray)
                                SelectedDataGrid[0, (AllSectors[i].Number - 1)].Style.BackColor = Color.White;
                            else
                                SelectedDataGrid[0, (AllSectors[i].Number - 1)].Style.BackColor = Color.DarkGray;
                            AllSectors[i].ToggleBlocked();
                    }
                    else
                    {
                        if (SelectedDataGrid[0, (AllSectors[i].Number - 1)].Style.BackColor == Color.DarkGray)
                            SelectedDataGrid[0, (AllSectors[i].Number - 1)].Style.BackColor = Color.White;
                        else
                            SelectedDataGrid[0, (AllSectors[i].Number - 1)].Style.BackColor = Color.DarkGray;
                        AllSectors[i].ToggleBlocked();
                    }
                }
            }
        }

        private void AddTram(object sender, EventArgs e)
        {
            AddTram addTram = new AddTram(SelectedTrack);
            addTram.Show();
            addTram.FormClosed += new FormClosedEventHandler(UpdateMainForm);
        }

        private void DeleteTram(object sender, EventArgs e)
        {
            MessageBox.Show("Weet je zeker dat je de tram op spoor: " + SelectedTrack.ToString() + ", sector: " + SelectedSector.ToString() + " wilt verwijderen.", "Let op!", MessageBoxButtons.YesNo);

        }

        private void MoveTram(object sender, EventArgs e)
        {
            if (SelectedDataGrid[0, (SelectedSector - 1)].Style.BackColor == Color.Aquamarine)
                SelectedDataGrid[0, (SelectedSector - 1)].Style.BackColor = Color.White;
            else
                SelectedDataGrid[0, (SelectedSector - 1)].Style.BackColor = Color.Aquamarine;
        }

        private void ToCleaning(object sender, EventArgs e)
        {
        }

        private void ToRepair(object sender, EventArgs e)
        {

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

            foreach (Track tk in AllTracks)
            {
                DataGridView DGV = new DataGridView();
                DGV.Columns.Add(tk.Number.ToString(), tk.Number.ToString());

                foreach (Sector sr in AllSectors)
                {
                    if (sr.Track.Number == tk.Number)
                    {
                        string rowString = "";
                        if (sr.Tram != null)
                        {
                            rowString = sr.Tram.TramNr.ToString();
                        }
                        DGV.Rows.Add(rowString);
                    }
                }

                if (DGV.Rows.Count != 1)
                {
                    //Settings
                    DGV.AllowUserToAddRows = false;
                    DGV.ReadOnly = true;
                    DGV.AllowUserToResizeRows = false;
                    DGV.CellClick += DGV_CellClick;
                    DGV.Width = 50;
                    DGV.RowHeadersVisible = false;
                    DGV.Location = new Point(locationX * 55 + 20, locationY);
                    locationX++;
                    DGV.ScrollBars = ScrollBars.None;
                    DGV.Height = (DGV.Rows.Count * 22 + 25);
                    if (DGV.Height > maxHeight)
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

                    AllDGV.Add(DGV);
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
                    if (DGV[0, SelectedSector - 1].Value == string.Empty)
                    {
                        Toevoegen.Enabled = true;
                        verwijderenToolStripMenuItem.Enabled = false;
                        verplaatsenToolStripMenuItem.Enabled = false;
                        ToCleaningItem.Enabled = false;
                        ToRepairItem.Enabled = false;
                    }
                    else
                    {
                        Toevoegen.Enabled = false;
                        verwijderenToolStripMenuItem.Enabled = true;
                        verplaatsenToolStripMenuItem.Enabled = true;
                        ToCleaningItem.Enabled = true;
                        ToRepairItem.Enabled = true;
                    }
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
            DataGridView DGV = (DataGridView)sender;
            DGV.ClearSelection();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdatelbReservations();
            GetAllInformation();
        }

        public void BtnSimulation_Click(Object sender, EventArgs e)
        {
            btnSimulation.Enabled = false;
            btnEndSimulation.Enabled = true;
            ContextMenu.Enabled = false;
            menuStrip1.Enabled = false;
            foreach (Tram t in AllTrams)
                t.SetSector(null);

            foreach (Sector s in AllSectors)
                s.SetTram(null);

            UpdateMainForm();

            SimulationList = new List<Tram>();
            foreach (Tram t in AllTrams)
                SimulationList.Add(t);

            tSimulation.Enabled = true;
            
        }

        public void UpdateMainForm()
        {
            foreach (DataGridView DGV in AllDGV)
            {
                DGV.Rows.Clear();

                foreach (Sector sr in AllSectors)
                {
                    if (sr.Track.Number == Convert.ToInt32(DGV.Columns[0].Name))
                    {
                        string rowString = "";
                        if (sr.Tram != null)
                        {
                            rowString = sr.Tram.TramNr.ToString();
                        }
                        DGV.Rows.Add(rowString);
                    }
                }

                DGV.ClearSelection();
                DGV.Rows[0].Cells[0].Selected = false;
            }
        }

        public void UpdateMainForm(object sender, FormClosedEventArgs e)
        {
            foreach (DataGridView DGV in AllDGV)
            {
                DGV.Rows.Clear();

                foreach (Sector sr in AllSectors)
                {
                    if (sr.Track.Number == Convert.ToInt32(DGV.Columns[0].Name))
                    {
                        string rowString = "";
                        if (sr.Tram != null)
                        {
                            rowString = sr.Tram.TramNr.ToString();
                        }
                        DGV.Rows.Add(rowString);
                    }
                }

                DGV.ClearSelection();
                DGV.Rows[0].Cells[0].Selected = false;
            }
        }

        private void veranderStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TramStatus status = new TramStatus();
            status.Show();
        }

        private void tSimulation_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            Tram next;
            Sector tempSector;
            if (SimulationList.Count > 0)
            {
                int Trams = SimulationList.Count();
                next = SimulationList.ElementAt(random.Next(0, (Trams - 1)));
                SimulationList.Remove(next);
                tempSector = next.SortTram(AllSectors);

                for (int i = 0; i < AllSectors.Count; i++)
                {
                    if (AllSectors[i].Equals(tempSector))
                    {
                        AllSectors[i].SetTram(next);
                    }
                }

                UpdateMainForm();
                }
        }

        private void btnEndSimulation_Click(object sender, EventArgs e)
        {
            tSimulation.Enabled = false;
            btnSimulation.Enabled = true;
            btnEndSimulation.Enabled = false;
            ContextMenu.Enabled = true;
            menuStrip1.Enabled = true;

            GetAllInformation();
            UpdateMainForm();
        }
    }
}
