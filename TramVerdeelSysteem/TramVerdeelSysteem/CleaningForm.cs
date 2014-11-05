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
    public partial class CleaningForm : Form
    {
        TVSLibrary.Cleaner cleaner;

        public CleaningForm(Cleaner cleaner)
        {
            InitializeComponent();
            this.cleaner = cleaner;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Klaar";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            LoadCleaningData();
        }

        public void LoadCleaningData()
        {
            dataGridView1.Rows.Clear();
            List<TVSLibrary.RepairCleanList> cleaningList = cleaner.GetCleaningList();

            foreach (TVSLibrary.RepairCleanList cl in cleaningList)
            {
                string[] row = new string[] {cl.id.ToString(), cl.RFID.ToString(), cl.dateTime.ToString(), cl.status.ToString() };
                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DoneForm doneForm = new DoneForm(cleaner, Convert.ToInt16(dataGridView1[0, e.RowIndex].Value), Convert.ToInt16(dataGridView1[1, e.RowIndex].Value), true);
                doneForm.Show();
                doneForm.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            }
        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCleaningData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCleaningData();
        }

    }
}
