using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using TicketSystemDAO;
using TicketSystemModels;

namespace TicketSystemServices
{
    public class UserService
    {
        private readonly UserDAO userDao;
        public UserService() => userDao = new UserDAO();
        public string VerifyCode { get; private set; }


        public List<User> GetAllUsers()
        {
            return userDao.GetAllUsers();
        }

        // Check username and password are matched with the username and password in the dataabase
        public User ValidateUser(string userName, string enteredPassword)
        {
            PasswordWithSaltHasher passwordHasher = new PasswordWithSaltHasher();

            List<User> users = GetAllUsers();

            foreach (User user in users)
            {
                Password password = BsonSerializer.Deserialize<Password>(user.Password);

                HashWithSaltResult hashPass = passwordHasher.HashWithKnownSalt(enteredPassword, password.Salt, SHA256.Create());

                if (user.UserName == userName && password.HashedPassword == hashPass.Digest)
                {
                    return user;
                }
            }
            return null;
        }

        // check if the email is registered to the database with certain username
        public bool IterateUserEmailsAndUserName(string email, string userName)
        {
            foreach (User user in GetAllUsers())
            {
                if (user.Email == email && user.UserName == userName)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IterateUserName(string userName)
        {
            foreach (User user in GetAllUsers())
            {
                if (user.UserName == userName)
                {

                    return true;
                }
            }
            return false;
        }

        // update password in the database
        public void UpdatePassword(string userName, string enteredPassword)

        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();

            Password password = new Password();

            HashWithSaltResult hashPassword = pwHasher.HashWithSalt(enteredPassword, 64, SHA256.Create());

            password.Salt = hashPassword.Salt;
            password.HashedPassword = hashPassword.Digest;

            userDao.UpdatePassword(userName, password);
        }

        // send email for the verification code for changing password
        public void SendCodeForForgotPassword(string email)
        {
            Random random = new Random();
            VerifyCode = (random.Next(999999)).ToString();
            MailMessage message = new System.Net.Mail.MailMessage();
            string fromEmail = "brockgraham34@gmail.com"; // do not hack this email
            string password = "vearozcwmxsmoolk";  // do not hack this password
            string toEmail = $"{email}";
            message.From = new MailAddress(fromEmail);
            message.To.Add(toEmail);
            message.Subject = "Verification code";
            message.Body = "your reset code is " + VerifyCode;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromEmail, password);

                smtpClient.Send(message.From.ToString(), message.To.ToString(), message.Subject, message.Body);
            }
        }

        public bool ValidateUserName(string newUserName)
        {
            List<User> users = GetAllUsers();

            foreach (User user in users)
            {
                if (user.UserName == newUserName)
                {
                    return false;
                }
            }
            return true;
        }

        public BsonDocument CreateUsertoDatabase(string email, string userName, BsonDocument name, BsonDocument password, UserType userType, string phoneNumber, string location)
        {
            return userDao.CreateUser(email, userName, name, password, userType, phoneNumber, location);
        }

        public void InsertUser(BsonDocument user)
        {
            userDao.InsertUser(user);
        }

        public void SendConfirmationEmail(string email, string username)
        {
            MailMessage message = new System.Net.Mail.MailMessage();
            string fromEmail = "brockgraham34@gmail.com"; // do not hack this email
            string password = "vearozcwmxsmoolk";  // do not hack this password
            string toEmail = $"{email}";
            message.From = new MailAddress(fromEmail);
            message.To.Add(toEmail);
            message.Subject = "Registration Confirmation";
            message.Body = $"The username {username} is newly registered to the database";
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromEmail, password);

                smtpClient.Send(message.From.ToString(), message.To.ToString(), message.Subject, message.Body);
            }
        }

        // Get the user name by its id (Ticket.UserID or Report.UserID)
        public BsonString GetUserNameByID(ObjectId userID)
        {
            return userDao.GetUserNameByID(userID);
        }
    }
}
