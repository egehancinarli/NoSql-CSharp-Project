namespace NoSQLProject
{
    partial class TicketsOverview
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsOverview));
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.idColumnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priorityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketsOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewTickets
            // 
            this.listViewTickets.CheckBoxes = true;
            this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnn,
            this.subjectColumn,
            this.userColumn,
            this.dateColumn,
            this.typeColumn,
            this.priorityColumn,
            this.statusColumn});
            this.listViewTickets.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTickets.FullRowSelect = true;
            this.listViewTickets.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.listViewTickets.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewTickets.Location = new System.Drawing.Point(19, 119);
            this.listViewTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(657, 362);
            this.listViewTickets.TabIndex = 0;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
            this.listViewTickets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewTickets_ColumnClick);
            this.listViewTickets.DoubleClick += new System.EventHandler(this.listViewTickets_DoubleClick);
            // 
            // idColumnn
            // 
            this.idColumnn.Text = "ID";
            // 
            // subjectColumn
            // 
            this.subjectColumn.Text = "Subject";
            // 
            // userColumn
            // 
            this.userColumn.Text = "User";
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "Date";
            // 
            // typeColumn
            // 
            this.typeColumn.Text = "Type";
            // 
            // priorityColumn
            // 
            this.priorityColumn.Text = "Priority";
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTicket.Location = new System.Drawing.Point(505, 70);
            this.btnCreateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(171, 43);
            this.btnCreateTicket.TabIndex = 1;
            this.btnCreateTicket.Text = "CREATE INCIDENT";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Overview tickets";
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStatus.Location = new System.Drawing.Point(19, 502);
            this.btnChangeStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(171, 43);
            this.btnChangeStatus.TabIndex = 3;
            this.btnChangeStatus.Text = "Change ticket status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(483, 502);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(193, 34);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.Text = "Search list...";
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // picInfo
            // 
            this.picInfo.BackgroundImage = global::NoSQLProject.Properties.Resources.Info_64;
            this.picInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.picInfo.Location = new System.Drawing.Point(437, 502);
            this.picInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(39, 34);
            this.picInfo.TabIndex = 5;
            this.picInfo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketsOverviewToolStripMenuItem,
            this.usersOverviewToolStripMenuItem,
            this.configurationItemsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketsOverviewToolStripMenuItem
            // 
            this.ticketsOverviewToolStripMenuItem.Name = "ticketsOverviewToolStripMenuItem";
            this.ticketsOverviewToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.ticketsOverviewToolStripMenuItem.Text = "Dashboard";
            this.ticketsOverviewToolStripMenuItem.Click += new System.EventHandler(this.ticketsOverviewToolStripMenuItem_Click);
            // 
            // usersOverviewToolStripMenuItem
            // 
            this.usersOverviewToolStripMenuItem.Name = "usersOverviewToolStripMenuItem";
            this.usersOverviewToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.usersOverviewToolStripMenuItem.Text = "Users Overview";
            this.usersOverviewToolStripMenuItem.Click += new System.EventHandler(this.usersOverviewToolStripMenuItem_Click);
            // 
            // configurationItemsToolStripMenuItem
            // 
            this.configurationItemsToolStripMenuItem.Name = "configurationItemsToolStripMenuItem";
            this.configurationItemsToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.configurationItemsToolStripMenuItem.Text = "Configuration Items";
            this.configurationItemsToolStripMenuItem.Click += new System.EventHandler(this.configurationItemsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // TicketsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(723, 558);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picInfo);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateTicket);
            this.Controls.Add(this.listViewTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TicketsOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketsOverview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicketsOverview_FormClosing);
            this.Load += new System.EventHandler(this.TicketsOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader idColumnn;
        private System.Windows.Forms.ColumnHeader subjectColumn;
        private System.Windows.Forms.ColumnHeader userColumn;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader typeColumn;
        private System.Windows.Forms.ColumnHeader priorityColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketsOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}