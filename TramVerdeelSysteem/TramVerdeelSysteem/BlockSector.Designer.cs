namespace TramVerdeelSysteem
{
    partial class BlockSector
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
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnCancelBlock = new System.Windows.Forms.Button();
            this.tbTrackNumber = new System.Windows.Forms.TextBox();
            this.lbTrackNumber = new System.Windows.Forms.Label();
            this.tbSectorNumber = new System.Windows.Forms.TextBox();
            this.lbSectorNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(15, 131);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(106, 37);
            this.btnBlock.TabIndex = 7;
            this.btnBlock.Text = "Blokkeer";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnCancelBlock
            // 
            this.btnCancelBlock.Location = new System.Drawing.Point(127, 131);
            this.btnCancelBlock.Name = "btnCancelBlock";
            this.btnCancelBlock.Size = new System.Drawing.Size(106, 37);
            this.btnCancelBlock.TabIndex = 6;
            this.btnCancelBlock.Text = "Annuleren";
            this.btnCancelBlock.UseVisualStyleBackColor = true;
            this.btnCancelBlock.Click += new System.EventHandler(this.btnCancelBlock_Click);
            // 
            // tbTrackNumber
            // 
            this.tbTrackNumber.Location = new System.Drawing.Point(12, 68);
            this.tbTrackNumber.Name = "tbTrackNumber";
            this.tbTrackNumber.Size = new System.Drawing.Size(257, 22);
            this.tbTrackNumber.TabIndex = 5;
            // 
            // lbTrackNumber
            // 
            this.lbTrackNumber.AutoSize = true;
            this.lbTrackNumber.Location = new System.Drawing.Point(12, 33);
            this.lbTrackNumber.Name = "lbTrackNumber";
            this.lbTrackNumber.Size = new System.Drawing.Size(101, 17);
            this.lbTrackNumber.TabIndex = 4;
            this.lbTrackNumber.Text = "Spoor nummer";
            this.lbTrackNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbSectorNumber
            // 
            this.tbSectorNumber.Location = new System.Drawing.Point(315, 68);
            this.tbSectorNumber.Name = "tbSectorNumber";
            this.tbSectorNumber.Size = new System.Drawing.Size(257, 22);
            this.tbSectorNumber.TabIndex = 9;
            // 
            // lbSectorNumber
            // 
            this.lbSectorNumber.AutoSize = true;
            this.lbSectorNumber.Location = new System.Drawing.Point(315, 33);
            this.lbSectorNumber.Name = "lbSectorNumber";
            this.lbSectorNumber.Size = new System.Drawing.Size(104, 17);
            this.lbSectorNumber.TabIndex = 8;
            this.lbSectorNumber.Text = "Sector nummer";
            this.lbSectorNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BlockSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 208);
            this.Controls.Add(this.tbSectorNumber);
            this.Controls.Add(this.lbSectorNumber);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnCancelBlock);
            this.Controls.Add(this.tbTrackNumber);
            this.Controls.Add(this.lbTrackNumber);
            this.Name = "BlockSector";
            this.Text = "Blokkades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnCancelBlock;
        private System.Windows.Forms.TextBox tbTrackNumber;
        private System.Windows.Forms.Label lbTrackNumber;
        private System.Windows.Forms.TextBox tbSectorNumber;
        private System.Windows.Forms.Label lbSectorNumber;
    }
}