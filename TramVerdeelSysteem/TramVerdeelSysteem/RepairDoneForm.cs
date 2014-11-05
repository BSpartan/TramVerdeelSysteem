using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TramVerdeelSysteem
{
    public partial class RepairDoneForm : Form
    {
        public RepairDoneForm(int tramNumber)
        {
            InitializeComponent();
            tbTramNumber.Text = tramNumber.ToString();
            dtpDate.Value = DateTime.Now;
        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }
    }
}
