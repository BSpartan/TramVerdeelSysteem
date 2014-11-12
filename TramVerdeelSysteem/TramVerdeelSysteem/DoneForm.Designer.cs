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
            this.lbDate = new System.Windows.Forms.Label();
            this.tbTramNumber = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTramNumber
            // 
            this.lbTramNumber.AutoSize = true;
            this.lbTramNumber.Location = new System.Drawing.Point(23, 26);
            this.lbTramNumber.Name = "lbTramNumber";
            this.lbTramNumber.Size = new System.Drawing.Size(88, 16);
            this.lbTramNumber.TabIndex = 0;
            this.lbTramNumber.Text = "Tramnummer";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(25, 100);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(47, 16);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Datum";
            // 
            // tbTramNumber
            // 
            this.tbTramNumber.Location = new System.Drawing.Point(27, 46);
            this.tbTramNumber.Name = "tbTramNumber";
            this.tbTramNumber.ReadOnly = true;
            this.tbTramNumber.Size = new System.Drawing.Size(520, 22);
            this.tbTramNumber.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-mm-yyyy H:mm";
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(27, 120);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(521, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Klaar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // DoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbTramNumber);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTramNumber);
            this.Name = "DoneForm";
            this.Text = "Tram log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTramNumber;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbTramNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}