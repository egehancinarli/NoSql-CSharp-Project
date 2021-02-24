namespace NoSQLProject
{
    partial class Archive_View
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
            this.dataGridViewCIArchive = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConfigItem = new System.Windows.Forms.TabPage();
            this.tabPageTicket = new System.Windows.Forms.TabPage();
            this.dataGridViewTicketArchive = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCIArchive)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageConfigItem.SuspendLayout();
            this.tabPageTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCIArchive
            // 
            this.dataGridViewCIArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCIArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCIArchive.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCIArchive.Name = "dataGridViewCIArchive";
            this.dataGridViewCIArchive.ReadOnly = true;
            this.dataGridViewCIArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCIArchive.Size = new System.Drawing.Size(762, 394);
            this.dataGridViewCIArchive.TabIndex = 0;
            this.dataGridViewCIArchive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConfigItem);
            this.tabControl1.Controls.Add(this.tabPageTicket);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageConfigItem
            // 
            this.tabPageConfigItem.Controls.Add(this.dataGridViewCIArchive);
            this.tabPageConfigItem.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfigItem.Name = "tabPageConfigItem";
            this.tabPageConfigItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfigItem.Size = new System.Drawing.Size(768, 400);
            this.tabPageConfigItem.TabIndex = 0;
            this.tabPageConfigItem.Text = "Configuration Item Archive";
            this.tabPageConfigItem.UseVisualStyleBackColor = true;
            // 
            // tabPageTicket
            // 
            this.tabPageTicket.Controls.Add(this.dataGridViewTicketArchive);
            this.tabPageTicket.Location = new System.Drawing.Point(4, 22);
            this.tabPageTicket.Name = "tabPageTicket";
            this.tabPageTicket.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTicket.Size = new System.Drawing.Size(768, 400);
            this.tabPageTicket.TabIndex = 1;
            this.tabPageTicket.Text = "Ticket Archive";
            this.tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTicketArchive
            // 
            this.dataGridViewTicketArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicketArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTicketArchive.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTicketArchive.Name = "dataGridViewTicketArchive";
            this.dataGridViewTicketArchive.ReadOnly = true;
            this.dataGridViewTicketArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTicketArchive.Size = new System.Drawing.Size(762, 394);
            this.dataGridViewTicketArchive.TabIndex = 1;
            // 
            // Archive_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Archive_View";
            this.Text = "Archive_View";
            this.Load += new System.EventHandler(this.Archive_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCIArchive)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageConfigItem.ResumeLayout(false);
            this.tabPageTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketArchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCIArchive;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConfigItem;
        private System.Windows.Forms.TabPage tabPageTicket;
        private System.Windows.Forms.DataGridView dataGridViewTicketArchive;
    }
}