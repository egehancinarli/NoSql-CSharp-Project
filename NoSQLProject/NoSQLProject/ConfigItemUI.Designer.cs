namespace NoSQLProject
{
    partial class ConfigItemUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigItemUi));
            this.NewConfigItem = new System.Windows.Forms.Button();
            this.textBoxFilterCI = new System.Windows.Forms.TextBox();
            this.buttonEditConfigItem = new System.Windows.Forms.Button();
            this.dataGridViewConfigItem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigItem)).BeginInit();
            this.SuspendLayout();
            // 
            // NewConfigItem
            // 
            this.NewConfigItem.Location = new System.Drawing.Point(16, 476);
            this.NewConfigItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewConfigItem.Name = "NewConfigItem";
            this.NewConfigItem.Size = new System.Drawing.Size(148, 63);
            this.NewConfigItem.TabIndex = 3;
            this.NewConfigItem.Text = "Add New Configuration Item";
            this.NewConfigItem.UseVisualStyleBackColor = true;
            this.NewConfigItem.Click += new System.EventHandler(this.NewConfigItem_Click);
            // 
            // textBoxFilterCI
            // 
            this.textBoxFilterCI.Location = new System.Drawing.Point(789, 15);
            this.textBoxFilterCI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterCI.Name = "textBoxFilterCI";
            this.textBoxFilterCI.Size = new System.Drawing.Size(260, 22);
            this.textBoxFilterCI.TabIndex = 1;
            this.textBoxFilterCI.Text = "Filter Items...";
            this.textBoxFilterCI.Click += new System.EventHandler(this.textBoxFilterCI_Click);
            this.textBoxFilterCI.TextChanged += new System.EventHandler(this.textBoxFilterCI_TextChanged);
            // 
            // buttonEditConfigItem
            // 
            this.buttonEditConfigItem.Location = new System.Drawing.Point(172, 476);
            this.buttonEditConfigItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditConfigItem.Name = "buttonEditConfigItem";
            this.buttonEditConfigItem.Size = new System.Drawing.Size(148, 63);
            this.buttonEditConfigItem.TabIndex = 4;
            this.buttonEditConfigItem.Text = "Edit Selected Configuration Item";
            this.buttonEditConfigItem.UseVisualStyleBackColor = true;
            this.buttonEditConfigItem.Click += new System.EventHandler(this.buttonEditConfigItem_Click);
            // 
            // dataGridViewConfigItem
            // 
            this.dataGridViewConfigItem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewConfigItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConfigItem.Location = new System.Drawing.Point(16, 47);
            this.dataGridViewConfigItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewConfigItem.Name = "dataGridViewConfigItem";
            this.dataGridViewConfigItem.ReadOnly = true;
            this.dataGridViewConfigItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewConfigItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewConfigItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConfigItem.Size = new System.Drawing.Size(1035, 422);
            this.dataGridViewConfigItem.TabIndex = 5;
            this.dataGridViewConfigItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConfigItem_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Configuration Items";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(906, 478);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(148, 63);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Back to Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // ConfigItemUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewConfigItem);
            this.Controls.Add(this.buttonEditConfigItem);
            this.Controls.Add(this.textBoxFilterCI);
            this.Controls.Add(this.NewConfigItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConfigItemUi";
            this.Text = "Configuration Item Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigItemUi_FormClosing);
            this.Load += new System.EventHandler(this.ConfigItemUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewConfigItem;
        private System.Windows.Forms.TextBox textBoxFilterCI;
        private System.Windows.Forms.Button buttonEditConfigItem;
        private System.Windows.Forms.DataGridView dataGridViewConfigItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
    }
}