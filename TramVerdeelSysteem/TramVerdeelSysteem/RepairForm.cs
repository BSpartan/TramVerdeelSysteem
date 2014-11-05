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
    public partial class RepairForm : Form
    {
        public RepairForm()
        {
            InitializeComponent();
            string[] row = new string[] { "13", "Product 1", "1000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "25", "Product 2", "2000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "37", "Product 3", "3000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "49", "Product 4", "4000" };
            dataGridView1.Rows.Add(row);

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
                RepairDoneForm repairForm = new RepairDoneForm(Convert.ToInt16(dataGridView1[0, e.RowIndex].Value));
                repairForm.Show();
            }
        }
    }
}
