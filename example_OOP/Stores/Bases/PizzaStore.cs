using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using example_OOP.Pizzas.Bases;

namespace example_OOP.Stores.Bases
{
    public abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            pizza.Deliveried();
        }

        protected abstract Pizza CreatePizza(string type);

        //switch (type)
        //  {
        //      case "cheese":
        //          pizza = new CheesePizza();
        //          break;
        //      case "greek":
        //          pizza = new GreekPizza();
        //          break;
        //      default:
        //          Console.WriteLine("dont have this type");
        //          return;
        //  }
    }
}
