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
    public partial class TramStatus : Form
    {
        public TramStatus()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            foreach (Status s in (TVSLibrary.Status[]) Enum.GetValues(typeof(Status)))
            {
                cbStatus.Items.Add(s);
            }
        }

        private void btnCancelStatus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            string tramnummer = tbStatusNumber.Text;

        }
    }
}
