namespace TramVerdeelSysteem
{
    partial class TramStatus
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
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnCancelStatus = new System.Windows.Forms.Button();
            this.tbStatusNumber = new System.Windows.Forms.TextBox();
            this.lbStatusNumber = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(15, 209);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(106, 37);
            this.btnChangeStatus.TabIndex = 7;
            this.btnChangeStatus.Text = "Wijzigen";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click_1);
            // 
            // btnCancelStatus
            // 
            this.btnCancelStatus.Location = new System.Drawing.Point(127, 209);
            this.btnCancelStatus.Name = "btnCancelStatus";
            this.btnCancelStatus.Size = new System.Drawing.Size(106, 37);
            this.btnCancelStatus.TabIndex = 6;
            this.btnCancelStatus.Text = "Annuleren";
            this.btnCancelStatus.UseVisualStyleBackColor = true;
            this.btnCancelStatus.Click += new System.EventHandler(this.btnCancelStatus_Click_1);
            // 
            // tbStatusNumber
            // 
            this.tbStatusNumber.Location = new System.Drawing.Point(12, 146);
            this.tbStatusNumber.Name = "tbStatusNumber";
            this.tbStatusNumber.Size = new System.Drawing.Size(344, 22);
            this.tbStatusNumber.TabIndex = 5;
            // 
            // lbStatusNumber
            // 
            this.lbStatusNumber.AutoSize = true;
            this.lbStatusNumber.Location = new System.Drawing.Point(12, 111);
            this.lbStatusNumber.Name = "lbStatusNumber";
            this.lbStatusNumber.Size = new System.Drawing.Size(96, 17);
            this.lbStatusNumber.TabIndex = 4;
            this.lbStatusNumber.Text = "Tram nummer";
            this.lbStatusNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(9, 19);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(48, 17);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Status";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(15, 50);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(341, 24);
            this.cbStatus.TabIndex = 9;
            // 
            // TramStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 267);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.btnCancelStatus);
            this.Controls.Add(this.tbStatusNumber);
            this.Controls.Add(this.lbStatusNumber);
            this.Name = "TramStatus";
            this.Text = "Tram status wijzigen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnCancelStatus;
        private System.Windows.Forms.TextBox tbStatusNumber;
        private System.Windows.Forms.Label lbStatusNumber;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}