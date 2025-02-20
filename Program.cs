using Project1.src.OopPrinciples.Abstraction;
using Project1.src.OopPrinciples.Coupling;
using Project1.src.OopPrinciples.Inheritance;

namespace Project1
{
    public class Program
    {
        static void Main(string[] args)
        {

            var order = new Order(new EmailSender());
            order.PlaceOrder();
            var order2 = new Order(new SmsSender());
            order2.PlaceOrder();
        }
    }
}