using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using example_OOP.Pizzas.Bases;

namespace example_OOP.Pizzas.NTPizza
{
    public class NTCheesePizza : Pizza
    {
        public NTCheesePizza()
        {
            Name = "NTCheesePizza Cheese Pizza SOS";
            Dough = "Thick";
            Sauce = "Spicy";
            Toppings = new List<string>() { "Onions", "Tie Cheese" };
        }

        public override void Deliveried()
        {
            base.Deliveried();
            Console.WriteLine(">>>>> Deliveried");
        }
    }
}
