using Project1.src.OopPrinciples.Abstraction;
namespace Project1
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            emailService.SendEmail();
            
        }
    }
}