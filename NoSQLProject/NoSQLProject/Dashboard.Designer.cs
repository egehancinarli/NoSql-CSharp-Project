namespace NoSQLProject
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.lblHighPriorityTickets = new System.Windows.Forms.Label();
            this.lblNormalPriorityTickets = new System.Windows.Forms.Label();
            this.lblLowPriorityTickets = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUrgentTickets = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.pnlPersonal = new System.Windows.Forms.Panel();
            this.lblPersonalTicketInfo = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.listViewTicket = new System.Windows.Forms.ListView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketsOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivedItemsViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArchive = new System.Windows.Forms.Button();
            this.cmbDashboardType = new System.Windows.Forms.ComboBox();
            this.pnlGeneral.SuspendLayout();
            this.pnlPersonal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(358, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active Tickets";
            // 
            // lblHighPriorityTickets
            // 
            this.lblHighPriorityTickets.AutoSize = true;
            this.lblHighPriorityTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighPriorityTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.lblHighPriorityTickets.Location = new System.Drawing.Point(358, 33);
            this.lblHighPriorityTickets.Name = "lblHighPriorityTickets";
            this.lblHighPriorityTickets.Size = new System.Drawing.Size(42, 15);
            this.lblHighPriorityTickets.TabIndex = 1;
            this.lblHighPriorityTickets.Text = "_____";
            // 
            // lblNormalPriorityTickets
            // 
            this.lblNormalPriorityTickets.AutoSize = true;
            this.lblNormalPriorityTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormalPriorityTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.lblNormalPriorityTickets.Location = new System.Drawing.Point(358, 57);
            this.lblNormalPriorityTickets.Name = "lblNormalPriorityTickets";
            this.lblNormalPriorityTickets.Size = new System.Drawing.Size(42, 15);
            this.lblNormalPriorityTickets.TabIndex = 2;
            this.lblNormalPriorityTickets.Text = "_____";
            // 
            // lblLowPriorityTickets
            // 
            this.lblLowPriorityTickets.AutoSize = true;
            this.lblLowPriorityTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowPriorityTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.lblLowPriorityTickets.Location = new System.Drawing.Point(358, 81);
            this.lblLowPriorityTickets.Name = "lblLowPriorityTickets";
            this.lblLowPriorityTickets.Size = new System.Drawing.Size(42, 15);
            this.lblLowPriorityTickets.TabIndex = 3;
            this.lblLowPriorityTickets.Text = "_____";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tickets That Need Attention";
            // 
            // lblUrgentTickets
            // 
            this.lblUrgentTickets.AutoSize = true;
            this.lblUrgentTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgentTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.lblUrgentTickets.Location = new System.Drawing.Point(3, 24);
            this.lblUrgentTickets.Name = "lblUrgentTickets";
            this.lblUrgentTickets.Size = new System.Drawing.Size(42, 15);
            this.lblUrgentTickets.TabIndex = 5;
            this.lblUrgentTickets.Text = "_____";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.lblStatus.Location = new System.Drawing.Point(3, 272);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 18);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.lblDateTime.Location = new System.Drawing.Point(461, 36);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateTime.Size = new System.Drawing.Size(47, 15);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "_____";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.label1);
            this.pnlGeneral.Controls.Add(this.lblHighPriorityTickets);
            this.pnlGeneral.Controls.Add(this.lblNormalPriorityTickets);
            this.pnlGeneral.Controls.Add(this.lblLowPriorityTickets);
            this.pnlGeneral.Controls.Add(this.label2);
            this.pnlGeneral.Controls.Add(this.lblUrgentTickets);
            this.pnlGeneral.Controls.Add(this.lblStatus);
            this.pnlGeneral.Location = new System.Drawing.Point(15, 71);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(573, 276);
            this.pnlGeneral.TabIndex = 9;
            // 
            // pnlPersonal
            // 
            this.pnlPersonal.Controls.Add(this.lblPersonalTicketInfo);
            this.pnlPersonal.Controls.Add(this.lblWelcome);
            this.pnlPersonal.Controls.Add(this.listViewTicket);
            this.pnlPersonal.Location = new System.Drawing.Point(14, 71);
            this.pnlPersonal.Name = "pnlPersonal";
            this.pnlPersonal.Size = new System.Drawing.Size(573, 277);
            this.pnlPersonal.TabIndex = 10;
            // 
            // lblPersonalTicketInfo
            // 
            this.lblPersonalTicketInfo.AutoSize = true;
            this.lblPersonalTicketInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalTicketInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.lblPersonalTicketInfo.Location = new System.Drawing.Point(10, 67);
            this.lblPersonalTicketInfo.Name = "lblPersonalTicketInfo";
            this.lblPersonalTicketInfo.Size = new System.Drawing.Size(42, 15);
            this.lblPersonalTicketInfo.TabIndex = 6;
            this.lblPersonalTicketInfo.Text = "_____";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.lblWelcome.Location = new System.Drawing.Point(10, 23);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(53, 18);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "_____";
            // 
            // listViewTicket
            // 
            this.listViewTicket.AllowColumnReorder = true;
            this.listViewTicket.FullRowSelect = true;
            this.listViewTicket.HideSelection = false;
            this.listViewTicket.Location = new System.Drawing.Point(226, 23);
            this.listViewTicket.Name = "listViewTicket";
            this.listViewTicket.Size = new System.Drawing.Size(346, 256);
            this.listViewTicket.TabIndex = 0;
            this.listViewTicket.UseCompatibleStateImageBehavior = false;
            this.listViewTicket.View = System.Windows.Forms.View.Details;
            this.listViewTicket.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewTicket_ColumnClick);
            this.listViewTicket.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewTicket_MouseDoubleClick);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.Location = new System.Drawing.Point(511, 360);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnRefresh.Location = new System.Drawing.Point(420, 357);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 29);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketsOverviewToolStripMenuItem,
            this.usersOverviewToolStripMenuItem,
            this.configurationItemsToolStripMenuItem,
            this.archivedItemsViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketsOverviewToolStripMenuItem
            // 
            this.ticketsOverviewToolStripMenuItem.Name = "ticketsOverviewToolStripMenuItem";
            this.ticketsOverviewToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.ticketsOverviewToolStripMenuItem.Text = "Tickets  Overview";
            this.ticketsOverviewToolStripMenuItem.Click += new System.EventHandler(this.ticketsOverviewToolStripMenuItem_Click);
            // 
            // usersOverviewToolStripMenuItem
            // 
            this.usersOverviewToolStripMenuItem.Name = "usersOverviewToolStripMenuItem";
            this.usersOverviewToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.usersOverviewToolStripMenuItem.Text = "Users Overview";
            this.usersOverviewToolStripMenuItem.Click += new System.EventHandler(this.usersOverviewToolStripMenuItem_Click);
            // 
            // configurationItemsToolStripMenuItem
            // 
            this.configurationItemsToolStripMenuItem.Name = "configurationItemsToolStripMenuItem";
            this.configurationItemsToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.configurationItemsToolStripMenuItem.Text = "Configuration Items";
            this.configurationItemsToolStripMenuItem.Click += new System.EventHandler(this.configurationItemsToolStripMenuItem_Click);
            // 
            // archivedItemsViewToolStripMenuItem
            // 
            this.archivedItemsViewToolStripMenuItem.Name = "archivedItemsViewToolStripMenuItem";
            this.archivedItemsViewToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.archivedItemsViewToolStripMenuItem.Text = "Archived Items View";
            this.archivedItemsViewToolStripMenuItem.Click += new System.EventHandler(this.archivedItemsViewToolStripMenuItem_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnArchive.Location = new System.Drawing.Point(14, 357);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(0);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(110, 29);
            this.btnArchive.TabIndex = 16;
            this.btnArchive.Text = "Archive Database";
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // cmbDashboardType
            // 
            this.cmbDashboardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDashboardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDashboardType.FormattingEnabled = true;
            this.cmbDashboardType.Location = new System.Drawing.Point(14, 35);
            this.cmbDashboardType.Name = "cmbDashboardType";
            this.cmbDashboardType.Size = new System.Drawing.Size(140, 21);
            this.cmbDashboardType.TabIndex = 17;
            this.cmbDashboardType.SelectedIndexChanged += new System.EventHandler(this.cmbDashboardType_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(600, 402);
            this.Controls.Add(this.cmbDashboardType);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.pnlPersonal);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.pnlPersonal.ResumeLayout(false);
            this.pnlPersonal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHighPriorityTickets;
        private System.Windows.Forms.Label lblNormalPriorityTickets;
        private System.Windows.Forms.Label lblLowPriorityTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUrgentTickets;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Panel pnlPersonal;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListView listViewTicket;
        private System.Windows.Forms.Label lblPersonalTicketInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketsOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationItemsToolStripMenuItem;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.ToolStripMenuItem archivedItemsViewToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbDashboardType;
    }
}