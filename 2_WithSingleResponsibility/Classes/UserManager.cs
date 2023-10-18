using System;
namespace _2_WithSingleResponsibility.Classes
{
    public class UserManager
    {
        private readonly UserCreator userCreator;
        private readonly EmailSender emailSender;
        private readonly PasswordGenerator passwordGenerator;


        public UserManager(UserCreator userCreator, EmailSender emailSender, PasswordGenerator passwordGenerator)
        {
            this.userCreator = userCreator;
            this.emailSender = emailSender;
            this.passwordGenerator = passwordGenerator;
        }

        public UserManager()
        {
            userCreator = new UserCreator();
            emailSender = new EmailSender();
            passwordGenerator = new PasswordGenerator();
        }

        public void CreateUser(string username, string password)
        {
            userCreator.CreateUser(username, password);
        }

        public void SendConfirmationEmail(string email)
        {
            emailSender.SendConfirmationEmail(email);
        }

        public string GenerateRandomPassword(int length)
        {
            return passwordGenerator.GenerateRandomPassword(length);
        }
    }
}
