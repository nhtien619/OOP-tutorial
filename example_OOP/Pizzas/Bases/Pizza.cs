using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_OOP.Pizzas.Bases
{
    public abstract class Pizza
    {
        protected string Name { get; set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }
        protected List<string> Toppings { get; set; }


        public void Prepare()
        {
            Console.WriteLine($"Prepare: {Name}");
            Console.WriteLine($"Tossing dough: {Dough}");
            Console.WriteLine($"adding sauce: {Sauce}");
            Console.WriteLine($"adding toppings:...");
            Toppings?.ForEach(topping =>
            {
                Console.WriteLine(topping);
            });
        }

        public void Bake()
        {
            Console.WriteLine($"Baking: {Name} in 30 minutes");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting: {Name}.....");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {Name}......");
            Console.WriteLine("------------------------------------");
        }

        public virtual void Deliveried()
        {
            Console.WriteLine("Deliveried .......");
        }
    }
}