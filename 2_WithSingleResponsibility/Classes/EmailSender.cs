using System;
using System.Threading;

namespace _2_WithSingleResponsibility.Classes
{
    public class EmailSender
    {
        public void SendConfirmationEmail(string email)
        {
            Console.WriteLine($"Отправляю письмо подтверждения на адрес {email}");
            Thread.Sleep(1000);
            Console.WriteLine("Письмо отправлено.");
        }
    }
}
