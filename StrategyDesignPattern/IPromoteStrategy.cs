﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public interface IPromoteStrategy
    {
        double DoDiscont(double price);
    }
}
