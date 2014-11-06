namespace TramVerdeelSysteem
{
    partial class Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbReservationTram = new System.Windows.Forms.Label();
            this.tbReservationTramNumber = new System.Windows.Forms.TextBox();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.btnReserveTram = new System.Windows.Forms.Button();
            this.tbReservationTrackNumber = new System.Windows.Forms.TextBox();
            this.lbReservationTrack = new System.Windows.Forms.Label();
            this.cbReperation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbReservationTram
            // 
            this.lbReservationTram.AutoSize = true;
            this.lbReservationTram.Location = new System.Drawing.Point(9, 30);
            this.lbReservationTram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReservationTram.Name = "lbReservationTram";
            this.lbReservationTram.Size = new System.Drawing.Size(71, 13);
            this.lbReservationTram.TabIndex = 0;
            this.lbReservationTram.Text = "Tram nummer";
            this.lbReservationTram.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbReservationTramNumber
            // 
            this.tbReservationTramNumber.Location = new System.Drawing.Point(9, 58);
            this.tbReservationTramNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbReservationTramNumber.Name = "tbReservationTramNumber";
            this.tbReservationTramNumber.Size = new System.Drawing.Size(82, 20);
            this.tbReservationTramNumber.TabIndex = 1;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Location = new System.Drawing.Point(95, 110);
            this.btnCancelReservation.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(80, 30);
            this.btnCancelReservation.TabIndex = 2;
            this.btnCancelReservation.Text = "Annuleren";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // btnReserveTram
            // 
            this.btnReserveTram.Location = new System.Drawing.Point(11, 110);
            this.btnReserveTram.Margin = new System.Windows.Forms.Padding(2);
            this.btnReserveTram.Name = "btnReserveTram";
            this.btnReserveTram.Size = new System.Drawing.Size(80, 30);
            this.btnReserveTram.TabIndex = 3;
            this.btnReserveTram.Text = "Reserveren";
            this.btnReserveTram.UseVisualStyleBackColor = true;
            this.btnReserveTram.Click += new System.EventHandler(this.btnReserveSector_Click);
            // 
            // tbReservationTrackNumber
            // 
            this.tbReservationTrackNumber.Location = new System.Drawing.Point(95, 58);
            this.tbReservationTrackNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbReservationTrackNumber.Name = "tbReservationTrackNumber";
            this.tbReservationTrackNumber.Size = new System.Drawing.Size(82, 20);
            this.tbReservationTrackNumber.TabIndex = 4;
            // 
            // lbReservationTrack
            // 
            this.lbReservationTrack.AutoSize = true;
            this.lbReservationTrack.Location = new System.Drawing.Point(92, 30);
            this.lbReservationTrack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReservationTrack.Name = "lbReservationTrack";
            this.lbReservationTrack.Size = new System.Drawing.Size(75, 13);
            this.lbReservationTrack.TabIndex = 5;
            this.lbReservationTrack.Text = "Track nummer";
            this.lbReservationTrack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbReperation
            // 
            this.cbReperation.AutoSize = true;
            this.cbReperation.Location = new System.Drawing.Point(9, 88);
            this.cbReperation.Name = "cbReperation";
            this.cbReperation.Size = new System.Drawing.Size(72, 17);
            this.cbReperation.TabIndex = 6;
            this.cbReperation.Text = "Reparatie";
            this.cbReperation.UseVisualStyleBackColor = true;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 161);
            this.Controls.Add(this.cbReperation);
            this.Controls.Add(this.lbReservationTrack);
            this.Controls.Add(this.tbReservationTrackNumber);
            this.Controls.Add(this.btnReserveTram);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.tbReservationTramNumber);
            this.Controls.Add(this.lbReservationTram);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reservation";
            this.Text = "Reserveren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReservationTram;
        private System.Windows.Forms.TextBox tbReservationTramNumber;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnReserveTram;
        private System.Windows.Forms.TextBox tbReservationTrackNumber;
        private System.Windows.Forms.Label lbReservationTrack;
        private System.Windows.Forms.CheckBox cbReperation;
    }
}