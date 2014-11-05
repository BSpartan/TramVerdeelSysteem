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
            this.btnReserveSector = new System.Windows.Forms.Button();
            this.tbReservationSectorNumber = new System.Windows.Forms.TextBox();
            this.lbReservationSector = new System.Windows.Forms.Label();
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
            // btnReserveSector
            // 
            this.btnReserveSector.Location = new System.Drawing.Point(11, 110);
            this.btnReserveSector.Margin = new System.Windows.Forms.Padding(2);
            this.btnReserveSector.Name = "btnReserveSector";
            this.btnReserveSector.Size = new System.Drawing.Size(80, 30);
            this.btnReserveSector.TabIndex = 3;
            this.btnReserveSector.Text = "Reserveren";
            this.btnReserveSector.UseVisualStyleBackColor = true;
            this.btnReserveSector.Click += new System.EventHandler(this.btnReserveSector_Click);
            // 
            // tbReservationSectorNumber
            // 
            this.tbReservationSectorNumber.Location = new System.Drawing.Point(95, 58);
            this.tbReservationSectorNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbReservationSectorNumber.Name = "tbReservationSectorNumber";
            this.tbReservationSectorNumber.Size = new System.Drawing.Size(82, 20);
            this.tbReservationSectorNumber.TabIndex = 4;
            // 
            // lbReservationSector
            // 
            this.lbReservationSector.AutoSize = true;
            this.lbReservationSector.Location = new System.Drawing.Point(92, 30);
            this.lbReservationSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReservationSector.Name = "lbReservationSector";
            this.lbReservationSector.Size = new System.Drawing.Size(71, 13);
            this.lbReservationSector.TabIndex = 5;
            this.lbReservationSector.Text = "Tram nummer";
            this.lbReservationSector.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Controls.Add(this.lbReservationSector);
            this.Controls.Add(this.tbReservationSectorNumber);
            this.Controls.Add(this.btnReserveSector);
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
        private System.Windows.Forms.Button btnReserveSector;
        private System.Windows.Forms.TextBox tbReservationSectorNumber;
        private System.Windows.Forms.Label lbReservationSector;
        private System.Windows.Forms.CheckBox cbReperation;
    }
}