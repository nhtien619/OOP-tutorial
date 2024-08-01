using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class Ticket
    {
        private IPromoteStrategy promoteStrategy;
        private double Price { get; set; }
        public string Name { get; set; }

        public IPromoteStrategy GetPromoteStragegy()
        {
            return promoteStrategy;
        }

        public void SetPromoteStragegy(IPromoteStrategy value)
        {
             promoteStrategy = value;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }

        public double GetPrice()
        {
            return Price;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public Ticket() {
        }
        public Ticket(IPromoteStrategy _promoteStrategy)
        { 
            promoteStrategy = _promoteStrategy;
        }

        public double GetPromotedPrice() {
            return promoteStrategy.DoDiscont(Price);
        }
    }
}
