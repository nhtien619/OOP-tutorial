using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class NoDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscont(double price)
        {
            return price;
        }
    }
}
