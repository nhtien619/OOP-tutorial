using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using example_OOP.Pizzas.Bases;

namespace example_OOP.Pizzas.HCMPizza
{
    public class HCMGreekPizza : Pizza
    {
        public HCMGreekPizza() {
            Name = "HCMGreekPizza Greek Pizza";
            Dough = "HCMGreekPizza Thin";
            Sauce = "HCMGreekPizza Very Spicy";
            Toppings = new List<string>() { "Tomato", "Cheese" };
        }
    }
}
