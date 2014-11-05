namespace TramVerdeelSysteem
{
    partial class DoneForm
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
            this.lbTramNumber = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTramNumber = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTramNumber
            // 
            this.lbTramNumber.AutoSize = true;
            this.lbTramNumber.Location = new System.Drawing.Point(23, 26);
            this.lbTramNumber.Name = "lbTramNumber";
            this.lbTramNumber.Size = new System.Drawing.Size(92, 17);
            this.lbTramNumber.TabIndex = 0;
            this.lbTramNumber.Text = "Tramnummer";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(24, 95);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(48, 17);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Status";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(24, 170);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(49, 17);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Datum";
            this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notitie";
            // 
            // tbTramNumber
            // 
            this.tbTramNumber.Location = new System.Drawing.Point(27, 46);
            this.tbTramNumber.Name = "tbTramNumber";
            this.tbTramNumber.ReadOnly = true;
            this.tbTramNumber.Size = new System.Drawing.Size(520, 22);
            this.tbTramNumber.TabIndex = 4;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(27, 115);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(520, 22);
            this.tbStatus.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-mm-yyyy H:mm";
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(26, 190);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(521, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(27, 264);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(520, 96);
            this.rtbNote.TabIndex = 7;
            this.rtbNote.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Klaar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RepairDoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbTramNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbTramNumber);
            this.Name = "RepairDoneForm";
            this.Text = "RepairDoneForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTramNumber;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTramNumber;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}