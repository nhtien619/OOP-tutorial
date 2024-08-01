using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using example_OOP.Pizzas.Bases;

namespace example_OOP.Pizzas.NTPizza
{
    public class NTGreekPizza : Pizza
    {
        public NTGreekPizza()
        {
            Name = "NTCheesePizza Greek Pizza";
            Dough = "Thin";
            Sauce = "Very Spicy";
            Toppings = new List<string>() { "Tomato", "Cheese" };
        }
    }
}
