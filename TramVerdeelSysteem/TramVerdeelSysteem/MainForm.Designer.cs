namespace TramVerdeelSysteem
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
            this.components = new System.ComponentModel.Container();
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
            this.tbTrackNumber = new System.Windows.Forms.TextBox();
            this.lbTrackNumber = new System.Windows.Forms.Label();
            this.tbTramNumber = new System.Windows.Forms.TextBox();
            this.lbTramNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.lbReservations = new System.Windows.Forms.ListBox();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Sector = new System.Windows.Forms.ToolStripMenuItem();
            this.ToggleBlokkeren = new System.Windows.Forms.ToolStripMenuItem();
            this.Tram = new System.Windows.Forms.ToolStripMenuItem();
            this.Toevoegen = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.verwijderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verplaatsenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlTrack.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ContextMenu.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1273, 28);
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
            this.schoonmaakToolStripMenuItem.Click += new System.EventHandler(this.schoonmaakToolStripMenuItem_Click);
            // 
            // reparatieToolStripMenuItem
            // 
            this.reparatieToolStripMenuItem.Name = "reparatieToolStripMenuItem";
            this.reparatieToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.reparatieToolStripMenuItem.Text = "Reparatie";
            this.reparatieToolStripMenuItem.Click += new System.EventHandler(this.reparatieToolStripMenuItem_Click);
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
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            // 
            // afsluitenToolStripMenuItem1
            // 
            this.afsluitenToolStripMenuItem1.Name = "afsluitenToolStripMenuItem1";
            this.afsluitenToolStripMenuItem1.Size = new System.Drawing.Size(144, 24);
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
            this.pnlTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTrack.Name = "pnlTrack";
            this.pnlTrack.Size = new System.Drawing.Size(230, 163);
            this.pnlTrack.TabIndex = 4;
            // 
            // tbTrackNumber
            // 
            this.tbTrackNumber.Location = new System.Drawing.Point(9, 87);
            this.tbTrackNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTrackNumber.Name = "tbTrackNumber";
            this.tbTrackNumber.Size = new System.Drawing.Size(204, 22);
            this.tbTrackNumber.TabIndex = 9;
            // 
            // lbTrackNumber
            // 
            this.lbTrackNumber.AutoSize = true;
            this.lbTrackNumber.Location = new System.Drawing.Point(9, 64);
            this.lbTrackNumber.Name = "lbTrackNumber";
            this.lbTrackNumber.Size = new System.Drawing.Size(30, 17);
            this.lbTrackNumber.TabIndex = 8;
            this.lbTrackNumber.Text = "Lijn";
            this.lbTrackNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbTramNumber
            // 
            this.tbTramNumber.Location = new System.Drawing.Point(5, 30);
            this.tbTramNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTramNumber.Name = "tbTramNumber";
            this.tbTramNumber.Size = new System.Drawing.Size(207, 22);
            this.tbTramNumber.TabIndex = 7;
            // 
            // lbTramNumber
            // 
            this.lbTramNumber.AutoSize = true;
            this.lbTramNumber.Location = new System.Drawing.Point(5, 7);
            this.lbTramNumber.Name = "lbTramNumber";
            this.lbTramNumber.Size = new System.Drawing.Size(41, 17);
            this.lbTramNumber.TabIndex = 6;
            this.lbTramNumber.Text = "Tram";
            this.lbTramNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(267, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 746);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteReservation);
            this.groupBox1.Controls.Add(this.btnAddReservation);
            this.groupBox1.Controls.Add(this.lbReservations);
            this.groupBox1.Location = new System.Drawing.Point(13, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(229, 519);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserveringen";
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReservation.Location = new System.Drawing.Point(42, 539);
            this.btnDeleteReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(31, 31);
            this.btnDeleteReservation.TabIndex = 2;
            this.btnDeleteReservation.Text = "x";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.Location = new System.Drawing.Point(6, 539);
            this.btnAddReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(31, 31);
            this.btnAddReservation.TabIndex = 1;
            this.btnAddReservation.Text = "+";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // lbReservations
            // 
            this.lbReservations.FormattingEnabled = true;
            this.lbReservations.ItemHeight = 16;
            this.lbReservations.Items.AddRange(new object[] {
            " "});
            this.lbReservations.Location = new System.Drawing.Point(5, 32);
            this.lbReservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbReservations.Name = "lbReservations";
            this.lbReservations.Size = new System.Drawing.Size(217, 500);
            this.lbReservations.TabIndex = 0;
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sector,
            this.Tram});
            this.ContextMenu.Name = "contextMenuStrip1";
            this.ContextMenu.Size = new System.Drawing.Size(176, 80);
            this.ContextMenu.Text = "Tram Verdeel Systeem";
            // 
            // Sector
            // 
            this.Sector.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToggleBlokkeren});
            this.Sector.Name = "Sector";
            this.Sector.Size = new System.Drawing.Size(120, 24);
            this.Sector.Text = "Sector";
            // 
            // ToggleBlokkeren
            // 
            this.ToggleBlokkeren.Name = "ToggleBlokkeren";
            this.ToggleBlokkeren.Size = new System.Drawing.Size(194, 24);
            this.ToggleBlokkeren.Text = "Toggle Blokkeren";
            this.ToggleBlokkeren.Click += new System.EventHandler(this.ToggleBlock);
            // 
            // Tram
            // 
            this.Tram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Toevoegen,
            this.verwijderenToolStripMenuItem,
            this.verplaatsenToolStripMenuItem});
            this.Tram.Name = "Tram";
            this.Tram.Size = new System.Drawing.Size(175, 24);
            this.Tram.Text = "Tram";
            // 
            // Toevoegen
            // 
            this.Toevoegen.Name = "Toevoegen";
            this.Toevoegen.Size = new System.Drawing.Size(152, 24);
            this.Toevoegen.Text = "Toevoegen";
            this.Toevoegen.Click += new System.EventHandler(this.AddTram);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Simulatie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSimulation_Click);
            // 
            // verwijderenToolStripMenuItem
            // 
            this.verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
            this.verwijderenToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.verwijderenToolStripMenuItem.Text = "Verwijderen";
            this.verwijderenToolStripMenuItem.Click += new System.EventHandler(this.DeleteTram);
            // 
            // verplaatsenToolStripMenuItem
            // 
            this.verplaatsenToolStripMenuItem.Name = "verplaatsenToolStripMenuItem";
            this.verplaatsenToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.verplaatsenToolStripMenuItem.Text = "Verplaatsen";
            this.verplaatsenToolStripMenuItem.Click += new System.EventHandler(this.MoveTram);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 804);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTrack);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTrack.ResumeLayout(false);
            this.pnlTrack.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem Sector;
        private System.Windows.Forms.ToolStripMenuItem ToggleBlokkeren;
        private System.Windows.Forms.ToolStripMenuItem Tram;
        private System.Windows.Forms.ToolStripMenuItem Toevoegen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem verwijderenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verplaatsenToolStripMenuItem;
    }
}