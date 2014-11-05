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
            this.lbDeleteTram = new System.Windows.Forms.Label();
            this.tbDeleteTram = new System.Windows.Forms.TextBox();
            this.btnCancelDelete = new System.Windows.Forms.Button();
            this.btnDeleteTram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDeleteTram
            // 
            this.lbDeleteTram.AutoSize = true;
            this.lbDeleteTram.Location = new System.Drawing.Point(12, 37);
            this.lbDeleteTram.Name = "lbDeleteTram";
            this.lbDeleteTram.Size = new System.Drawing.Size(96, 17);
            this.lbDeleteTram.TabIndex = 0;
            this.lbDeleteTram.Text = "Tram nummer";
            this.lbDeleteTram.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbDeleteTram
            // 
            this.tbDeleteTram.Location = new System.Drawing.Point(12, 72);
            this.tbDeleteTram.Name = "tbDeleteTram";
            this.tbDeleteTram.Size = new System.Drawing.Size(360, 22);
            this.tbDeleteTram.TabIndex = 1;
            // 
            // btnCancelDelete
            // 
            this.btnCancelDelete.Location = new System.Drawing.Point(127, 135);
            this.btnCancelDelete.Name = "btnCancelDelete";
            this.btnCancelDelete.Size = new System.Drawing.Size(106, 37);
            this.btnCancelDelete.TabIndex = 2;
            this.btnCancelDelete.Text = "Annuleren";
            this.btnCancelDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTram
            // 
            this.btnDeleteTram.Location = new System.Drawing.Point(15, 135);
            this.btnDeleteTram.Name = "btnDeleteTram";
            this.btnDeleteTram.Size = new System.Drawing.Size(106, 37);
            this.btnDeleteTram.TabIndex = 3;
            this.btnDeleteTram.Text = "Verwijderen";
            this.btnDeleteTram.UseVisualStyleBackColor = true;
            // 
            // DeleteTram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 198);
            this.Controls.Add(this.btnDeleteTram);
            this.Controls.Add(this.btnCancelDelete);
            this.Controls.Add(this.tbDeleteTram);
            this.Controls.Add(this.lbDeleteTram);
            this.Name = "DeleteTram";
            this.Text = "Tram verwijderen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDeleteTram;
        private System.Windows.Forms.TextBox tbDeleteTram;
        private System.Windows.Forms.Button btnCancelDelete;
        private System.Windows.Forms.Button btnDeleteTram;
    }
}