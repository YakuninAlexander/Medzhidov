using System;

namespace _2_WithoutSingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager u = new UserManager();
            ConsoleKey ans;
            Console.WriteLine("Приветствуем вас в системе User Manager 3000.");
            do
            {
                Console.WriteLine("\n\nЧто вы хотите сделать?");
                Console.WriteLine("1. Создать пользователя.");
                Console.WriteLine("2. Отправить письмо подтверждения на почту.");
                Console.WriteLine("3. Сгенерировать пароль.");
                Console.WriteLine("0. Выход.");
                ans = Console.ReadKey().Key;
                Console.WriteLine();
                switch(ans)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Придумайте логин");
                        string username = Console.ReadLine();
                        Console.WriteLine("Придумайте пароль");
                        string password = Console.ReadLine();
                        Console.WriteLine();
                        u.CreateUser(username, password);
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine("Напишите почту куда вы хотите отправить письмо подтверждения.");
                        string email = Console.ReadLine();
                        Console.WriteLine();
                        u.SendConfirmationEmail(email);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Впишите желаемую длину пароля");
                        int length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Ваш сгенерированный пароль: {u.GenerateRandomPassword(length)}");
                        break;

                    case ConsoleKey.D0:
                        Console.WriteLine("Система выключается.");
                        break;

                    default:
                        Console.WriteLine("Возможно вы ошиблись в пункте выбора меню, попробуйте еще раз");
                        break;
                }
            } while (ans != ConsoleKey.D0);
        }
    }
}
