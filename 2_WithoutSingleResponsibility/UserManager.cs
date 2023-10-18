using System;
using System.Text;
using System.Threading;

namespace _2_WithoutSingleResponsibility
{
    public class UserManager
    {
        private const string AllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        public UserManager()
        {
        }

        public void CreateUser(string username, string password)
        {
            Console.WriteLine($"Проверьте вводимые данные...\nЛогин: {username}\nПароль: {password}");
            Console.WriteLine("Нажмите Enter для подтверждения, и любую другую клавишу для отмены");
            var ans = Console.ReadKey();
            Console.WriteLine();
            if (ans.Key == ConsoleKey.Enter)
            {
                Console.WriteLine($"Создаю пользователя с именем {username} в системе. Ожидайте...");
                Thread.Sleep(2000);
                Console.WriteLine("Пользователь создан. Благодарим за ожидание.");
                return;
            }
            Console.WriteLine("Вы отменили создание пользователя.");
        }

        public void SendConfirmationEmail(string email)
        {
            Console.WriteLine($"Отправляю письмо подтверждения на адрес {email}");
            Thread.Sleep(1000);
            Console.WriteLine("Письмо отправлено.");
        }

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
