using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ticket starting...");

            var random = new Random();
            for (int i = 1; i <= 5; i++)
            {
                var ticket = new Ticket();
                ticket.SetName($"Ticket {i}");
                ticket.SetPrice(50 * i);

                var stragegyIndex = random.Next(0, 3);
                switch (stragegyIndex)
                {
                    case 0:
                        ticket.SetPromoteStragegy(new NoDiscountStrategy());
                        break;
                    case 1:
                        ticket.SetPromoteStragegy(new QuarterDiscountStragegy());
                        break;
                    default:
                        ticket.SetPromoteStragegy(new HalfDiscountStragegy());
                        break;
                }

                Console.WriteLine($"{ticket.GetName()} " +
                    $"price: {ticket.GetPromotedPrice()} {ticket.GetPromoteStragegy().GetType().Name}");
            }
        }
    }
}
