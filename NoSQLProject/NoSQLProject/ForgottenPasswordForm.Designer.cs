namespace NoSQLProject
{
    partial class ForgottenPasswordForm
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
            this.SendBtnUsername = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.AuthenticationTxtBox = new System.Windows.Forms.TextBox();
            this.AuthenticationLbl = new System.Windows.Forms.Label();
            this.AuthenticationBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SendBtnEmail = new System.Windows.Forms.Button();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.IdLbl = new System.Windows.Forms.Label();
            this.ShowIdLbl = new System.Windows.Forms.Label();
            this.ShowNameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.ShowEmailLbl = new System.Windows.Forms.Label();
            this.EmailTextLbl = new System.Windows.Forms.Label();
            this.ShowUsernameLbl = new System.Windows.Forms.Label();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLbl = new System.Windows.Forms.Label();
            this.UsernameTextLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendBtnUsername
            // 
            this.SendBtnUsername.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SendBtnUsername.Location = new System.Drawing.Point(68, 106);
            this.SendBtnUsername.Name = "SendBtnUsername";
            this.SendBtnUsername.Size = new System.Drawing.Size(210, 43);
            this.SendBtnUsername.TabIndex = 0;
            this.SendBtnUsername.Text = "Recover by Username";
            this.SendBtnUsername.UseVisualStyleBackColor = false;
            this.SendBtnUsername.Click += new System.EventHandler(this.SendBtnUsername_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "...";
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.Location = new System.Drawing.Point(68, 78);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(210, 22);
            this.UsernameTxtBox.TabIndex = 2;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(65, 58);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(77, 17);
            this.UsernameLbl.TabIndex = 3;
            this.UsernameLbl.Text = "Username:";
            // 
            // AuthenticationTxtBox
            // 
            this.AuthenticationTxtBox.Location = new System.Drawing.Point(86, 135);
            this.AuthenticationTxtBox.Name = "AuthenticationTxtBox";
            this.AuthenticationTxtBox.Size = new System.Drawing.Size(210, 22);
            this.AuthenticationTxtBox.TabIndex = 5;
            // 
            // AuthenticationLbl
            // 
            this.AuthenticationLbl.AutoSize = true;
            this.AuthenticationLbl.Location = new System.Drawing.Point(117, 106);
            this.AuthenticationLbl.Name = "AuthenticationLbl";
            this.AuthenticationLbl.Size = new System.Drawing.Size(137, 17);
            this.AuthenticationLbl.TabIndex = 6;
            this.AuthenticationLbl.Text = "Authentication code:";
            // 
            // AuthenticationBtn
            // 
            this.AuthenticationBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AuthenticationBtn.Location = new System.Drawing.Point(86, 191);
            this.AuthenticationBtn.Name = "AuthenticationBtn";
            this.AuthenticationBtn.Size = new System.Drawing.Size(210, 43);
            this.AuthenticationBtn.TabIndex = 7;
            this.AuthenticationBtn.Text = "Validate";
            this.AuthenticationBtn.UseVisualStyleBackColor = false;
            this.AuthenticationBtn.Click += new System.EventHandler(this.AuthenticationBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SendBtnEmail);
            this.panel1.Controls.Add(this.EmailTxtBox);
            this.panel1.Controls.Add(this.EmailLbl);
            this.panel1.Controls.Add(this.SendBtnUsername);
            this.panel1.Controls.Add(this.UsernameTxtBox);
            this.panel1.Controls.Add(this.UsernameLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 345);
            this.panel1.TabIndex = 8;
            // 
            // SendBtnEmail
            // 
            this.SendBtnEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SendBtnEmail.Location = new System.Drawing.Point(68, 252);
            this.SendBtnEmail.Name = "SendBtnEmail";
            this.SendBtnEmail.Size = new System.Drawing.Size(210, 43);
            this.SendBtnEmail.TabIndex = 4;
            this.SendBtnEmail.Text = "Recover by Email";
            this.SendBtnEmail.UseVisualStyleBackColor = false;
            this.SendBtnEmail.Click += new System.EventHandler(this.SendBtnEmail_Click);
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(68, 224);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(210, 22);
            this.EmailTxtBox.TabIndex = 5;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(65, 204);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(101, 17);
            this.EmailLbl.TabIndex = 6;
            this.EmailLbl.Text = "Email address:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AuthenticationTxtBox);
            this.panel2.Controls.Add(this.AuthenticationBtn);
            this.panel2.Controls.Add(this.AuthenticationLbl);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 341);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.IdLbl);
            this.panel3.Controls.Add(this.ShowIdLbl);
            this.panel3.Controls.Add(this.ShowNameLbl);
            this.panel3.Controls.Add(this.NameLbl);
            this.panel3.Controls.Add(this.ChangePasswordBtn);
            this.panel3.Controls.Add(this.ShowEmailLbl);
            this.panel3.Controls.Add(this.EmailTextLbl);
            this.panel3.Controls.Add(this.ShowUsernameLbl);
            this.panel3.Controls.Add(this.NewPasswordBox);
            this.panel3.Controls.Add(this.NewPasswordLbl);
            this.panel3.Controls.Add(this.UsernameTextLbl);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 345);
            this.panel3.TabIndex = 10;
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(59, 65);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(80, 17);
            this.IdLbl.TabIndex = 11;
            this.IdLbl.Text = "Account ID:";
            // 
            // ShowIdLbl
            // 
            this.ShowIdLbl.AutoSize = true;
            this.ShowIdLbl.Location = new System.Drawing.Point(175, 62);
            this.ShowIdLbl.Name = "ShowIdLbl";
            this.ShowIdLbl.Size = new System.Drawing.Size(20, 17);
            this.ShowIdLbl.TabIndex = 10;
            this.ShowIdLbl.Text = "...";
            // 
            // ShowNameLbl
            // 
            this.ShowNameLbl.AutoSize = true;
            this.ShowNameLbl.Location = new System.Drawing.Point(175, 135);
            this.ShowNameLbl.Name = "ShowNameLbl";
            this.ShowNameLbl.Size = new System.Drawing.Size(20, 17);
            this.ShowNameLbl.TabIndex = 9;
            this.ShowNameLbl.Text = "...";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(59, 135);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(49, 17);
            this.NameLbl.TabIndex = 8;
            this.NameLbl.Text = "Name:";
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ChangePasswordBtn.Location = new System.Drawing.Point(103, 280);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(151, 44);
            this.ChangePasswordBtn.TabIndex = 7;
            this.ChangePasswordBtn.Text = "Change Password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = false;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // ShowEmailLbl
            // 
            this.ShowEmailLbl.AutoSize = true;
            this.ShowEmailLbl.Location = new System.Drawing.Point(175, 176);
            this.ShowEmailLbl.Name = "ShowEmailLbl";
            this.ShowEmailLbl.Size = new System.Drawing.Size(20, 17);
            this.ShowEmailLbl.TabIndex = 6;
            this.ShowEmailLbl.Text = "...";
            // 
            // EmailTextLbl
            // 
            this.EmailTextLbl.AutoSize = true;
            this.EmailTextLbl.Location = new System.Drawing.Point(59, 176);
            this.EmailTextLbl.Name = "EmailTextLbl";
            this.EmailTextLbl.Size = new System.Drawing.Size(106, 17);
            this.EmailTextLbl.TabIndex = 5;
            this.EmailTextLbl.Text = "E-mail address:";
            // 
            // ShowUsernameLbl
            // 
            this.ShowUsernameLbl.AutoSize = true;
            this.ShowUsernameLbl.Location = new System.Drawing.Point(175, 98);
            this.ShowUsernameLbl.Name = "ShowUsernameLbl";
            this.ShowUsernameLbl.Size = new System.Drawing.Size(20, 17);
            this.ShowUsernameLbl.TabIndex = 4;
            this.ShowUsernameLbl.Text = "...";
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Location = new System.Drawing.Point(172, 224);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.Size = new System.Drawing.Size(146, 22);
            this.NewPasswordBox.TabIndex = 3;
            // 
            // NewPasswordLbl
            // 
            this.NewPasswordLbl.AutoSize = true;
            this.NewPasswordLbl.Location = new System.Drawing.Point(62, 229);
            this.NewPasswordLbl.Name = "NewPasswordLbl";
            this.NewPasswordLbl.Size = new System.Drawing.Size(104, 17);
            this.NewPasswordLbl.TabIndex = 1;
            this.NewPasswordLbl.Text = "New Password:";
            // 
            // UsernameTextLbl
            // 
            this.UsernameTextLbl.AutoSize = true;
            this.UsernameTextLbl.Location = new System.Drawing.Point(59, 98);
            this.UsernameTextLbl.Name = "UsernameTextLbl";
            this.UsernameTextLbl.Size = new System.Drawing.Size(77, 17);
            this.UsernameTextLbl.TabIndex = 0;
            this.UsernameTextLbl.Text = "Username:";
            // 
            // ForgottenPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(362, 367);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "ForgottenPasswordForm";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendBtnUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameTxtBox;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.TextBox AuthenticationTxtBox;
        private System.Windows.Forms.Label AuthenticationLbl;
        private System.Windows.Forms.Button AuthenticationBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label UsernameTextLbl;
        private System.Windows.Forms.Label NewPasswordLbl;
        private System.Windows.Forms.Label ShowUsernameLbl;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.Label ShowEmailLbl;
        private System.Windows.Forms.Label EmailTextLbl;
        private System.Windows.Forms.Button ChangePasswordBtn;
        private System.Windows.Forms.Button SendBtnEmail;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label ShowNameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label ShowIdLbl;
    }
}