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
using TVSLibrary;

namespace TramVerdeelSysteem
{
    public partial class TramStatus : Form
    {
        private DatabaseManager db;

        public TramStatus()
        {
            InitializeComponent();
            FillComboBox();
            this.db = new DatabaseManager();
            
        }

        private void FillComboBox()
        {
            foreach (Status s in (TVSLibrary.Status[])Enum.GetValues(typeof(Status)))
            {
                cbStatus.Items.Add(s);
            }
        }

        private void btnChangeStatus_Click_1(object sender, EventArgs e)
        {
            string tramnummer = tbStatusNumber.Text;
            string status = cbStatus.SelectedItem.ToString();

            db.VeranderTramStatus(tramnummer, status);

            tbStatusNumber.Clear();
        }

        private void btnCancelStatus_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
