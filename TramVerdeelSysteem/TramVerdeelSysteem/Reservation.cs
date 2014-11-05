using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVSLibrary.Database;

namespace TramVerdeelSysteem
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void btnReserveSector_Click(object sender, EventArgs e)
        {

            DatabaseManager.ReserveSector(dtbReservationTramNumber, tbReservationSectorNumber)

        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
