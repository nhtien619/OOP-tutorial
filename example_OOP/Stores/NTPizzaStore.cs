using example_OOP.Pizzas.Bases;
using example_OOP.Pizzas.HCMPizza;
using example_OOP.Pizzas.NTPizza;
using example_OOP.Stores.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_OOP.Stores
{
    public class NTPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NTCheesePizza();
                case "greek":
                    return new NTGreekPizza();
                default:
                    Console.WriteLine("dont have this type");
                    return null;
            }
        }
    }
}
