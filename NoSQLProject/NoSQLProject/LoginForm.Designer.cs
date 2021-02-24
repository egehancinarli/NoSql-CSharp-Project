namespace NoSQLProject
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.ForgotPasswordLbl = new System.Windows.Forms.Label();
            this.RememberMeBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.Location = new System.Drawing.Point(154, 98);
            this.UsernameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(216, 22);
            this.UsernameTxtBox.TabIndex = 0;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(154, 167);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(216, 22);
            this.PasswordTxtBox.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LoginButton.Location = new System.Drawing.Point(154, 257);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(153, 34);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Location = new System.Drawing.Point(69, 98);
            this.Usernamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(77, 17);
            this.Usernamelbl.TabIndex = 3;
            this.Usernamelbl.Text = "Username:";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(73, 170);
            this.Passwordlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(73, 17);
            this.Passwordlbl.TabIndex = 4;
            this.Passwordlbl.Text = "Password:";
            // 
            // ForgotPasswordLbl
            // 
            this.ForgotPasswordLbl.AutoSize = true;
            this.ForgotPasswordLbl.Location = new System.Drawing.Point(151, 372);
            this.ForgotPasswordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ForgotPasswordLbl.Name = "ForgotPasswordLbl";
            this.ForgotPasswordLbl.Size = new System.Drawing.Size(145, 17);
            this.ForgotPasswordLbl.TabIndex = 6;
            this.ForgotPasswordLbl.Text = "Forgotten password ?";
            this.ForgotPasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ForgotPasswordLbl.Click += new System.EventHandler(this.ForgotPasswordLbl_Click);
            // 
            // RememberMeBox
            // 
            this.RememberMeBox.AutoSize = true;
            this.RememberMeBox.Location = new System.Drawing.Point(165, 298);
            this.RememberMeBox.Name = "RememberMeBox";
            this.RememberMeBox.Size = new System.Drawing.Size(122, 21);
            this.RememberMeBox.TabIndex = 7;
            this.RememberMeBox.Text = "Remember me";
            this.RememberMeBox.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(457, 398);
            this.Controls.Add(this.RememberMeBox);
            this.Controls.Add(this.ForgotPasswordLbl);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UsernameTxtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Label ForgotPasswordLbl;
        private System.Windows.Forms.CheckBox RememberMeBox;
    }
}