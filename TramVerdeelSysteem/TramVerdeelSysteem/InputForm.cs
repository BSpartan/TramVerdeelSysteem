// Input form code
namespace TramVerdeelSysteem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Phidgets;
    using Phidgets.Events;
    using TVSLibrary;

    /// <summary>
    /// Code behind the form
    /// </summary>
    public partial class InputForm : Form
    {
        private RFID rfid;
        private Tram tram;

        /// <summary>
        /// Screen initialization and looking for a RFID scanner
        /// </summary>
        public InputForm()
        {
            InitializeComponent();

            rfid = new RFID();

            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);

            this.openCmdLine(rfid);
        }

        /// <summary>
        /// sets the scanner on non active so it can be used by another programm
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;
        }

        /// <summary>
        /// Inserts the tram into the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInputDone_Click(object sender, EventArgs e)
        {
            this.tram = new Tram(lbInput.Text);
            this.tram.AddMaintenace(tram, cbCleaning.Checked, rbTechAssistTrue.Checked);
            lbTrackInput.Text = tram.GetTrack();
            tbHistory.Text += lbInput.Text + "-" + lbTrackInput.Text + "\r\n";
        }

        /// <summary>
        /// Sets the RFID scanner so it can be used.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;
        }

        /// <summary>
        /// Reads the tag from the RFID TAG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rfid_Tag(object sender, TagEventArgs e)
        {
            lbInput.Text = e.Tag;
        }

        /// <summary>
        /// Empties the label when the tag is lost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rfid_TagLost(object sender, TagEventArgs e)
        {
            lbInput.Text = string.Empty;
        }

        /// <summary>
        /// opens the phidgets command line
        /// </summary>
        /// <param name="p">phidgets device</param>
        private void openCmdLine(Phidget p)
        {
            this.openCmdLine(p, null);
        }

        /// <summary>
        /// Sets the scanner ready for use
        /// </summary>
        /// <param name="p">phidgets device</param>
        /// <param name="pass"></param>
        private void openCmdLine(Phidget p, String pass)
        {
            int serial = -1;
            String logFile = null;
            int port = 5001;
            String host = null;
            bool remote = false, remoteIP = false;
            string[] args = Environment.GetCommandLineArgs();
            String appName = args[0];

            try

            { 
                // Parse the flags
                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                        switch (args[i].Remove(0, 1).ToLower())
                        {
                            case "l":
                                logFile = (args[++i]);
                                break;
                            case "n":
                                serial = int.Parse(args[++i]);
                                break;
                            case "r":
                                remote = true;
                                break;
                            case "s":
                                remote = true;
                                host = args[++i];
                                break;
                            case "p":
                                pass = args[++i];
                                break;
                            case "i":
                                remoteIP = true;
                                host = args[++i];
                                if (host.Contains(":"))
                                {
                                    port = int.Parse(host.Split(':')[1]);
                                    host = host.Split(':')[0];
                                }
                                break;
                            default:
                                goto usage;
                        }
                    else
                        goto usage;
                }
                if (logFile != null)
                    Phidget.enableLogging(Phidget.LogLevel.PHIDGET_LOG_INFO, logFile);
                if (remoteIP)
                    p.open(serial, host, port, pass);
                else if (remote)
                    p.open(serial, host, pass);
                else
                    p.open(serial);
                return;
                // success
            }
            catch {
            }
        usage:
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Invalid Command line arguments." + Environment.NewLine);
            sb.AppendLine("Usage: " + appName + " [Flags...]");
            sb.AppendLine("Flags:\t-n   serialNumber\tSerial Number, omit for any serial");
            sb.AppendLine("\t-l   logFile\tEnable phidget21 logging to logFile.");
            sb.AppendLine("\t-r\t\tOpen remotely");
            sb.AppendLine("\t-s   serverID\tServer ID, omit for any server");
            sb.AppendLine("\t-i   ipAddress:port\tIp Address and Port. Port is optional, defaults to 5001");
            sb.AppendLine("\t-p   password\tPassword, omit for no password" + Environment.NewLine);
            sb.AppendLine("Examples: ");
            sb.AppendLine(appName + " -n 50098");
            sb.AppendLine(appName + " -r");
            sb.AppendLine(appName + " -s myphidgetserver");
            sb.AppendLine(appName + " -n 45670 -i 127.0.0.1:5001 -p paswrd");
            MessageBox.Show(sb.ToString(), "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.Exit();
        }
    }
}
