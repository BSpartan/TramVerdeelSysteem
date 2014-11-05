namespace TramVerdeelSysteem
{
    partial class CleaningForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tramnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commentaar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klaar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tramnummer,
            this.Status,
            this.Commentaar,
            this.Klaar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // Tramnummer
            // 
            this.Tramnummer.Frozen = true;
            this.Tramnummer.HeaderText = "Tramnummer";
            this.Tramnummer.Name = "Tramnummer";
            this.Tramnummer.ReadOnly = true;
            this.Tramnummer.Width = 120;
            // 
            // Status
            // 
            this.Status.Frozen = true;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 200;
            // 
            // Commentaar
            // 
            this.Commentaar.Frozen = true;
            this.Commentaar.HeaderText = "Commentaar";
            this.Commentaar.Name = "Commentaar";
            this.Commentaar.ReadOnly = true;
            this.Commentaar.Width = 300;
            // 
            // Klaar
            // 
            this.Klaar.Frozen = true;
            this.Klaar.HeaderText = "Klaar";
            this.Klaar.Name = "Klaar";
            this.Klaar.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh lijst";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // CleaningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 433);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CleaningForm";
            this.Text = "Schoonmaak systeem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commentaar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klaar;
        private System.Windows.Forms.Button btnRefresh;
    }
}