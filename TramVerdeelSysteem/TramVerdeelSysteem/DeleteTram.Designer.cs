namespace TramVerdeelSysteem
{
    partial class DeleteTram
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
            this.btnCancelDelete = new System.Windows.Forms.Button();
            this.btnDeleteTram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelDelete
            // 
            this.btnCancelDelete.Location = new System.Drawing.Point(127, 135);
            this.btnCancelDelete.Name = "btnCancelDelete";
            this.btnCancelDelete.Size = new System.Drawing.Size(106, 37);
            this.btnCancelDelete.TabIndex = 2;
            this.btnCancelDelete.Text = "Annuleren";
            this.btnCancelDelete.UseVisualStyleBackColor = true;
            this.btnCancelDelete.Click += new System.EventHandler(this.btnCancelDelete_Click);
            // 
            // btnDeleteTram
            // 
            this.btnDeleteTram.Location = new System.Drawing.Point(15, 135);
            this.btnDeleteTram.Name = "btnDeleteTram";
            this.btnDeleteTram.Size = new System.Drawing.Size(106, 37);
            this.btnDeleteTram.TabIndex = 3;
            this.btnDeleteTram.Text = "Verwijderen";
            this.btnDeleteTram.UseVisualStyleBackColor = true;
            this.btnDeleteTram.Click += new System.EventHandler(this.btnDeleteTram_Click);
            // 
            // DeleteTram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.Controls.Add(this.btnDeleteTram);
            this.Controls.Add(this.btnCancelDelete);
            this.Name = "DeleteTram";
            this.Text = "Tram verwijderen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDeleteTram;
        private System.Windows.Forms.TextBox tbDeleteTram;
        private System.Windows.Forms.Button btnCancelDelete;
        private System.Windows.Forms.Button btnDeleteTram;
    }
}