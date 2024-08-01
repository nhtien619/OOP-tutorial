using example_OOP.Pizzas.Bases;
using example_OOP.Pizzas.HCMPizza;
using example_OOP.Stores.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_OOP.Store
{
    public class HCMPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                   return new HCMCheesePizza();
                case "greek":
                    return new HCMGreekPizza();
                default:
                    Console.WriteLine("dont have this type");
                    return null;
            }
        }
    }
}
