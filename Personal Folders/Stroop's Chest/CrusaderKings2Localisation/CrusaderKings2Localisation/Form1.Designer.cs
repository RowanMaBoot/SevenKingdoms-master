namespace CrusaderKings2Localisation
{
    partial class Form1
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
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLocalisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileLabel1 = new System.Windows.Forms.Label();
            this.fileLabel2 = new System.Windows.Forms.Label();
            this.forumPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageFilesToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // manageFilesToolStripMenuItem
            // 
            this.manageFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importEventsToolStripMenuItem,
            this.exportLocalisationToolStripMenuItem});
            this.manageFilesToolStripMenuItem.Name = "manageFilesToolStripMenuItem";
            this.manageFilesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.manageFilesToolStripMenuItem.Text = "Manage Files...";
            // 
            // importEventsToolStripMenuItem
            // 
            this.importEventsToolStripMenuItem.Name = "importEventsToolStripMenuItem";
            this.importEventsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.importEventsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.importEventsToolStripMenuItem.Text = "Import Events...";
            this.importEventsToolStripMenuItem.Click += new System.EventHandler(this.importEventsToolStripMenuItem_Click);
            // 
            // exportLocalisationToolStripMenuItem
            // 
            this.exportLocalisationToolStripMenuItem.Name = "exportLocalisationToolStripMenuItem";
            this.exportLocalisationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.exportLocalisationToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.exportLocalisationToolStripMenuItem.Text = "Export Localization...";
            this.exportLocalisationToolStripMenuItem.Click += new System.EventHandler(this.exportLocalisationToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.optionsToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forumPostToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 542);
            this.dataGridView1.TabIndex = 4;
            // 
            // fileLabel1
            // 
            this.fileLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLabel1.AutoSize = true;
            this.fileLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.fileLabel1.Location = new System.Drawing.Point(968, 9);
            this.fileLabel1.Name = "fileLabel1";
            this.fileLabel1.Size = new System.Drawing.Size(52, 13);
            this.fileLabel1.TabIndex = 6;
            this.fileLabel1.Text = "Filename:";
            // 
            // fileLabel2
            // 
            this.fileLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLabel2.AutoSize = true;
            this.fileLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.fileLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fileLabel2.Location = new System.Drawing.Point(1026, 9);
            this.fileLabel2.Name = "fileLabel2";
            this.fileLabel2.Size = new System.Drawing.Size(16, 13);
            this.fileLabel2.TabIndex = 7;
            this.fileLabel2.Text = "...";
            this.fileLabel2.Click += new System.EventHandler(this.fileLabel2_Click);
            this.fileLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fileLabel2_MouseDown);
            // 
            // forumPostToolStripMenuItem
            // 
            this.forumPostToolStripMenuItem.Name = "forumPostToolStripMenuItem";
            this.forumPostToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.forumPostToolStripMenuItem.Text = "Forum Post";
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1234, 583);
            this.Controls.Add(this.fileLabel2);
            this.Controls.Add(this.fileLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Stroop\'s Localization Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportLocalisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label fileLabel1;
        private System.Windows.Forms.Label fileLabel2;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forumPostToolStripMenuItem;
    }
}

