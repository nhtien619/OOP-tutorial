using example_OOP.Store;

namespace example_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaStore = new HCMPizzaStore();
            pizzaStore.OrderPizza("cheese");
            //pizzaStore.OrderPizza("greek");

        }
    }
}