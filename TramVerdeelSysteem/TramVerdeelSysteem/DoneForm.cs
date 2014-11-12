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
    public partial class DoneForm : Form
    {

        bool isCleaning;
        TVSLibrary.Cleaner cleaner;
        TVSLibrary.Mechanic mechanic;
        private int RFID;
        private int ID;

        public DoneForm(Cleaner cleaner, int id, int tramNumber, bool isCleaning)
        {
            InitializeComponent();
            this.cleaner = cleaner;
            this.isCleaning = isCleaning;

            ID = id;
            RFID = tramNumber;
            tbTramNumber.Text = tramNumber.ToString();
            dtpDate.Value = DateTime.Now;
        }

        public DoneForm(Mechanic mechanic, int id, int tramNumber, bool isCleaning)
        {
            InitializeComponent();
            this.mechanic = mechanic;
            this.isCleaning = isCleaning;

            ID = id;
            RFID = tramNumber;
            tbTramNumber.Text = tramNumber.ToString();
            dtpDate.Value = DateTime.Now;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(isCleaning)
            {
                cleaner.SetService(ID);
                this.Close();
            }
            else
            {
                mechanic.SetService(ID);
                this.Close();
            }
        }
    }
}
