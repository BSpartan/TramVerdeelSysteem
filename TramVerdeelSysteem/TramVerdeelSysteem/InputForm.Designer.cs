namespace TramVerdeelSysteem
{
    partial class InputForm
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
            this.lbTrack = new System.Windows.Forms.Label();
            this.lbHistory = new System.Windows.Forms.Label();
            this.pnlTrack = new System.Windows.Forms.Panel();
            this.lbTrackInput = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lbInput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTechAssistFalse = new System.Windows.Forms.RadioButton();
            this.rbTechAssistTrue = new System.Windows.Forms.RadioButton();
            this.cbCleaning = new System.Windows.Forms.CheckBox();
            this.btnInputDone = new System.Windows.Forms.Button();
            this.tbHistory = new System.Windows.Forms.TextBox();
            this.pnlTrack.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTrack
            // 
            this.lbTrack.AutoSize = true;
            this.lbTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrack.Location = new System.Drawing.Point(427, 269);
            this.lbTrack.Name = "lbTrack";
            this.lbTrack.Size = new System.Drawing.Size(108, 39);
            this.lbTrack.TabIndex = 0;
            this.lbTrack.Text = "Spoor";
            // 
            // lbHistory
            // 
            this.lbHistory.AutoSize = true;
            this.lbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistory.Location = new System.Drawing.Point(749, 36);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(133, 39);
            this.lbHistory.TabIndex = 1;
            this.lbHistory.Text = "Historie";
            // 
            // pnlTrack
            // 
            this.pnlTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrack.Controls.Add(this.lbTrackInput);
            this.pnlTrack.Location = new System.Drawing.Point(368, 311);
            this.pnlTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTrack.Name = "pnlTrack";
            this.pnlTrack.Size = new System.Drawing.Size(230, 115);
            this.pnlTrack.TabIndex = 2;
            // 
            // lbTrackInput
            // 
            this.lbTrackInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrackInput.Location = new System.Drawing.Point(3, 23);
            this.lbTrackInput.Name = "lbTrackInput";
            this.lbTrackInput.Size = new System.Drawing.Size(221, 39);
            this.lbTrackInput.TabIndex = 19;
            this.lbTrackInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInput
            // 
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.lbInput);
            this.pnlInput.Location = new System.Drawing.Point(344, 28);
            this.pnlInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(254, 115);
            this.pnlInput.TabIndex = 3;
            // 
            // lbInput
            // 
            this.lbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput.Location = new System.Drawing.Point(3, 37);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(251, 39);
            this.lbInput.TabIndex = 20;
            this.lbInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTechAssistFalse);
            this.groupBox1.Controls.Add(this.rbTechAssistTrue);
            this.groupBox1.Location = new System.Drawing.Point(15, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(229, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Technische assistentie nodig";
            // 
            // rbTechAssistFalse
            // 
            this.rbTechAssistFalse.AutoSize = true;
            this.rbTechAssistFalse.Checked = true;
            this.rbTechAssistFalse.Location = new System.Drawing.Point(19, 86);
            this.rbTechAssistFalse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTechAssistFalse.Name = "rbTechAssistFalse";
            this.rbTechAssistFalse.Size = new System.Drawing.Size(55, 21);
            this.rbTechAssistFalse.TabIndex = 1;
            this.rbTechAssistFalse.TabStop = true;
            this.rbTechAssistFalse.Text = "Nee";
            this.rbTechAssistFalse.UseVisualStyleBackColor = true;
            // 
            // rbTechAssistTrue
            // 
            this.rbTechAssistTrue.AutoSize = true;
            this.rbTechAssistTrue.Location = new System.Drawing.Point(19, 46);
            this.rbTechAssistTrue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTechAssistTrue.Name = "rbTechAssistTrue";
            this.rbTechAssistTrue.Size = new System.Drawing.Size(44, 21);
            this.rbTechAssistTrue.TabIndex = 0;
            this.rbTechAssistTrue.Text = "Ja";
            this.rbTechAssistTrue.UseVisualStyleBackColor = true;
            // 
            // cbCleaning
            // 
            this.cbCleaning.AutoSize = true;
            this.cbCleaning.Location = new System.Drawing.Point(33, 207);
            this.cbCleaning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCleaning.Name = "cbCleaning";
            this.cbCleaning.Size = new System.Drawing.Size(151, 21);
            this.cbCleaning.TabIndex = 6;
            this.cbCleaning.Text = "Schoonmaak nodig";
            this.cbCleaning.UseVisualStyleBackColor = true;
            // 
            // btnInputDone
            // 
            this.btnInputDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputDone.Location = new System.Drawing.Point(289, 176);
            this.btnInputDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInputDone.Name = "btnInputDone";
            this.btnInputDone.Size = new System.Drawing.Size(356, 78);
            this.btnInputDone.TabIndex = 18;
            this.btnInputDone.Text = "Bevestig";
            this.btnInputDone.UseVisualStyleBackColor = true;
            this.btnInputDone.Click += new System.EventHandler(this.btnInputDone_Click);
            // 
            // tbHistory
            // 
            this.tbHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbHistory.Location = new System.Drawing.Point(709, 90);
            this.tbHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHistory.Multiline = true;
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.Size = new System.Drawing.Size(215, 137);
            this.tbHistory.TabIndex = 19;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 448);
            this.Controls.Add(this.tbHistory);
            this.Controls.Add(this.btnInputDone);
            this.Controls.Add(this.cbCleaning);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlTrack);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.lbTrack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InputForm";
            this.Text = "Tram nummer invoeren";
            this.pnlTrack.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTrack;
        private System.Windows.Forms.Label lbHistory;
        private System.Windows.Forms.Panel pnlTrack;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTechAssistFalse;
        private System.Windows.Forms.RadioButton rbTechAssistTrue;
        private System.Windows.Forms.CheckBox cbCleaning;
        private System.Windows.Forms.Button btnInputDone;
        private System.Windows.Forms.Label lbTrackInput;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox tbHistory;
    }
}