using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using TicketSystemModels;
using TicketSystemServices;

namespace GardenGroupTicketSystem
{
    public partial class LoginForm : Form
    {
        UserService userService = new UserService();
        //ForgotPassword forgotPassword = new ForgotPassword();
        //Login Login = new Login();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnForgotChangePassword.Enabled = false;
            btnForgotVerifyCode.Enabled = false;
            pnForgotPassword.Hide();
        }               
        private void lblLogin_ForgotPassword_Click(object sender, EventArgs e)
        {
            pnForgotPassword.Show();
        }

        private void btnForgotSendCode_Click(object sender, EventArgs e)
        {
            if (userService.IterateUserEmailsAndUserName(txtForgotEmail.Text, txtForgotUserName.Text))
            {
                MessageBox.Show("The verification code is sent via email");
                userService.SendCodeForForgotPassword(txtForgotEmail.Text);
                btnForgotVerifyCode.Enabled = true;
            }
            else if(!userService.IterateUserName(txtForgotUserName.Text))
            {
                MessageBox.Show("The username is not registered in the database");
            }
            else
            {
                MessageBox.Show($"The email is not registered to the database with {txtForgotUserName.Text}.\n please check the email");
            }
        }

        private void btnForgotVerifyCode_Click(object sender, EventArgs e)
        {
            if (userService.VerifyCode == (txtForgotCode.Text))
            {
                MessageBox.Show("The code is verified");
                btnForgotChangePassword.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please check the code. The code is wrong");
            }
        }

        private void btnForgotChangePassword_Click(object sender, EventArgs e)
        {
            if (userService.IterateUserName(txtForgotUserName.Text))
            {
                if (txtForgotPassword.Text == "")
                {
                    MessageBox.Show("Please fill out password");
                }
                else if(txtForgotPassword.Text == txtForgotConfirmPassword.Text)
                {
                    userService.UpdatePassword(txtForgotUserName.Text, txtForgotPassword.Text);
                    CleanTextBox();
                    MessageBox.Show("Password is successfully changed!");
                }
                else
                {
                    MessageBox.Show("The passwords are not same. Please check the password or confirm password");
                }
            }
            else
            {
                MessageBox.Show("Please check the username or email registered to database with username");
            }
        }

        private void CleanTextBox()
        {
            txtForgotEmail.Clear();
            txtForgotUserName.Clear();
            txtForgotPassword.Clear();
            txtForgotCode.Clear();
            txtForgotConfirmPassword.Clear();
        }

        private void btnLogin_Login_Click_1(object sender, EventArgs e)
        {
            string userName = txtLogin_UserName.Text;
            string password = txtLogin_Password.Text;

            User user = userService.ValidateUser(userName, password);
            if (user != null)
            {
                this.Hide();

                //Open Ticket Support Form as a dialog
                TicketSupportForm ticketSupportForm = new TicketSupportForm(user);
                DialogResult closeCode = ticketSupportForm.ShowDialog();

                //On TicketSupportForm close it will never return a dialog result, thus application will always exit after it closes
                if (closeCode != DialogResult.OK)
                    Application.Exit();
            }
            else
            {
                MessageBox.Show("Please check username and password");
            }
        }

        private void lblForgotBack_Click(object sender, EventArgs e)
        {
            pnForgotPassword.Hide();
            CleanTextBox();
        }
    }
}
