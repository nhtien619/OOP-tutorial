using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using example_OOP.Pizzas.Bases;

namespace example_OOP.Pizzas.HCMPizza
{
    public class HCMCheesePizza : Pizza
    {
        public HCMCheesePizza() {
            Name = "HCMCheesePizza Cheese Pizza SOS";
            Dough = "HCMCheesePizza Thick";
            Sauce = "HCMCheesePizza Spicy";
            Toppings = new List<string>() { "Onions", "Tie Cheese" };
        }

        public override void Deliveried()
        {
            base.Deliveried();
            Console.WriteLine(">>>>> Deliveried");
        }
    }
}
