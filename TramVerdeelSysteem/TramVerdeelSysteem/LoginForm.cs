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
    public partial class LoginForm : Form
    {
        DatabaseManager dbm = new DatabaseManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(tbIDNumber.Text == String.Empty) && !(tbPassword.Text == String.Empty))
            {
                int PersonID = 0;
                string password = tbPassword.Text;
                try
                {
                    PersonID = Convert.ToInt16(tbIDNumber.Text);
                }
                catch
                {
                    MessageBox.Show("Voer AUB een geldig ID in");
                    return;
                }
                //if (dbm.CheckPassword(PersonID, password))
                if(true)
                {
                    MainForm mainForm = new MainForm(dbm.GetUserData(PersonID));
                    mainForm.FormClosed += (Sender, args) => this.Show();
                    this.Hide();
                    mainForm.Show();
                }
            }
        }

        private void tbIDNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
