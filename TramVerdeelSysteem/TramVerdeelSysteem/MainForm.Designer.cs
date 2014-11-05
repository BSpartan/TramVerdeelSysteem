﻿namespace TramVerdeelSysteem
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sporenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dienstenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoonmaakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTrack = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbReservations = new System.Windows.Forms.ListBox();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.tbTramNumber = new System.Windows.Forms.TextBox();
            this.lbTramNumber = new System.Windows.Forms.Label();
            this.tbTrackNumber = new System.Windows.Forms.TextBox();
            this.lbTrackNumber = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlTrack.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tramsToolStripMenuItem,
            this.sporenToolStripMenuItem,
            this.lijnenToolStripMenuItem,
            this.dienstenToolStripMenuItem,
            this.schoonmaakToolStripMenuItem,
            this.reparatieToolStripMenuItem,
            this.afsluitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tramsToolStripMenuItem
            // 
            this.tramsToolStripMenuItem.Name = "tramsToolStripMenuItem";
            this.tramsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.tramsToolStripMenuItem.Text = "Trams";
            // 
            // sporenToolStripMenuItem
            // 
            this.sporenToolStripMenuItem.Name = "sporenToolStripMenuItem";
            this.sporenToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sporenToolStripMenuItem.Text = "Sporen";
            // 
            // lijnenToolStripMenuItem
            // 
            this.lijnenToolStripMenuItem.Name = "lijnenToolStripMenuItem";
            this.lijnenToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.lijnenToolStripMenuItem.Text = "Lijnen";
            // 
            // dienstenToolStripMenuItem
            // 
            this.dienstenToolStripMenuItem.Name = "dienstenToolStripMenuItem";
            this.dienstenToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.dienstenToolStripMenuItem.Text = "Diensten";
            // 
            // schoonmaakToolStripMenuItem
            // 
            this.schoonmaakToolStripMenuItem.Name = "schoonmaakToolStripMenuItem";
            this.schoonmaakToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.schoonmaakToolStripMenuItem.Text = "Schoonmaak";
            // 
            // reparatieToolStripMenuItem
            // 
            this.reparatieToolStripMenuItem.Name = "reparatieToolStripMenuItem";
            this.reparatieToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.reparatieToolStripMenuItem.Text = "Reparatie";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uitloggenToolStripMenuItem,
            this.afsluitenToolStripMenuItem1});
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            // 
            // afsluitenToolStripMenuItem1
            // 
            this.afsluitenToolStripMenuItem1.Name = "afsluitenToolStripMenuItem1";
            this.afsluitenToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.afsluitenToolStripMenuItem1.Text = "Afsluiten";
            // 
            // pnlTrack
            // 
            this.pnlTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrack.Controls.Add(this.tbTrackNumber);
            this.pnlTrack.Controls.Add(this.lbTrackNumber);
            this.pnlTrack.Controls.Add(this.tbTramNumber);
            this.pnlTrack.Controls.Add(this.lbTramNumber);
            this.pnlTrack.Location = new System.Drawing.Point(12, 47);
            this.pnlTrack.Name = "pnlTrack";
            this.pnlTrack.Size = new System.Drawing.Size(230, 142);
            this.pnlTrack.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(267, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 534);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteReservation);
            this.groupBox1.Controls.Add(this.btnAddReservation);
            this.groupBox1.Controls.Add(this.lbReservations);
            this.groupBox1.Location = new System.Drawing.Point(13, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 362);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserveringen";
            // 
            // lbReservations
            // 
            this.lbReservations.FormattingEnabled = true;
            this.lbReservations.ItemHeight = 16;
            this.lbReservations.Items.AddRange(new object[] {
            " "});
            this.lbReservations.Location = new System.Drawing.Point(6, 32);
            this.lbReservations.Name = "lbReservations";
            this.lbReservations.Size = new System.Drawing.Size(217, 292);
            this.lbReservations.TabIndex = 0;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.Location = new System.Drawing.Point(6, 328);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(31, 31);
            this.btnAddReservation.TabIndex = 1;
            this.btnAddReservation.Text = "+";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReservation.Location = new System.Drawing.Point(43, 328);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(31, 31);
            this.btnDeleteReservation.TabIndex = 2;
            this.btnDeleteReservation.Text = "x";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            // 
            // tbTramNumber
            // 
            this.tbTramNumber.Location = new System.Drawing.Point(6, 29);
            this.tbTramNumber.Name = "tbTramNumber";
            this.tbTramNumber.Size = new System.Drawing.Size(207, 22);
            this.tbTramNumber.TabIndex = 7;
            // 
            // lbTramNumber
            // 
            this.lbTramNumber.AutoSize = true;
            this.lbTramNumber.Location = new System.Drawing.Point(6, 7);
            this.lbTramNumber.Name = "lbTramNumber";
            this.lbTramNumber.Size = new System.Drawing.Size(41, 17);
            this.lbTramNumber.TabIndex = 6;
            this.lbTramNumber.Text = "Tram";
            this.lbTramNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbTrackNumber
            // 
            this.tbTrackNumber.Location = new System.Drawing.Point(9, 91);
            this.tbTrackNumber.Name = "tbTrackNumber";
            this.tbTrackNumber.Size = new System.Drawing.Size(204, 22);
            this.tbTrackNumber.TabIndex = 9;
            // 
            // lbTrackNumber
            // 
            this.lbTrackNumber.AutoSize = true;
            this.lbTrackNumber.Location = new System.Drawing.Point(9, 68);
            this.lbTrackNumber.Name = "lbTrackNumber";
            this.lbTrackNumber.Size = new System.Drawing.Size(30, 17);
            this.lbTrackNumber.TabIndex = 8;
            this.lbTrackNumber.Text = "Lijn";
            this.lbTrackNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTrack);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTrack.ResumeLayout(false);
            this.pnlTrack.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sporenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dienstenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoonmaakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlTrack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.ListBox lbReservations;
        private System.Windows.Forms.TextBox tbTrackNumber;
        private System.Windows.Forms.Label lbTrackNumber;
        private System.Windows.Forms.TextBox tbTramNumber;
        private System.Windows.Forms.Label lbTramNumber;
    }
}