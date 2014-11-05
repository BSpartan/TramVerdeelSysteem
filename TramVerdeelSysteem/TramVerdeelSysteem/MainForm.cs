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
    public partial class MainForm : Form
    {
        public List<Track> AllTracks;
        public List<Sector> AllSectors;
        public TVSLibrary.Remise Havenstraat;

        public MainForm()
        {
            InitializeComponent();
            List<Track> AllTracks = new List<Track>();
            List<Sector> AllSectors = new List<Sector>();
            Havenstraat = new Remise("Havenstraat");

            Track t1 = new Track(5, 30, Havenstraat);
            Track t2 = new Track(5, 31, Havenstraat);
            Track t3 = new Track(5, 32, Havenstraat);

            Sector s1 = new Sector(1, 1, t1);
            Sector s2 = new Sector(2, 2, t1);
            Sector s3 = new Sector(3, 3, t1);
            Sector s4 = new Sector(4, 1, t2);
            Sector s5 = new Sector(5, 2, t2);
            Sector s6 = new Sector(6, 1, t3);

            AllTracks.Add(t1);
            AllTracks.Add(t2);
            AllTracks.Add(t3);

            AllSectors.Add(s1);
            AllSectors.Add(s2);
            AllSectors.Add(s3);
            AllSectors.Add(s4);
            AllSectors.Add(s5);
            AllSectors.Add(s6);
        }
    }
}
