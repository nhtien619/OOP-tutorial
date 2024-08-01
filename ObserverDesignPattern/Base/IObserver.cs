﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Base
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void Notify(Subject subject, object arg);
    }
}
