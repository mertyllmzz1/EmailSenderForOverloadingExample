using System;

namespace EmailSenderForOverloadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] toArr = new string[] { "examp@example.com", "ornek@ornek.com" };
            string to = "mertyllmz1@gmail.com";
            MailSender(toArr, "Toplu gönderim", "Overloading konusu toplu mail örneği");
            MailSender(to, "Tekli gönderim", "Overloading konusu tekil mail örneği");
        }

        public static void MailSender(string[] to, string subject, string content )
        {
            //to parametresi burada diğer MailSender metodunun diğer metottan ayrışmasını sağlayan yapıdır.
            Console.WriteLine(subject+": " + content);
        }
        public static void MailSender(string to, string subject, string content)
        {
            Console.WriteLine(subject + ": " + content);
        }
    }
}
