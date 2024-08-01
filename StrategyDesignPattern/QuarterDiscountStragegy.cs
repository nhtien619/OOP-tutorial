﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class QuarterDiscountStragegy : IPromoteStrategy
    {
        public double DoDiscont(double price)
        {
            return price * 0.75;
        }
    }
}
