using System;
using System.Threading;

namespace _2_WithSingleResponsibility.Classes
{
    public class UserCreator
    {
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
    }
}
