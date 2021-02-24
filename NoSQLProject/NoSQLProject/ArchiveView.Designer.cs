namespace NoSQLProject
{
    partial class ArchiveView
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
            this.tabControlTicket = new System.Windows.Forms.TabControl();
            this.tabPageTicket = new System.Windows.Forms.TabPage();
            this.tabPageConfigItem = new System.Windows.Forms.TabPage();
            this.dataGridViewCI = new System.Windows.Forms.DataGridView();
            this.dataGridViewTicket = new System.Windows.Forms.DataGridView();
            this.tabControlTicket.SuspendLayout();
            this.tabPageTicket.SuspendLayout();
            this.tabPageConfigItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTicket
            // 
            this.tabControlTicket.Controls.Add(this.tabPageTicket);
            this.tabControlTicket.Controls.Add(this.tabPageConfigItem);
            this.tabControlTicket.Location = new System.Drawing.Point(12, 12);
            this.tabControlTicket.Name = "tabControlTicket";
            this.tabControlTicket.SelectedIndex = 0;
            this.tabControlTicket.Size = new System.Drawing.Size(776, 426);
            this.tabControlTicket.TabIndex = 0;
            // 
            // tabPageTicket
            // 
            this.tabPageTicket.Controls.Add(this.dataGridViewTicket);
            this.tabPageTicket.Location = new System.Drawing.Point(4, 22);
            this.tabPageTicket.Name = "tabPageTicket";
            this.tabPageTicket.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTicket.Size = new System.Drawing.Size(768, 400);
            this.tabPageTicket.TabIndex = 0;
            this.tabPageTicket.Text = "Ticket Archive";
            this.tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // tabPageConfigItem
            // 
            this.tabPageConfigItem.Controls.Add(this.dataGridViewCI);
            this.tabPageConfigItem.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfigItem.Name = "tabPageConfigItem";
            this.tabPageConfigItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfigItem.Size = new System.Drawing.Size(768, 400);
            this.tabPageConfigItem.TabIndex = 1;
            this.tabPageConfigItem.Text = "Configuration Item Archive";
            this.tabPageConfigItem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCI
            // 
            this.dataGridViewCI.AllowUserToAddRows = false;
            this.dataGridViewCI.AllowUserToDeleteRows = false;
            this.dataGridViewCI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCI.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCI.Name = "dataGridViewCI";
            this.dataGridViewCI.ReadOnly = true;
            this.dataGridViewCI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCI.Size = new System.Drawing.Size(762, 394);
            this.dataGridViewCI.TabIndex = 0;
            this.dataGridViewCI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTicket
            // 
            this.dataGridViewTicket.AllowUserToAddRows = false;
            this.dataGridViewTicket.AllowUserToDeleteRows = false;
            this.dataGridViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTicket.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTicket.Name = "dataGridViewTicket";
            this.dataGridViewTicket.ReadOnly = true;
            this.dataGridViewTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTicket.Size = new System.Drawing.Size(762, 394);
            this.dataGridViewTicket.TabIndex = 0;
            // 
            // ArchiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlTicket);
            this.Name = "ArchiveView";
            this.Text = "ArchiveView";
            this.Load += new System.EventHandler(this.ArchiveView_Load);
            this.tabControlTicket.ResumeLayout(false);
            this.tabPageTicket.ResumeLayout(false);
            this.tabPageConfigItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTicket;
        private System.Windows.Forms.TabPage tabPageTicket;
        private System.Windows.Forms.TabPage tabPageConfigItem;
        private System.Windows.Forms.DataGridView dataGridViewCI;
        private System.Windows.Forms.DataGridView dataGridViewTicket;
    }
}