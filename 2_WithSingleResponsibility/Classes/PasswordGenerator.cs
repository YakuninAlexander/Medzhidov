using System;
using System.Text;

namespace _2_WithSingleResponsibility.Classes
{
    public class PasswordGenerator
    {
        private const string AllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        public string GenerateRandomPassword(int length)
        {
            StringBuilder password = new StringBuilder(length);

            Random random = new Random();
            int maxIndex = AllowedChars.Length;

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(maxIndex);
                password.Append(AllowedChars[randomIndex]);
            }

            return password.ToString();
        }
    }
}
