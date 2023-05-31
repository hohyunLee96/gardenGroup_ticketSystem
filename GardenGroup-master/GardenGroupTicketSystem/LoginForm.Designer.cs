namespace GardenGroupTicketSystem
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
            this.lblLogin_UserName = new System.Windows.Forms.Label();
            this.lblLogin_Password = new System.Windows.Forms.Label();
            this.txtLogin_UserName = new System.Windows.Forms.TextBox();
            this.txtLogin_Password = new System.Windows.Forms.TextBox();
            this.btnLogin_Login = new System.Windows.Forms.Button();
            this.lblLogin_ForgotPassword = new System.Windows.Forms.Label();
            this.pnForgotPassword = new System.Windows.Forms.Panel();
            this.txtForgotConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblForgotConfirm = new System.Windows.Forms.Label();
            this.lblForgotBack = new System.Windows.Forms.Label();
            this.btnForgotChangePassword = new System.Windows.Forms.Button();
            this.txtForgotPassword = new System.Windows.Forms.TextBox();
            this.txtForgotUserName = new System.Windows.Forms.TextBox();
            this.btnForgotVerifyCode = new System.Windows.Forms.Button();
            this.btnForgotSendCode = new System.Windows.Forms.Button();
            this.txtForgotCode = new System.Windows.Forms.TextBox();
            this.txtForgotEmail = new System.Windows.Forms.TextBox();
            this.lblForgotEmail = new System.Windows.Forms.Label();
            this.lblForgotCode = new System.Windows.Forms.Label();
            this.lblForgotUserName = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.pnForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin_UserName
            // 
            this.lblLogin_UserName.AutoSize = true;
            this.lblLogin_UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin_UserName.Location = new System.Drawing.Point(136, 40);
            this.lblLogin_UserName.Name = "lblLogin_UserName";
            this.lblLogin_UserName.Size = new System.Drawing.Size(87, 21);
            this.lblLogin_UserName.TabIndex = 0;
            this.lblLogin_UserName.Text = "Username";
            // 
            // lblLogin_Password
            // 
            this.lblLogin_Password.AutoSize = true;
            this.lblLogin_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin_Password.Location = new System.Drawing.Point(136, 138);
            this.lblLogin_Password.Name = "lblLogin_Password";
            this.lblLogin_Password.Size = new System.Drawing.Size(82, 21);
            this.lblLogin_Password.TabIndex = 1;
            this.lblLogin_Password.Text = "Password";
            // 
            // txtLogin_UserName
            // 
            this.txtLogin_UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogin_UserName.Location = new System.Drawing.Point(136, 64);
            this.txtLogin_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin_UserName.Multiline = true;
            this.txtLogin_UserName.Name = "txtLogin_UserName";
            this.txtLogin_UserName.Size = new System.Drawing.Size(248, 34);
            this.txtLogin_UserName.TabIndex = 0;
            // 
            // txtLogin_Password
            // 
            this.txtLogin_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogin_Password.Location = new System.Drawing.Point(136, 161);
            this.txtLogin_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin_Password.Multiline = true;
            this.txtLogin_Password.Name = "txtLogin_Password";
            this.txtLogin_Password.PasswordChar = '*';
            this.txtLogin_Password.Size = new System.Drawing.Size(248, 34);
            this.txtLogin_Password.TabIndex = 1;
            // 
            // btnLogin_Login
            // 
            this.btnLogin_Login.BackColor = System.Drawing.Color.White;
            this.btnLogin_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin_Login.Location = new System.Drawing.Point(136, 255);
            this.btnLogin_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin_Login.Name = "btnLogin_Login";
            this.btnLogin_Login.Size = new System.Drawing.Size(248, 54);
            this.btnLogin_Login.TabIndex = 2;
            this.btnLogin_Login.Text = "Login";
            this.btnLogin_Login.UseVisualStyleBackColor = false;
            this.btnLogin_Login.Click += new System.EventHandler(this.btnLogin_Login_Click_1);
            // 
            // lblLogin_ForgotPassword
            // 
            this.lblLogin_ForgotPassword.AutoSize = true;
            this.lblLogin_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin_ForgotPassword.Location = new System.Drawing.Point(165, 318);
            this.lblLogin_ForgotPassword.Name = "lblLogin_ForgotPassword";
            this.lblLogin_ForgotPassword.Size = new System.Drawing.Size(143, 21);
            this.lblLogin_ForgotPassword.TabIndex = 3;
            this.lblLogin_ForgotPassword.Text = "Forgot Password?";
            this.lblLogin_ForgotPassword.Click += new System.EventHandler(this.lblLogin_ForgotPassword_Click);
            // 
            // pnForgotPassword
            // 
            this.pnForgotPassword.Controls.Add(this.txtForgotConfirmPassword);
            this.pnForgotPassword.Controls.Add(this.lblForgotConfirm);
            this.pnForgotPassword.Controls.Add(this.lblForgotBack);
            this.pnForgotPassword.Controls.Add(this.btnForgotChangePassword);
            this.pnForgotPassword.Controls.Add(this.txtForgotPassword);
            this.pnForgotPassword.Controls.Add(this.txtForgotUserName);
            this.pnForgotPassword.Controls.Add(this.btnForgotVerifyCode);
            this.pnForgotPassword.Controls.Add(this.btnForgotSendCode);
            this.pnForgotPassword.Controls.Add(this.txtForgotCode);
            this.pnForgotPassword.Controls.Add(this.txtForgotEmail);
            this.pnForgotPassword.Controls.Add(this.lblForgotEmail);
            this.pnForgotPassword.Controls.Add(this.lblForgotCode);
            this.pnForgotPassword.Controls.Add(this.lblForgotUserName);
            this.pnForgotPassword.Controls.Add(this.lblForgotPassword);
            this.pnForgotPassword.Location = new System.Drawing.Point(0, 0);
            this.pnForgotPassword.Name = "pnForgotPassword";
            this.pnForgotPassword.Size = new System.Drawing.Size(575, 612);
            this.pnForgotPassword.TabIndex = 6;
            // 
            // txtForgotConfirmPassword
            // 
            this.txtForgotConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtForgotConfirmPassword.Location = new System.Drawing.Point(138, 465);
            this.txtForgotConfirmPassword.Multiline = true;
            this.txtForgotConfirmPassword.Name = "txtForgotConfirmPassword";
            this.txtForgotConfirmPassword.PasswordChar = '*';
            this.txtForgotConfirmPassword.Size = new System.Drawing.Size(297, 34);
            this.txtForgotConfirmPassword.TabIndex = 6;
            // 
            // lblForgotConfirm
            // 
            this.lblForgotConfirm.AutoSize = true;
            this.lblForgotConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForgotConfirm.Location = new System.Drawing.Point(138, 432);
            this.lblForgotConfirm.Name = "lblForgotConfirm";
            this.lblForgotConfirm.Size = new System.Drawing.Size(187, 21);
            this.lblForgotConfirm.TabIndex = 12;
            this.lblForgotConfirm.Text = "Confirm New Password";
            // 
            // lblForgotBack
            // 
            this.lblForgotBack.AutoSize = true;
            this.lblForgotBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForgotBack.Location = new System.Drawing.Point(12, 26);
            this.lblForgotBack.Name = "lblForgotBack";
            this.lblForgotBack.Size = new System.Drawing.Size(46, 21);
            this.lblForgotBack.TabIndex = 11;
            this.lblForgotBack.Text = "Back";
            this.lblForgotBack.Click += new System.EventHandler(this.lblForgotBack_Click);
            // 
            // btnForgotChangePassword
            // 
            this.btnForgotChangePassword.BackColor = System.Drawing.Color.White;
            this.btnForgotChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnForgotChangePassword.Location = new System.Drawing.Point(138, 528);
            this.btnForgotChangePassword.Name = "btnForgotChangePassword";
            this.btnForgotChangePassword.Size = new System.Drawing.Size(297, 53);
            this.btnForgotChangePassword.TabIndex = 7;
            this.btnForgotChangePassword.Text = "Change Password";
            this.btnForgotChangePassword.UseVisualStyleBackColor = false;
            this.btnForgotChangePassword.Click += new System.EventHandler(this.btnForgotChangePassword_Click);
            // 
            // txtForgotPassword
            // 
            this.txtForgotPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtForgotPassword.Location = new System.Drawing.Point(138, 391);
            this.txtForgotPassword.Multiline = true;
            this.txtForgotPassword.Name = "txtForgotPassword";
            this.txtForgotPassword.PasswordChar = '*';
            this.txtForgotPassword.Size = new System.Drawing.Size(297, 34);
            this.txtForgotPassword.TabIndex = 5;
            // 
            // txtForgotUserName
            // 
            this.txtForgotUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtForgotUserName.Location = new System.Drawing.Point(138, 125);
            this.txtForgotUserName.Multiline = true;
            this.txtForgotUserName.Name = "txtForgotUserName";
            this.txtForgotUserName.Size = new System.Drawing.Size(297, 34);
            this.txtForgotUserName.TabIndex = 1;
            // 
            // btnForgotVerifyCode
            // 
            this.btnForgotVerifyCode.BackColor = System.Drawing.Color.White;
            this.btnForgotVerifyCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnForgotVerifyCode.Location = new System.Drawing.Point(138, 308);
            this.btnForgotVerifyCode.Name = "btnForgotVerifyCode";
            this.btnForgotVerifyCode.Size = new System.Drawing.Size(297, 34);
            this.btnForgotVerifyCode.TabIndex = 4;
            this.btnForgotVerifyCode.Text = "Verify Code";
            this.btnForgotVerifyCode.UseVisualStyleBackColor = false;
            this.btnForgotVerifyCode.Click += new System.EventHandler(this.btnForgotVerifyCode_Click);
            // 
            // btnForgotSendCode
            // 
            this.btnForgotSendCode.BackColor = System.Drawing.Color.White;
            this.btnForgotSendCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnForgotSendCode.Location = new System.Drawing.Point(138, 176);
            this.btnForgotSendCode.Name = "btnForgotSendCode";
            this.btnForgotSendCode.Size = new System.Drawing.Size(297, 34);
            this.btnForgotSendCode.TabIndex = 2;
            this.btnForgotSendCode.Text = "Send  Verification Code";
            this.btnForgotSendCode.UseVisualStyleBackColor = false;
            this.btnForgotSendCode.Click += new System.EventHandler(this.btnForgotSendCode_Click);
            // 
            // txtForgotCode
            // 
            this.txtForgotCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtForgotCode.Location = new System.Drawing.Point(138, 263);
            this.txtForgotCode.Multiline = true;
            this.txtForgotCode.Name = "txtForgotCode";
            this.txtForgotCode.Size = new System.Drawing.Size(297, 34);
            this.txtForgotCode.TabIndex = 3;
            // 
            // txtForgotEmail
            // 
            this.txtForgotEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtForgotEmail.Location = new System.Drawing.Point(138, 57);
            this.txtForgotEmail.Multiline = true;
            this.txtForgotEmail.Name = "txtForgotEmail";
            this.txtForgotEmail.Size = new System.Drawing.Size(297, 34);
            this.txtForgotEmail.TabIndex = 0;
            // 
            // lblForgotEmail
            // 
            this.lblForgotEmail.AutoSize = true;
            this.lblForgotEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForgotEmail.Location = new System.Drawing.Point(138, 26);
            this.lblForgotEmail.Name = "lblForgotEmail";
            this.lblForgotEmail.Size = new System.Drawing.Size(53, 21);
            this.lblForgotEmail.TabIndex = 7;
            this.lblForgotEmail.Text = "Email";
            // 
            // lblForgotCode
            // 
            this.lblForgotCode.AutoSize = true;
            this.lblForgotCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForgotCode.Location = new System.Drawing.Point(138, 232);
            this.lblForgotCode.Name = "lblForgotCode";
            this.lblForgotCode.Size = new System.Drawing.Size(142, 21);
            this.lblForgotCode.TabIndex = 8;
            this.lblForgotCode.Text = "Verification Code";
            // 
            // lblForgotUserName
            // 
            this.lblForgotUserName.AutoSize = true;
            this.lblForgotUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForgotUserName.Location = new System.Drawing.Point(138, 94);
            this.lblForgotUserName.Name = "lblForgotUserName";
            this.lblForgotUserName.Size = new System.Drawing.Size(87, 21);
            this.lblForgotUserName.TabIndex = 9;
            this.lblForgotUserName.Text = "Username";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForgotPassword.Location = new System.Drawing.Point(138, 357);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(121, 21);
            this.lblForgotPassword.TabIndex = 10;
            this.lblForgotPassword.Text = "New Password";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(575, 613);
            this.Controls.Add(this.pnForgotPassword);
            this.Controls.Add(this.lblLogin_ForgotPassword);
            this.Controls.Add(this.btnLogin_Login);
            this.Controls.Add(this.txtLogin_Password);
            this.Controls.Add(this.txtLogin_UserName);
            this.Controls.Add(this.lblLogin_Password);
            this.Controls.Add(this.lblLogin_UserName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnForgotPassword.ResumeLayout(false);
            this.pnForgotPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin_UserName;
        private System.Windows.Forms.Label lblLogin_Password;
        private System.Windows.Forms.TextBox txtLogin_UserName;
        private System.Windows.Forms.TextBox txtLogin_Password;
        private System.Windows.Forms.Button btnLogin_Login;
        private System.Windows.Forms.Label lblLogin_ForgotPassword;
        private System.Windows.Forms.Panel pnForgotPassword;
        private System.Windows.Forms.Button btnForgotVerifyCode;
        private System.Windows.Forms.Button btnForgotSendCode;
        private System.Windows.Forms.TextBox txtForgotCode;
        private System.Windows.Forms.TextBox txtForgotEmail;
        private System.Windows.Forms.Label lblForgotEmail;
        private System.Windows.Forms.Label lblForgotCode;
        private System.Windows.Forms.Label lblForgotUserName;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Button btnForgotChangePassword;
        private System.Windows.Forms.TextBox txtForgotPassword;
        private System.Windows.Forms.TextBox txtForgotUserName;
        private System.Windows.Forms.Label lblForgotBack;
        private System.Windows.Forms.TextBox txtForgotConfirmPassword;
        private System.Windows.Forms.Label lblForgotConfirm;
    }
}