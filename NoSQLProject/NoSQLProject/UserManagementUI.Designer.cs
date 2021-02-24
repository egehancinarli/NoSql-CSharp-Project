namespace NoSQLProject
{
    partial class UserManagementUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementUI));
            this.btnAdd = new System.Windows.Forms.Button();
            this.userView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketsOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(607, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 48);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Users";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // userView
            // 
            this.userView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Email,
            this.FirstName,
            this.LastName,
            this.Tickets});
            this.userView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userView.HideSelection = false;
            this.userView.Location = new System.Drawing.Point(12, 121);
            this.userView.Name = "userView";
            this.userView.Size = new System.Drawing.Size(776, 349);
            this.userView.TabIndex = 2;
            this.userView.UseCompatibleStateImageBehavior = false;
            this.userView.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Email
            // 
            this.Email.Text = "Email address";
            this.Email.Width = 200;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First name";
            this.FirstName.Width = 200;
            // 
            // LastName
            // 
            this.LastName.Text = "Last name";
            this.LastName.Width = 200;
            // 
            // Tickets
            // 
            this.Tickets.Text = "#Tickets";
            this.Tickets.Width = 200;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(28, 84);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(99, 20);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Search by:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(138, 84);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(138, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 22);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filter:";
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketsOverviewToolStripMenuItem
            // 
            this.ticketsOverviewToolStripMenuItem.Name = "ticketsOverviewToolStripMenuItem";
            this.ticketsOverviewToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.ticketsOverviewToolStripMenuItem.Text = "Dashboard";
            this.ticketsOverviewToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // usersOverviewToolStripMenuItem
            // 
            this.usersOverviewToolStripMenuItem.Name = "usersOverviewToolStripMenuItem";
            this.usersOverviewToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.usersOverviewToolStripMenuItem.Text = "Tickets Overview";
            this.usersOverviewToolStripMenuItem.Click += new System.EventHandler(this.ticketOverviewToolStripMenuItem_Click);
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
            // UserManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.userView);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManagementUI";
            this.Text = "UserManagementUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManagementUI_FormClosing);
            this.Load += new System.EventHandler(this.UserManagementUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView userView;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Tickets;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketsOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}