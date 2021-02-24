namespace NoSQLProject
{
    partial class TransferTicketsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferTicketsUI));
            this.lblOldUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.flwDescription = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDescriptionFlow = new System.Windows.Forms.Label();
            this.flwDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOldUser
            // 
            this.lblOldUser.AutoSize = true;
            this.lblOldUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldUser.Location = new System.Drawing.Point(12, 170);
            this.lblOldUser.Name = "lblOldUser";
            this.lblOldUser.Size = new System.Drawing.Size(165, 25);
            this.lblOldUser.TabIndex = 0;
            this.lblOldUser.Text = "Reported By(old):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reported By(new):";
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(220, 214);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(225, 24);
            this.cmbUsers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "TICKET INFORMATION\r\n";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(12, 79);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(95, 25);
            this.lblDeadline.TabIndex = 4;
            this.lblDeadline.Text = "Deadline:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(12, 126);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(129, 25);
            this.lblPriority.TabIndex = 5;
            this.lblPriority.Text = "Priority Level:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 25);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(339, 399);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 39);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update User";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // flwDescription
            // 
            this.flwDescription.Controls.Add(this.lblDescription);
            this.flwDescription.Controls.Add(this.lblDescriptionFlow);
            this.flwDescription.Location = new System.Drawing.Point(17, 265);
            this.flwDescription.Name = "flwDescription";
            this.flwDescription.Size = new System.Drawing.Size(771, 114);
            this.flwDescription.TabIndex = 8;
            // 
            // lblDescriptionFlow
            // 
            this.lblDescriptionFlow.AutoSize = true;
            this.lblDescriptionFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionFlow.Location = new System.Drawing.Point(124, 0);
            this.lblDescriptionFlow.Name = "lblDescriptionFlow";
            this.lblDescriptionFlow.Size = new System.Drawing.Size(32, 25);
            this.lblDescriptionFlow.TabIndex = 7;
            this.lblDescriptionFlow.Text = "    ";
            // 
            // TransferTicketsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flwDescription);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOldUser);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferTicketsUI";
            this.Text = "TransferTicketsUI";
            this.Load += new System.EventHandler(this.TransferTicketsUI_Load);
            this.flwDescription.ResumeLayout(false);
            this.flwDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.FlowLayoutPanel flwDescription;
        private System.Windows.Forms.Label lblDescriptionFlow;
    }
}