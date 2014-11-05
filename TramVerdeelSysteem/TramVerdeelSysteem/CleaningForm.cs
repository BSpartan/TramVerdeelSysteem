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
        public CleaningForm()
        {
            InitializeComponent();

            //List<TVSLibrary.CleaningList> cleaningList = TVSLibrary.Cleaner.GetCleaningList();

            //foreach(TVSLibrary.CleaningList cl in cleaningList)
            //{
            //    string[] row = new string[] { cl.TramId.ToString(), cl.Datum.ToString(), cl.Status.ToString() };
            //    dataGridView1.Rows.Add(row);
            //}

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Klaar";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DoneForm doneForm = new DoneForm(Convert.ToInt16(dataGridView1[0, e.RowIndex].Value));
                doneForm.Show();
            }
        }
    }
}
