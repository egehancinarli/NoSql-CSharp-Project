namespace NoSQLProject
{
    partial class ConfigItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCIName = new System.Windows.Forms.TextBox();
            this.textBoxCIDescription = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.comboBoxImportance = new System.Windows.Forms.ComboBox();
            this.buttonAddConfigItem = new System.Windows.Forms.Button();
            this.comboBoxOwner = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Of Configuration Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Owner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Importance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Location";
            // 
            // textBoxCIName
            // 
            this.textBoxCIName.Location = new System.Drawing.Point(156, 10);
            this.textBoxCIName.Name = "textBoxCIName";
            this.textBoxCIName.Size = new System.Drawing.Size(248, 20);
            this.textBoxCIName.TabIndex = 5;
            // 
            // textBoxCIDescription
            // 
            this.textBoxCIDescription.AcceptsReturn = true;
            this.textBoxCIDescription.AcceptsTab = true;
            this.textBoxCIDescription.AllowDrop = true;
            this.textBoxCIDescription.Location = new System.Drawing.Point(156, 53);
            this.textBoxCIDescription.Multiline = true;
            this.textBoxCIDescription.Name = "textBoxCIDescription";
            this.textBoxCIDescription.Size = new System.Drawing.Size(248, 69);
            this.textBoxCIDescription.TabIndex = 6;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(156, 201);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(248, 20);
            this.textBoxLocation.TabIndex = 8;
            // 
            // comboBoxImportance
            // 
            this.comboBoxImportance.FormattingEnabled = true;
            this.comboBoxImportance.Location = new System.Drawing.Point(156, 174);
            this.comboBoxImportance.Name = "comboBoxImportance";
            this.comboBoxImportance.Size = new System.Drawing.Size(248, 21);
            this.comboBoxImportance.TabIndex = 9;
            // 
            // buttonAddConfigItem
            // 
            this.buttonAddConfigItem.Location = new System.Drawing.Point(266, 228);
            this.buttonAddConfigItem.Name = "buttonAddConfigItem";
            this.buttonAddConfigItem.Size = new System.Drawing.Size(138, 23);
            this.buttonAddConfigItem.TabIndex = 10;
            this.buttonAddConfigItem.Text = "Add";
            this.buttonAddConfigItem.UseVisualStyleBackColor = true;
            this.buttonAddConfigItem.Click += new System.EventHandler(this.buttonAddConfigItem_Click);
            // 
            // comboBoxOwner
            // 
            this.comboBoxOwner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxOwner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxOwner.FormattingEnabled = true;
            this.comboBoxOwner.Location = new System.Drawing.Point(156, 142);
            this.comboBoxOwner.Name = "comboBoxOwner";
            this.comboBoxOwner.Size = new System.Drawing.Size(248, 21);
            this.comboBoxOwner.TabIndex = 11;
            this.comboBoxOwner.SelectedIndexChanged += new System.EventHandler(this.comboBoxOwner_SelectedIndexChanged);
            // 
            // ConfigItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 263);
            this.Controls.Add(this.comboBoxOwner);
            this.Controls.Add(this.buttonAddConfigItem);
            this.Controls.Add(this.comboBoxImportance);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxCIDescription);
            this.Controls.Add(this.textBoxCIName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfigItemForm";
            this.Text = "Add New Configuration Item";
            this.Load += new System.EventHandler(this.ConfigItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCIName;
        private System.Windows.Forms.TextBox textBoxCIDescription;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxImportance;
        private System.Windows.Forms.Button buttonAddConfigItem;
        private System.Windows.Forms.ComboBox comboBoxOwner;
    }
}