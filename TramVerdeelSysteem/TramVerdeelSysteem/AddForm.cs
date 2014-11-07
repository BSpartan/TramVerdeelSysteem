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
    public partial class AddTram: Form
    {
        int TrackNr;

        public AddTram()
        {
            InitializeComponent();
        }

        public AddTram(int trackNr)
        {
            InitializeComponent();
            TrackNr = trackNr;
            textBox2.Text = TrackNr.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
